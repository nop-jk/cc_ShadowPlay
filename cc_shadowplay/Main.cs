using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Shell32;
using System.Configuration;
using System.Reflection;
using System.Threading;


namespace cc_shadowplay {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();
        }

        // for ffmpeg process
        CancellationTokenSource tokenSource;

        // TextBoxにPlaceholderを実装
        public class TextBoxPlaceHolder : TextBox {
            private string _placeholder = string.Empty;
            public string Placeholder {
                get { return _placeholder; }
                set {
                    _placeholder = value;
                    Invalidate();
                }
            }
            protected override void WndProc(ref System.Windows.Forms.Message m) {
                base.WndProc(ref m);
                if (m.Msg == 15) {
                    if (this.Enabled && !this.ReadOnly && !this.Focused && (_placeholder != null) && (_placeholder.Length > 0) && (this.TextLength == 0)) {
                        using (var g = this.CreateGraphics()) {
                            g.FillRectangle(new System.Drawing.SolidBrush(this.BackColor), this.ClientRectangle);
                            var placeholderTextColor = System.Drawing.Color.FromArgb((this.ForeColor.A >> 1 + this.BackColor.A >> 1), (this.ForeColor.R >> 1 + this.BackColor.R >> 1), ((this.ForeColor.G >> 1 + this.BackColor.G) >> 1), (this.ForeColor.B >> 1 + this.BackColor.B >> 1));
                            g.DrawString(_placeholder, this.Font, new System.Drawing.SolidBrush(placeholderTextColor), 1, 1);
                        }
                    }
                }
            }
        }
        /* 分割 */
        private void btn_before_path_Click(object sender, EventArgs e) {
            string file_name = "";
            using (OpenFileDialog ofd = new OpenFileDialog()) {
                ofd.Filter = "動画ファイル(*.mp4)|*.mp4|すべてのファイル(*.*)|*.*";
                ofd.FilterIndex = 1;
                ofd.Title = "ファイルを選択";
                ofd.RestoreDirectory = true;
                if (ofd.ShowDialog() != DialogResult.OK) {
                    return;
                }
                file_name = ofd.FileName;
            }
            set_videoname_split(file_name);
            
        }

        private void set_videoname_split(string file_name){
            // 動画の再生時間を取得
            int video_size_sec = 0;
            if (!Tools.getPositionValue(file_name, ref video_size_sec)) {
                Tools.ShowError("動画の再生時間取得に失敗しました。\n動画ファイル形式が正しくないか、壊れている可能性があります。");
                return;
            }

            // 各値をセット
            if (Properties.Settings.Default.save_dir == "") {
                // 初回起動時
                tb_after_dir.Text = Path.GetDirectoryName(file_name);
            }
            tb_before_path.Text = file_name;
            tb_filename.Text = Path.GetFileNameWithoutExtension(file_name) + "_clipped" + Path.GetExtension(file_name);
            tb_end_time.Text = TimeSpan.FromSeconds(video_size_sec).ToString();
            label_process_fin_clip.Visible = false;
            progbar_clip.Visible = false;
            progbar_clip.Style = ProgressBarStyle.Blocks;
        }

        private void btn_save_dir_Click(object sender, EventArgs e) {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog()) {
                fbd.Description = "ディレクトリを選択";
                if (fbd.ShowDialog() != DialogResult.OK) {
                    return;
                }
                tb_after_dir.Text = fbd.SelectedPath;
            }
        }

        private void btn_process_Click(object sender, EventArgs e) {
            label_process_fin_clip.Visible = false;
            progbar_clip.Visible = false;

            string ffmpeg = Path.Combine(
                System.IO.Directory.GetCurrentDirectory(),
                "bin",
                "ffmpeg.exe"
            );
            // ffmpeg check
            if (!File.Exists(ffmpeg)) { Tools.ShowError("./bin/ffmpeg.exeが見つかりませんでした"); return; }

            string before_file = tb_before_path.Text;
            try {
                Path.Combine(tb_after_dir.Text, tb_filename.Text);
            } catch {
                Tools.ShowError("ファイル名に無効な文字が含まれています");
                return; 
            }
            string after_file = Path.Combine(tb_after_dir.Text, tb_filename.Text);
            string start_time = tb_start_time.Text;
            string end_time = tb_end_time.Text;

            // 時間チェック
            try {
                TimeSpan.Parse(start_time);
                TimeSpan.Parse(end_time);
            }
            catch {
                Tools.ShowError("時間を正しく入力してください");
                return;
            }
            
            TimeSpan start_duration = TimeSpan.Parse(start_time);
            TimeSpan end_duration = TimeSpan.Parse(end_time);
            TimeSpan cut_time_sec = end_duration - start_duration;
            if (cut_time_sec.TotalSeconds < 0) {
                Tools.ShowError("時間を正しく入力してください（開始時間が終了時間より大きい可能性があります。）");
                return;
            }

            // 動画チェック
            if (!File.Exists(tb_before_path.Text)) { Tools.ShowError("変換前動画が見つかりません"); return; }
            if (!Directory.Exists(tb_after_dir.Text)) { Tools.ShowError("保存先が見つかりません"); return; }
            if (File.Exists(after_file)) {
                if (
                    MessageBox.Show(
                        "保存先に同名ファイルが存在しています。\n上書きしてもよろしいですか？",
                        "注意",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Warning
                   ) == DialogResult.Cancel) {
                    return;
                }
            }

            int video_size_sec = 0;
            if (!Tools.getPositionValue(tb_before_path.Text, ref video_size_sec)) {
                Tools.ShowError("動画の再生時間取得に失敗しました。\n動画ファイル形式が正しくないか、壊れている可能性があります。");
                return;
            }
            if (video_size_sec < end_duration.TotalSeconds) {
                Tools.ShowError("終了時刻が正しくありません（動画の長さより終了時刻のほうが大きい可能性があります）。");
                return;
            }

            // エンコードサイズごとにmodeを変更
            string resolution = "-1:-1";
            if (rb_original.Checked) {
                // original
                resolution = "-1:-1";
            }
            else if (rb_1920x1080.Checked) {
                // 1920x1080
                resolution = "1920:-1";
            }
            else if (rb_1280x720.Checked) {
                // 1280x720
                resolution = "1280:-1";
            }
            else if (rb_custom.Checked) {
                // custom
                try {
                    var s = tb_size_custom.Text.Split('x');
                    int.Parse(s[0]);  // whether a height can be an integer
                    int.Parse(s[1]);  // whether a width can be an integer
                    resolution = String.Format("{0}:{1}", s[0], s[1]);
                }
                catch {
                    Tools.ShowError("サイズの指定が不正です");
                    return;
                }
            }
            else {
                Tools.ShowError("サイズの指定が不正です");
                return;
            }

            // ffmpeg
            // ffmpeg -ss %3 -i %1 -t %40 -acodec copy -vcodec copy %2
            this.ProcessClipAsync(ffmpeg, start_time, before_file, cut_time_sec, after_file, resolution);
        }

        private void btn_abort_Click(object sender, EventArgs e) {
            tokenSource.Cancel();
            label_process_fin_clip.Text = "中止";
            label_process_fin_clip.ForeColor = Color.Red;
        }

        private void btn_preview_Click(object sender, EventArgs e) {
            using (VideoPlayer player = new VideoPlayer()) {
                player.video_file = tb_before_path.Text;
                if (player.ShowDialog() == DialogResult.OK) {
                    tb_start_time.Text = TimeSpan.FromSeconds(player.start_time).ToString();
                    tb_end_time.Text = TimeSpan.FromSeconds(player.end_time).ToString();
                }
            }
        }

        // すべてのコントロールを再帰的に取得
        public List<Control> GetAllWebControl(Control parent) {
            var controls = new List<Control>();

            foreach (Control child in parent.Controls) {
                controls.AddRange(GetAllWebControl(child));
            }

            if (parent is Control) {
                controls.Add((Control)parent);
            }

            return controls;
        }
        public async Task<bool> ProcessClipAsync(string ffmpeg, string start_time, string before_file, TimeSpan cut_time_sec, string after_file, string resolution) {
            // create a cancel token
            tokenSource = new CancellationTokenSource();

            // disable all controls
            foreach (Control c in GetAllWebControl(tabctrl)) {
                if (c.Equals(tabctrl) || c.Equals(tabpg_split)) {
                    // btn_processのparent controlであるtabctrlとtabpg_splitをdisabledにするとbtn_processまでdisabledとなるため対象外とする
                    c.Enabled = true;
                }
                else if (c.Equals(btn_process)) {
                    btn_process.Text = "中止";
                    btn_process.Click -= new System.EventHandler(btn_process_Click);
                    btn_process.Click += new System.EventHandler(btn_abort_Click);
                    c.Enabled = true;
                }
                else {
                    c.Enabled = false;
                }
            }

            progbar_clip.Visible = true;
            progbar_clip.Style = ProgressBarStyle.Marquee;


            await Task.Run(() => {
                using (System.Diagnostics.Process p = new System.Diagnostics.Process()) {

                    p.StartInfo.FileName = ffmpeg;
                    if (resolution == "-1:-1") {
                        p.StartInfo.Arguments = String.Format("-y -ss {0} -i \"{1}\" -t {2} -acodec copy -vcodec copy \"{3}\"", start_time, before_file, cut_time_sec.TotalSeconds, after_file);
                    }
                    else {
                        p.StartInfo.Arguments = String.Format("-y -ss {0} -i \"{1}\" -t {2} -vf scale=\"{3}\" -acodec copy \"{4}\"", start_time, before_file, cut_time_sec.TotalSeconds, resolution, after_file);
                    }
                    p.StartInfo.UseShellExecute = false;
                    p.StartInfo.CreateNoWindow = true;
                    p.StartInfo.WorkingDirectory = System.AppDomain.CurrentDomain.BaseDirectory;
                    p.Start();

                    // p.WaitForExit();
                    while (!p.HasExited) {
                        if (tokenSource.IsCancellationRequested) {
                            // Taskのキャンセル処理
                            p.Kill();
                        }
                        Task.Delay(100);
                    }
                }
            });

            // 音を流す
            Tools.PlaySound();

            label_process_fin_clip.Visible = true;
            progbar_clip.Style = ProgressBarStyle.Blocks;

            // enable all controls
            foreach (Control c in GetAllWebControl(tabctrl)) {
                if (c.Equals(btn_process)) {
                    btn_process.Text = "開始";
                    btn_process.Click += new System.EventHandler(btn_process_Click);
                    btn_process.Click -= new System.EventHandler(btn_abort_Click);
                }
                else {
                    c.Enabled = true;
                }
            }
            return true;
        }

        /* 結合 */
        private void listbox_concat_add_Click(object sender, EventArgs e) {
            string file_name = "";
            using (OpenFileDialog ofd = new OpenFileDialog()) {
                ofd.Filter = "動画ファイル(*.mp4)|*.mp4|すべてのファイル(*.*)|*.*";
                ofd.FilterIndex = 1;
                ofd.Title = "ファイルを選択";
                ofd.RestoreDirectory = true;
                if (ofd.ShowDialog() != DialogResult.OK) {
                    return;
                }
                file_name = ofd.FileName;
            }
            add_to_combine_listbox(file_name);
        }

        private void add_to_combine_listbox(string file_name) {
            // 各値をセット
            if (Properties.Settings.Default.concat_save_dir == "") {
                // 初回起動時
                tb_concat_savedir.Text = Path.GetDirectoryName(file_name);
            }

            // 動画の再生時間を取得
            int video_size_sec = 0;
            if (!Tools.getPositionValue(file_name, ref video_size_sec)) {
                Tools.ShowError("動画の再生時間取得に失敗しました。\n動画ファイル形式が正しくないか、壊れている可能性があります。");
                return;
            }

            // リストボックスに追加
            listbox_concat.Items.Add(file_name); Path.GetExtension(file_name);
            label_process_comb.Visible = false;
        }

        private void listbox_concat_del_Click(object sender, EventArgs e) {
            // リストボックスから削除
            listbox_concat.Items.Remove(listbox_concat.SelectedItem);

        }

        private void listbox_concat_up_Click(object sender, EventArgs e) {
            // リストボックスの順序変更（UP）
            var sel_index = listbox_concat.SelectedIndex;

            if (sel_index <= 0) return;

            var sel_item = listbox_concat.SelectedItem;
            listbox_concat.Items.Remove(sel_item);
            listbox_concat.Items.Insert(sel_index - 1, sel_item);
            listbox_concat.SelectedIndex = sel_index - 1;
        }

        private void listbox_concat_down_Click(object sender, EventArgs e) {
            // リストボックスの順序変更（Down）
            var sel_index = listbox_concat.SelectedIndex;

            if (sel_index >= listbox_concat.Items.Count - 1) return;

            var sel_item = listbox_concat.SelectedItem;
            listbox_concat.Items.Remove(sel_item);
            listbox_concat.Items.Insert(sel_index + 1, sel_item);
            listbox_concat.SelectedIndex = sel_index + 1;
        }

        private void btn_concat_ref_Click(object sender, EventArgs e) {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog()) {
                fbd.Description = "ディレクトリを選択";
                if (fbd.ShowDialog() != DialogResult.OK) {
                    return;
                }
                tb_concat_savedir.Text = fbd.SelectedPath;
            }
        }

        private void btn_concat_process_Click(object sender, EventArgs e) {
            progbar_comb.Visible = false;

            string ffmpeg = Path.Combine(
                System.IO.Directory.GetCurrentDirectory(),
                "bin",
                "ffmpeg.exe"
            );
            // ffmpeg check
            if (!File.Exists(ffmpeg)) { Tools.ShowError("bin/ffmpeg.exeが見つかりませんでした"); return; }

            // 動画のチェック
            foreach (string movie in listbox_concat.Items) {
                if (!File.Exists(movie)) { Tools.ShowError("変換前動画が見つかりません"); return; }
            }

            // 変換後動画
            if (!Directory.Exists(tb_concat_savedir.Text)) Tools.ShowError("保存先が見つかりません");
            string after_file = Path.Combine(tb_concat_savedir.Text, tb_concat_filename.Text);
            try {
                Path.Combine(after_file);
            }
            catch {
                Tools.ShowError("ファイル名に無効な文字が含まれています"); return;
            }

            if (File.Exists(after_file)) {
                if (
                    MessageBox.Show(
                        "保存先に同名ファイルが存在しています。\n上書きしてもよろしいですか？",
                        "注意",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Warning
                   ) == DialogResult.Cancel) {
                    return;
                }
            }

            // input.txt相当のファイルを作成
            var input_txt = Path.Combine(Path.GetTempPath(), Path.GetTempFileName());
            var items_str = "";
            foreach (var movie in listbox_concat.Items) {
                items_str += String.Format("file '{0}'\n", movie);
            }
            using (StreamWriter sw = new StreamWriter(input_txt, false, Encoding.ASCII)) {
                sw.Write(items_str);
            }
            
            // ffmpeg
            label_process_comb.Text = "処理中";
            ProcessCombineAsync(ffmpeg, input_txt, after_file);
            
        }

        public async void ProcessCombineAsync(string ffmpeg, string input_txt, string after_file) {
            // disable all control
            foreach(Control c in tabpg_combine.Controls){
                if (c.Equals(btn_concat_process)) {
                    btn_concat_process.Text = "中止";
                }
            }

            progbar_comb.Visible = true;
            progbar_comb.Style = ProgressBarStyle.Marquee;
            await Task.Run(() => {
                using (System.Diagnostics.Process p = new System.Diagnostics.Process()) {
                    p.StartInfo.FileName = ffmpeg;
                    p.StartInfo.Arguments = String.Format("-y -f concat -safe 0 -i {0} -c copy {1}", input_txt, after_file);
                    p.StartInfo.UseShellExecute = false;
                    p.StartInfo.CreateNoWindow = true;
                    p.StartInfo.WorkingDirectory = System.AppDomain.CurrentDomain.BaseDirectory;
                    p.Start();

                    p.WaitForExit();
                };
            });

            // 音を流す
            Tools.PlaySound();

            label_process_comb.Visible = true;
            progbar_comb.Style = ProgressBarStyle.Blocks;

            File.Delete(input_txt);

            // enable all control
            foreach (Control c in tabpg_combine.Controls) {
                if (c.Equals(btn_concat_process)) {
                    btn_concat_process.Text = "開始";
                }
            }
        }

        /* ドラッグドロップ処理 */
        private void tabpg_DragDrop(object sender, DragEventArgs e) {
            //コントロール内にドロップされたとき実行される
            this.BackColor = SystemColors.Control;

            //ドロップされたすべてのファイル名を取得する
            string[] fileName = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            // 正常にファイルがドロップされなかった場合
            if (fileName.Length <= 0) {
                return;
            }
            string file_name = fileName[0];

            // 動画の再生時間を取得
            int video_size_sec = 0;
            if (!Tools.getPositionValue(file_name, ref video_size_sec)) {
                Tools.ShowError("動画の再生時間取得に失敗しました。\n動画ファイル形式が正しくないか、壊れている可能性があります。");
                return;
            }

            if (((TabPage)sender).Name.Contains("split")) {
                set_videoname_split(file_name);
            }
            else if (((TabPage)sender).Name.Contains("combine")) {
                add_to_combine_listbox(file_name);
            }
        }

        private void tabpg_DragEnter(object sender, DragEventArgs e) {
            //コントロール内にドラッグされたとき実行される
            this.BackColor = Color.LightSteelBlue;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                //ドラッグされたデータ形式を調べ、ファイルのときはコピーとする
                e.Effect = DragDropEffects.Copy;
            else
                //ファイル以外は受け付けない
                e.Effect = DragDropEffects.None;
        }

        private void tabpg_DragLeave(object sender, EventArgs e) {
            this.BackColor = SystemColors.Control;
        }

        /* System */
        private void Main_Load(object sender, EventArgs e) {
            string ffmpeg = Path.Combine(
                System.IO.Directory.GetCurrentDirectory(),
                "bin",
                "ffmpeg.exe"
            );
            if (!File.Exists(ffmpeg)) { Tools.ShowError("bin/ffmpeg.exeが見つかりませんでした"); return; }

            if (Properties.Settings.Default.save_dir != "") {
                tb_after_dir.Text = Properties.Settings.Default.save_dir;
                tb_concat_savedir.Text = Properties.Settings.Default.concat_save_dir;
            }

            Assembly asm = Assembly.GetExecutingAssembly();
            AssemblyName asmName = asm.GetName();
            this.Text += " ver." + asmName.Version.ToString();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e) {
            Properties.Settings.Default.save_dir = tb_after_dir.Text;
            Properties.Settings.Default.concat_save_dir = tb_concat_savedir.Text;
            Properties.Settings.Default.Save();
        }
        
        public Shell32.Folder GetShell32NameSpaceFolder(Object folder) {
            Type shellAppType = Type.GetTypeFromProgID("Shell.Application");

            Object shell = Activator.CreateInstance(shellAppType);
            return (Shell32.Folder)shellAppType.InvokeMember(
                "NameSpace",
                System.Reflection.BindingFlags.InvokeMethod, null, shell, new object[] { folder }
            );
        }

        private void rb_custom_CheckedChanged(object sender, EventArgs e) {
            if (rb_custom.Checked) {
                tb_size_custom.Enabled = true;
            }
            else {
                tb_size_custom.Enabled = false;
            }
        }

    }
}
