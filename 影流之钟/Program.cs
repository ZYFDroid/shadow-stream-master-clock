using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 影流之钟
{
    static class Program
    {
        public static List<Image> frames = new List<Image>();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            for (int i = 1; i <= 319; i++) {
                using (Stream s = Assembly.GetExecutingAssembly().GetManifestResourceStream("影流之钟.frames.frame" + i.ToString("000") + ".png")){
                    frames.Add(Image.FromStream(s));
                }
            }

            Application.Run(new Form1());
        }
    }
}
