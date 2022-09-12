using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Threading;

namespace WinForms
{
    public partial class ScreenshotMaker : Form
    {
        private static Bitmap bmpScreenshot;
        private static Graphics gfxScreenshot;
        public ScreenshotMaker()
        {
            InitializeComponent();
            timer1.Interval = 5000;
            timer1.Start();
        }

        private void MakeScreen()
        {
            // Hide the form so that it does not appear in the screenshot
            this.Hide();
            Thread.Sleep(400);
            // Set the bitmap object to the size of the screen
            bmpScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb);
            // Create a graphics object from the bitmap
            gfxScreenshot = Graphics.FromImage(bmpScreenshot);
            // Take the screenshot from the upper left corner to the right bottom corner
            gfxScreenshot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);
            // Save the screenshot to the specified path that the user has chosen
            var time = DateTime.Now;
            String name = time.Year + "." + time.Month + "." + time.Day + "-" + time.Hour + "." + time.Minute + "." + time.Second + ".png";
            bmpScreenshot.Save(name, ImageFormat.Png);
            // Show the form again
            this.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MakeScreen();
        }
    }
}
