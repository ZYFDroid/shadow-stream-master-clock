namespace 影流之钟
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.refSecond = new System.Windows.Forms.PictureBox();
            this.refMinute = new System.Windows.Forms.PictureBox();
            this.refHour = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.refSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refHour)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 39;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // refSecond
            // 
            this.refSecond.Image = global::影流之钟.Properties.Resources.frame317;
            this.refSecond.Location = new System.Drawing.Point(172, 12);
            this.refSecond.Name = "refSecond";
            this.refSecond.Size = new System.Drawing.Size(57, 185);
            this.refSecond.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.refSecond.TabIndex = 0;
            this.refSecond.TabStop = false;
            this.refSecond.MouseDown += new System.Windows.Forms.MouseEventHandler(this.refHour_MouseDown);
            this.refSecond.MouseMove += new System.Windows.Forms.MouseEventHandler(this.refHour_MouseMove);
            this.refSecond.MouseUp += new System.Windows.Forms.MouseEventHandler(this.refHour_MouseUp);
            // 
            // refMinute
            // 
            this.refMinute.Image = global::影流之钟.Properties.Resources.frame317;
            this.refMinute.Location = new System.Drawing.Point(136, 12);
            this.refMinute.Name = "refMinute";
            this.refMinute.Size = new System.Drawing.Size(130, 185);
            this.refMinute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.refMinute.TabIndex = 0;
            this.refMinute.TabStop = false;
            this.refMinute.MouseDown += new System.Windows.Forms.MouseEventHandler(this.refHour_MouseDown);
            this.refMinute.MouseMove += new System.Windows.Forms.MouseEventHandler(this.refHour_MouseMove);
            this.refMinute.MouseUp += new System.Windows.Forms.MouseEventHandler(this.refHour_MouseUp);
            // 
            // refHour
            // 
            this.refHour.Image = global::影流之钟.Properties.Resources.frame317;
            this.refHour.Location = new System.Drawing.Point(136, 73);
            this.refHour.Name = "refHour";
            this.refHour.Size = new System.Drawing.Size(130, 124);
            this.refHour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.refHour.TabIndex = 0;
            this.refHour.TabStop = false;
            this.refHour.MouseDown += new System.Windows.Forms.MouseEventHandler(this.refHour_MouseDown);
            this.refHour.MouseMove += new System.Windows.Forms.MouseEventHandler(this.refHour_MouseMove);
            this.refHour.MouseUp += new System.Windows.Forms.MouseEventHandler(this.refHour_MouseUp);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::影流之钟.Properties.Resources.bgclock;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.refHour);
            this.Controls.Add(this.refMinute);
            this.Controls.Add(this.refSecond);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(200, 200);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "影流之钟";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.refHour_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.refHour_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.refHour_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.refSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refHour)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox refSecond;
        private System.Windows.Forms.PictureBox refMinute;
        private System.Windows.Forms.PictureBox refHour;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

