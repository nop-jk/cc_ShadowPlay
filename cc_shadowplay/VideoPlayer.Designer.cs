namespace cc_shadowplay {
    partial class VideoPlayer {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoPlayer));
            this.btn_ok = new System.Windows.Forms.Button();
            this.label_start_time = new System.Windows.Forms.Label();
            this.label_end_time = new System.Windows.Forms.Label();
            this.btn_start_set = new System.Windows.Forms.Button();
            this.btn_end_start = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.wmp = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.Location = new System.Drawing.Point(528, 50);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 11;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // label_start_time
            // 
            this.label_start_time.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_start_time.AutoSize = true;
            this.label_start_time.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_start_time.Location = new System.Drawing.Point(222, 13);
            this.label_start_time.Name = "label_start_time";
            this.label_start_time.Size = new System.Drawing.Size(71, 15);
            this.label_start_time.TabIndex = 4;
            this.label_start_time.Text = "00:00:00";
            // 
            // label_end_time
            // 
            this.label_end_time.AutoSize = true;
            this.label_end_time.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_end_time.Location = new System.Drawing.Point(222, 52);
            this.label_end_time.Name = "label_end_time";
            this.label_end_time.Size = new System.Drawing.Size(71, 15);
            this.label_end_time.TabIndex = 4;
            this.label_end_time.Text = "00:00:00";
            // 
            // btn_start_set
            // 
            this.btn_start_set.Location = new System.Drawing.Point(8, 11);
            this.btn_start_set.Name = "btn_start_set";
            this.btn_start_set.Size = new System.Drawing.Size(193, 23);
            this.btn_start_set.TabIndex = 16;
            this.btn_start_set.Text = "現在の再生位置を始点にする";
            this.btn_start_set.UseVisualStyleBackColor = true;
            this.btn_start_set.Click += new System.EventHandler(this.btn_start_set_Click);
            // 
            // btn_end_start
            // 
            this.btn_end_start.Location = new System.Drawing.Point(8, 50);
            this.btn_end_start.Name = "btn_end_start";
            this.btn_end_start.Size = new System.Drawing.Size(193, 23);
            this.btn_end_start.TabIndex = 17;
            this.btn_end_start.Text = "現在の再生位置を終点にする";
            this.btn_end_start.UseVisualStyleBackColor = true;
            this.btn_end_start.Click += new System.EventHandler(this.btn_end_set_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btn_ok);
            this.panel1.Controls.Add(this.btn_start_set);
            this.panel1.Controls.Add(this.label_end_time);
            this.panel1.Controls.Add(this.btn_end_start);
            this.panel1.Controls.Add(this.label_start_time);
            this.panel1.Location = new System.Drawing.Point(12, 357);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(616, 85);
            this.panel1.TabIndex = 18;
            // 
            // wmp
            // 
            this.wmp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wmp.Enabled = true;
            this.wmp.Location = new System.Drawing.Point(0, 0);
            this.wmp.Name = "wmp";
            this.wmp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp.OcxState")));
            this.wmp.Size = new System.Drawing.Size(640, 351);
            this.wmp.TabIndex = 0;
            // 
            // VideoPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 455);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.wmp);
            this.MinimumSize = new System.Drawing.Size(656, 494);
            this.Name = "VideoPlayer";
            this.Text = "VideoPlayer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VideoPlayer_FormClosed);
            this.Load += new System.EventHandler(this.VideoPlayer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmp;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label label_start_time;
        private System.Windows.Forms.Label label_end_time;
        private System.Windows.Forms.Button btn_start_set;
        private System.Windows.Forms.Button btn_end_start;
        private System.Windows.Forms.Panel panel1;


    }
}