using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyGDIFramework;

namespace 影流之钟
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //SoundPlayer audio = new SoundPlayer(Properties.Resources.audio);
        SoundPlayer audio0 = new SoundPlayer(Properties.Resources.audio0);
        SoundPlayer audio1 = new SoundPlayer(Properties.Resources.audio1);
        Image bgImage = Properties.Resources.bgclock;
        int fps = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            gdi.Graphics.Clear(Color.Transparent);
            Graphics g = gdi.Graphics;
            g.DrawImage(bgImage, 0, 0, 400, 400);

            g.TranslateTransform(200, 200);

            float secs = (float)DateTime.Now.TimeOfDay.TotalSeconds;
            //计算角度
            float hourAng = ((secs / 3600f) * 30f) % 360f;
            float minuteAng = ((secs / 60f) * 6f) % 360f;
            float secondAng = ((secs % 60f) * 6f) % 360f;
            //准备图像帧
            Image frame = Program.frames[this.fps];
            //绘制时针
            g.RotateTransform(hourAng);
            g.DrawImage(frame, -refHour.Width / 2, -refHour.Height, refHour.Width, refHour.Height);
            g.RotateTransform(-hourAng);
            //绘制分针
            g.RotateTransform(minuteAng);
            g.DrawImage(frame, -refMinute.Width / 2, -refMinute.Height, refMinute.Width, refMinute.Height);
            g.RotateTransform(-minuteAng);
            //绘制秒针
            g.RotateTransform(secondAng);
            g.DrawImage(frame, -refSecond.Width / 2, -refSecond.Height, refSecond.Width, refSecond.Height);
            g.RotateTransform(-secondAng);

            fps++;
            if (fps >= Program.frames.Count) { fps = 0; }
            //提交
            g.ResetTransform();
            gdi.UpdateWindow();
        }

        GdiSystem gdi;
        private void Form1_Load(object sender, EventArgs e)
        {
            gdi = new GdiSystem(this);
            backgroundWorker1.RunWorkerAsync();
        }


        bool clickDown = false;
        Point lastPoint = Point.Empty;
        private void refHour_MouseDown(object sender, MouseEventArgs e)
        {
            clickDown = true;
            lastPoint = e.Location;
        }

        private void refHour_MouseMove(object sender, MouseEventArgs e)
        {
            if (clickDown) {
                this.Top += e.Y - lastPoint.Y;
                this.Left += e.X - lastPoint.X;
            }
        }

        private void refHour_MouseUp(object sender, MouseEventArgs e)
        {
            clickDown = false;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            audio0.PlaySync();
            while (!backgroundWorker1.CancellationPending) {
                audio1.PlaySync();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }
    }
}
