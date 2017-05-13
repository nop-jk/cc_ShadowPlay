using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace cc_shadowplay {
    public partial class VideoPlayer : Form {
        public VideoPlayer() {
            InitializeComponent();
        }

        private int _start_time = 0;
        public int start_time { get { return _start_time; } }

        private int _end_time = 0;
        public int end_time { get { return _end_time; } }

        private String _video_file;
        public String video_file { set { _video_file = value; } }

        private int video_length_sec;

        private void VideoPlayer_Load(object sender, EventArgs e) {
            if (!File.Exists(_video_file)) { Tools.ShowError("動画が見つかりません"); this.Close(); return; }

            // 動画の長さを取得
            if (!Tools.getPositionValue(_video_file, ref video_length_sec)) {
                Tools.ShowError("動画の再生時間取得に失敗しました。\n動画ファイル形式が正しくないか、壊れている可能性があります。");
                this.Close();
                return;
            }

            wmp.stretchToFit = true;
            wmp.URL = _video_file;
            wmp.settings.autoStart = false;
            wmp.settings.volume = 0;
            wmp.Ctlcontrols.stop();

            _end_time = video_length_sec;
            label_end_time.Text = TimeSpan.FromSeconds(video_length_sec).ToString();
        }

        private void VideoPlayer_FormClosed(object sender, FormClosedEventArgs e) {
            wmp.Ctlcontrols.stop();
        }

        private void btn_ok_Click(object sender, EventArgs e) {
            if (_end_time <= _start_time) {
                label_warn.Visible = true;
            }
            else {
                this.Close();
            }
        }

        private void btn_start_set_Click(object sender, EventArgs e) {
            _start_time = (int)Math.Floor(wmp.Ctlcontrols.currentPosition);
            label_start_time.Text = TimeSpan.FromSeconds(_start_time).ToString();
        }

        private void btn_end_set_Click(object sender, EventArgs e) {
            _end_time = (int)Math.Floor(wmp.Ctlcontrols.currentPosition);
            label_end_time.Text = TimeSpan.FromSeconds(_end_time).ToString();
        }
    }
}
