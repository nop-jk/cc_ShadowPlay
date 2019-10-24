namespace cc_shadowplay {
    partial class Main {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.tb_before_path = new System.Windows.Forms.TextBox();
            this.tb_after_dir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_before_path = new System.Windows.Forms.Button();
            this.btn_save_dir = new System.Windows.Forms.Button();
            this.btn_process = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_end_time = new System.Windows.Forms.TextBox();
            this.tb_filename = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_start_time = new System.Windows.Forms.TextBox();
            this.label_process_fin_clip = new System.Windows.Forms.Label();
            this.btn_preview = new System.Windows.Forms.Button();
            this.tabctrl = new System.Windows.Forms.TabControl();
            this.tabpg_split = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.progbar_clip = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_size_custom = new cc_shadowplay.Main.TextBoxPlaceHolder();
            this.rb_custom = new System.Windows.Forms.RadioButton();
            this.rb_1280x720 = new System.Windows.Forms.RadioButton();
            this.rb_1920x1080 = new System.Windows.Forms.RadioButton();
            this.rb_original = new System.Windows.Forms.RadioButton();
            this.tabpg_combine = new System.Windows.Forms.TabPage();
            this.progbar_comb = new System.Windows.Forms.ProgressBar();
            this.label_process_comb = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listbox_concat_add = new System.Windows.Forms.Button();
            this.listbox_concat_down = new System.Windows.Forms.Button();
            this.listbox_concat_up = new System.Windows.Forms.Button();
            this.listbox_concat_del = new System.Windows.Forms.Button();
            this.listbox_concat = new System.Windows.Forms.ListBox();
            this.tb_concat_savedir = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_concat_filename = new System.Windows.Forms.TextBox();
            this.btn_concat_ref = new System.Windows.Forms.Button();
            this.btn_concat_process = new System.Windows.Forms.Button();
            this.tabctrl.SuspendLayout();
            this.tabpg_split.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabpg_combine.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_before_path
            // 
            this.tb_before_path.Location = new System.Drawing.Point(128, 17);
            this.tb_before_path.Name = "tb_before_path";
            this.tb_before_path.Size = new System.Drawing.Size(339, 19);
            this.tb_before_path.TabIndex = 0;
            // 
            // tb_after_dir
            // 
            this.tb_after_dir.Location = new System.Drawing.Point(128, 62);
            this.tb_after_dir.Name = "tb_after_dir";
            this.tb_after_dir.Size = new System.Drawing.Size(339, 19);
            this.tb_after_dir.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "変換前動画ファイル";
            // 
            // btn_before_path
            // 
            this.btn_before_path.Location = new System.Drawing.Point(488, 14);
            this.btn_before_path.Name = "btn_before_path";
            this.btn_before_path.Size = new System.Drawing.Size(75, 23);
            this.btn_before_path.TabIndex = 4;
            this.btn_before_path.Text = "参照";
            this.btn_before_path.UseVisualStyleBackColor = true;
            this.btn_before_path.Click += new System.EventHandler(this.btn_before_path_Click);
            // 
            // btn_save_dir
            // 
            this.btn_save_dir.Location = new System.Drawing.Point(488, 60);
            this.btn_save_dir.Name = "btn_save_dir";
            this.btn_save_dir.Size = new System.Drawing.Size(75, 23);
            this.btn_save_dir.TabIndex = 5;
            this.btn_save_dir.Text = "参照";
            this.btn_save_dir.UseVisualStyleBackColor = true;
            this.btn_save_dir.Click += new System.EventHandler(this.btn_save_dir_Click);
            // 
            // btn_process
            // 
            this.btn_process.Location = new System.Drawing.Point(409, 192);
            this.btn_process.Name = "btn_process";
            this.btn_process.Size = new System.Drawing.Size(154, 71);
            this.btn_process.TabIndex = 8;
            this.btn_process.Text = "開始";
            this.btn_process.UseVisualStyleBackColor = true;
            this.btn_process.Click += new System.EventHandler(this.btn_process_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "開始時間";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "終了時間";
            // 
            // tb_end_time
            // 
            this.tb_end_time.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tb_end_time.Location = new System.Drawing.Point(338, 147);
            this.tb_end_time.Name = "tb_end_time";
            this.tb_end_time.Size = new System.Drawing.Size(129, 22);
            this.tb_end_time.TabIndex = 9;
            this.tb_end_time.Text = "00:00:00";
            // 
            // tb_filename
            // 
            this.tb_filename.Location = new System.Drawing.Point(128, 104);
            this.tb_filename.Name = "tb_filename";
            this.tb_filename.Size = new System.Drawing.Size(339, 19);
            this.tb_filename.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "保存先";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "ファイル名";
            // 
            // tb_start_time
            // 
            this.tb_start_time.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tb_start_time.Location = new System.Drawing.Point(128, 147);
            this.tb_start_time.Name = "tb_start_time";
            this.tb_start_time.Size = new System.Drawing.Size(129, 22);
            this.tb_start_time.TabIndex = 13;
            this.tb_start_time.Text = "00:00:00";
            // 
            // label_process_fin_clip
            // 
            this.label_process_fin_clip.AutoSize = true;
            this.label_process_fin_clip.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_process_fin_clip.ForeColor = System.Drawing.Color.Blue;
            this.label_process_fin_clip.Location = new System.Drawing.Point(205, 248);
            this.label_process_fin_clip.Name = "label_process_fin_clip";
            this.label_process_fin_clip.Size = new System.Drawing.Size(67, 15);
            this.label_process_fin_clip.TabIndex = 16;
            this.label_process_fin_clip.Text = "処理完了";
            this.label_process_fin_clip.Visible = false;
            // 
            // btn_preview
            // 
            this.btn_preview.Location = new System.Drawing.Point(488, 146);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(75, 23);
            this.btn_preview.TabIndex = 17;
            this.btn_preview.Text = "プレビュー";
            this.btn_preview.UseVisualStyleBackColor = true;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // tabctrl
            // 
            this.tabctrl.Controls.Add(this.tabpg_split);
            this.tabctrl.Controls.Add(this.tabpg_combine);
            this.tabctrl.Location = new System.Drawing.Point(12, 12);
            this.tabctrl.Name = "tabctrl";
            this.tabctrl.SelectedIndex = 0;
            this.tabctrl.Size = new System.Drawing.Size(593, 304);
            this.tabctrl.TabIndex = 18;
            // 
            // tabpg_split
            // 
            this.tabpg_split.AllowDrop = true;
            this.tabpg_split.Controls.Add(this.label7);
            this.tabpg_split.Controls.Add(this.progbar_clip);
            this.tabpg_split.Controls.Add(this.label1);
            this.tabpg_split.Controls.Add(this.btn_preview);
            this.tabpg_split.Controls.Add(this.label_process_fin_clip);
            this.tabpg_split.Controls.Add(this.tb_before_path);
            this.tabpg_split.Controls.Add(this.tb_start_time);
            this.tabpg_split.Controls.Add(this.tb_after_dir);
            this.tabpg_split.Controls.Add(this.label5);
            this.tabpg_split.Controls.Add(this.label2);
            this.tabpg_split.Controls.Add(this.tb_filename);
            this.tabpg_split.Controls.Add(this.btn_before_path);
            this.tabpg_split.Controls.Add(this.label4);
            this.tabpg_split.Controls.Add(this.btn_save_dir);
            this.tabpg_split.Controls.Add(this.tb_end_time);
            this.tabpg_split.Controls.Add(this.label3);
            this.tabpg_split.Controls.Add(this.btn_process);
            this.tabpg_split.Controls.Add(this.panel1);
            this.tabpg_split.Location = new System.Drawing.Point(4, 22);
            this.tabpg_split.Name = "tabpg_split";
            this.tabpg_split.Padding = new System.Windows.Forms.Padding(3);
            this.tabpg_split.Size = new System.Drawing.Size(585, 278);
            this.tabpg_split.TabIndex = 0;
            this.tabpg_split.Text = "動画分割";
            this.tabpg_split.UseVisualStyleBackColor = true;
            this.tabpg_split.DragDrop += new System.Windows.Forms.DragEventHandler(this.tabpg_DragDrop);
            this.tabpg_split.DragEnter += new System.Windows.Forms.DragEventHandler(this.tabpg_DragEnter);
            this.tabpg_split.DragLeave += new System.EventHandler(this.tabpg_DragLeave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 22;
            this.label7.Text = "解像度";
            // 
            // progbar_clip
            // 
            this.progbar_clip.Location = new System.Drawing.Point(278, 248);
            this.progbar_clip.Name = "progbar_clip";
            this.progbar_clip.Size = new System.Drawing.Size(125, 15);
            this.progbar_clip.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progbar_clip.TabIndex = 18;
            this.progbar_clip.Value = 100;
            this.progbar_clip.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.tb_size_custom);
            this.panel1.Controls.Add(this.rb_custom);
            this.panel1.Controls.Add(this.rb_1280x720);
            this.panel1.Controls.Add(this.rb_1920x1080);
            this.panel1.Controls.Add(this.rb_original);
            this.panel1.Location = new System.Drawing.Point(128, 192);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 50);
            this.panel1.TabIndex = 21;
            // 
            // tb_size_custom
            // 
            this.tb_size_custom.Enabled = false;
            this.tb_size_custom.Location = new System.Drawing.Point(189, 26);
            this.tb_size_custom.Name = "tb_size_custom";
            this.tb_size_custom.Placeholder = "1920x1080";
            this.tb_size_custom.Size = new System.Drawing.Size(74, 19);
            this.tb_size_custom.TabIndex = 4;
            // 
            // rb_custom
            // 
            this.rb_custom.AutoSize = true;
            this.rb_custom.Location = new System.Drawing.Point(169, 29);
            this.rb_custom.Name = "rb_custom";
            this.rb_custom.Size = new System.Drawing.Size(14, 13);
            this.rb_custom.TabIndex = 3;
            this.rb_custom.UseVisualStyleBackColor = true;
            this.rb_custom.CheckedChanged += new System.EventHandler(this.rb_custom_CheckedChanged);
            // 
            // rb_1280x720
            // 
            this.rb_1280x720.AutoSize = true;
            this.rb_1280x720.Location = new System.Drawing.Point(92, 27);
            this.rb_1280x720.Name = "rb_1280x720";
            this.rb_1280x720.Size = new System.Drawing.Size(71, 16);
            this.rb_1280x720.TabIndex = 2;
            this.rb_1280x720.Text = "1280x720";
            this.rb_1280x720.UseVisualStyleBackColor = true;
            // 
            // rb_1920x1080
            // 
            this.rb_1920x1080.AutoSize = true;
            this.rb_1920x1080.Location = new System.Drawing.Point(9, 27);
            this.rb_1920x1080.Name = "rb_1920x1080";
            this.rb_1920x1080.Size = new System.Drawing.Size(77, 16);
            this.rb_1920x1080.TabIndex = 1;
            this.rb_1920x1080.Text = "1920x1080";
            this.rb_1920x1080.UseVisualStyleBackColor = true;
            // 
            // rb_original
            // 
            this.rb_original.AutoSize = true;
            this.rb_original.Checked = true;
            this.rb_original.Location = new System.Drawing.Point(9, 5);
            this.rb_original.Name = "rb_original";
            this.rb_original.Size = new System.Drawing.Size(138, 16);
            this.rb_original.TabIndex = 0;
            this.rb_original.TabStop = true;
            this.rb_original.Text = "Original（エンコードなし）";
            this.rb_original.UseVisualStyleBackColor = true;
            // 
            // tabpg_combine
            // 
            this.tabpg_combine.AllowDrop = true;
            this.tabpg_combine.Controls.Add(this.progbar_comb);
            this.tabpg_combine.Controls.Add(this.label_process_comb);
            this.tabpg_combine.Controls.Add(this.label6);
            this.tabpg_combine.Controls.Add(this.listbox_concat_add);
            this.tabpg_combine.Controls.Add(this.listbox_concat_down);
            this.tabpg_combine.Controls.Add(this.listbox_concat_up);
            this.tabpg_combine.Controls.Add(this.listbox_concat_del);
            this.tabpg_combine.Controls.Add(this.listbox_concat);
            this.tabpg_combine.Controls.Add(this.tb_concat_savedir);
            this.tabpg_combine.Controls.Add(this.label8);
            this.tabpg_combine.Controls.Add(this.label9);
            this.tabpg_combine.Controls.Add(this.tb_concat_filename);
            this.tabpg_combine.Controls.Add(this.btn_concat_ref);
            this.tabpg_combine.Controls.Add(this.btn_concat_process);
            this.tabpg_combine.Location = new System.Drawing.Point(4, 22);
            this.tabpg_combine.Name = "tabpg_combine";
            this.tabpg_combine.Padding = new System.Windows.Forms.Padding(3);
            this.tabpg_combine.Size = new System.Drawing.Size(585, 278);
            this.tabpg_combine.TabIndex = 1;
            this.tabpg_combine.Text = "動画結合";
            this.tabpg_combine.UseVisualStyleBackColor = true;
            this.tabpg_combine.DragDrop += new System.Windows.Forms.DragEventHandler(this.tabpg_DragDrop);
            this.tabpg_combine.DragEnter += new System.Windows.Forms.DragEventHandler(this.tabpg_DragEnter);
            this.tabpg_combine.DragLeave += new System.EventHandler(this.tabpg_DragLeave);
            // 
            // progbar_comb
            // 
            this.progbar_comb.Location = new System.Drawing.Point(278, 248);
            this.progbar_comb.Name = "progbar_comb";
            this.progbar_comb.Size = new System.Drawing.Size(125, 15);
            this.progbar_comb.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progbar_comb.TabIndex = 42;
            this.progbar_comb.Value = 100;
            this.progbar_comb.Visible = false;
            // 
            // label_process_comb
            // 
            this.label_process_comb.AutoSize = true;
            this.label_process_comb.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_process_comb.ForeColor = System.Drawing.Color.Blue;
            this.label_process_comb.Location = new System.Drawing.Point(205, 248);
            this.label_process_comb.Name = "label_process_comb";
            this.label_process_comb.Size = new System.Drawing.Size(67, 15);
            this.label_process_comb.TabIndex = 41;
            this.label_process_comb.Text = "処理完了";
            this.label_process_comb.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 12);
            this.label6.TabIndex = 40;
            this.label6.Text = "※上から順に結合";
            // 
            // listbox_concat_add
            // 
            this.listbox_concat_add.Location = new System.Drawing.Point(488, 14);
            this.listbox_concat_add.Name = "listbox_concat_add";
            this.listbox_concat_add.Size = new System.Drawing.Size(75, 23);
            this.listbox_concat_add.TabIndex = 39;
            this.listbox_concat_add.Text = "追加";
            this.listbox_concat_add.UseVisualStyleBackColor = true;
            this.listbox_concat_add.Click += new System.EventHandler(this.listbox_concat_add_Click);
            // 
            // listbox_concat_down
            // 
            this.listbox_concat_down.Location = new System.Drawing.Point(532, 79);
            this.listbox_concat_down.Name = "listbox_concat_down";
            this.listbox_concat_down.Size = new System.Drawing.Size(31, 23);
            this.listbox_concat_down.TabIndex = 38;
            this.listbox_concat_down.Text = "↓";
            this.listbox_concat_down.UseVisualStyleBackColor = true;
            this.listbox_concat_down.Click += new System.EventHandler(this.listbox_concat_down_Click);
            // 
            // listbox_concat_up
            // 
            this.listbox_concat_up.Location = new System.Drawing.Point(488, 79);
            this.listbox_concat_up.Name = "listbox_concat_up";
            this.listbox_concat_up.Size = new System.Drawing.Size(31, 23);
            this.listbox_concat_up.TabIndex = 37;
            this.listbox_concat_up.Text = "↑";
            this.listbox_concat_up.UseVisualStyleBackColor = true;
            this.listbox_concat_up.Click += new System.EventHandler(this.listbox_concat_up_Click);
            // 
            // listbox_concat_del
            // 
            this.listbox_concat_del.Location = new System.Drawing.Point(488, 43);
            this.listbox_concat_del.Name = "listbox_concat_del";
            this.listbox_concat_del.Size = new System.Drawing.Size(75, 23);
            this.listbox_concat_del.TabIndex = 36;
            this.listbox_concat_del.Text = "削除";
            this.listbox_concat_del.UseVisualStyleBackColor = true;
            this.listbox_concat_del.Click += new System.EventHandler(this.listbox_concat_del_Click);
            // 
            // listbox_concat
            // 
            this.listbox_concat.FormattingEnabled = true;
            this.listbox_concat.ItemHeight = 12;
            this.listbox_concat.Location = new System.Drawing.Point(21, 14);
            this.listbox_concat.Name = "listbox_concat";
            this.listbox_concat.Size = new System.Drawing.Size(461, 88);
            this.listbox_concat.TabIndex = 33;
            // 
            // tb_concat_savedir
            // 
            this.tb_concat_savedir.Location = new System.Drawing.Point(180, 120);
            this.tb_concat_savedir.Name = "tb_concat_savedir";
            this.tb_concat_savedir.Size = new System.Drawing.Size(302, 19);
            this.tb_concat_savedir.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(123, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 12);
            this.label8.TabIndex = 29;
            this.label8.Text = "ファイル名";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(134, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 21;
            this.label9.Text = "保存先";
            // 
            // tb_concat_filename
            // 
            this.tb_concat_filename.Location = new System.Drawing.Point(180, 152);
            this.tb_concat_filename.Name = "tb_concat_filename";
            this.tb_concat_filename.Size = new System.Drawing.Size(302, 19);
            this.tb_concat_filename.TabIndex = 28;
            this.tb_concat_filename.Text = "output.mp4";
            // 
            // btn_concat_ref
            // 
            this.btn_concat_ref.Location = new System.Drawing.Point(488, 118);
            this.btn_concat_ref.Name = "btn_concat_ref";
            this.btn_concat_ref.Size = new System.Drawing.Size(75, 23);
            this.btn_concat_ref.TabIndex = 23;
            this.btn_concat_ref.Text = "参照";
            this.btn_concat_ref.UseVisualStyleBackColor = true;
            this.btn_concat_ref.Click += new System.EventHandler(this.btn_concat_ref_Click);
            // 
            // btn_concat_process
            // 
            this.btn_concat_process.Location = new System.Drawing.Point(409, 192);
            this.btn_concat_process.Name = "btn_concat_process";
            this.btn_concat_process.Size = new System.Drawing.Size(154, 71);
            this.btn_concat_process.TabIndex = 25;
            this.btn_concat_process.Text = "開始";
            this.btn_concat_process.UseVisualStyleBackColor = true;
            this.btn_concat_process.Click += new System.EventHandler(this.btn_concat_process_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(617, 328);
            this.Controls.Add(this.tabctrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.Text = "cc_ShadowPlay";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabctrl.ResumeLayout(false);
            this.tabpg_split.ResumeLayout(false);
            this.tabpg_split.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabpg_combine.ResumeLayout(false);
            this.tabpg_combine.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_before_path;
        private System.Windows.Forms.TextBox tb_after_dir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_before_path;
        private System.Windows.Forms.Button btn_save_dir;
        private System.Windows.Forms.Button btn_process;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_end_time;
        private System.Windows.Forms.TextBox tb_filename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_start_time;
        private System.Windows.Forms.Label label_process_fin_clip;
        private System.Windows.Forms.Button btn_preview;
        private System.Windows.Forms.TabControl tabctrl;
        private System.Windows.Forms.TabPage tabpg_split;
        private System.Windows.Forms.TabPage tabpg_combine;
        private System.Windows.Forms.TextBox tb_concat_savedir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_concat_ref;
        private System.Windows.Forms.Button btn_concat_process;
        private System.Windows.Forms.TextBox tb_concat_filename;
        private System.Windows.Forms.Button listbox_concat_down;
        private System.Windows.Forms.Button listbox_concat_up;
        private System.Windows.Forms.Button listbox_concat_del;
        private System.Windows.Forms.ListBox listbox_concat;
        private System.Windows.Forms.Button listbox_concat_add;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar progbar_clip;
        private System.Windows.Forms.ProgressBar progbar_comb;
        private System.Windows.Forms.Label label_process_comb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rb_1920x1080;
        private System.Windows.Forms.RadioButton rb_original;
        private System.Windows.Forms.RadioButton rb_custom;
        private System.Windows.Forms.RadioButton rb_1280x720;
        private TextBoxPlaceHolder tb_size_custom;
    }
}

