using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class ChangeWallpaper : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

        private String[] pics;
        private int wallpaperNum;

        public ChangeWallpaper()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Start();
            pics = Directory.GetFiles("C:\\DeskPics");
            wallpaperNum = 0;
        }

        private void SetWallpaper()
        {
            // select wallpaper
            String WallpaperLocation = pics[wallpaperNum];

            // Sets the actual wallpaper
            SystemParametersInfo(20, 0, WallpaperLocation, 0x01 | 0x02);
            // Set the wallpaper style to streched (can be changed to tile, center, maintain aspect ratio, etc.
            RegistryKey rkWallPaper = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true);
            // Sets the wallpaper style
            rkWallPaper.SetValue("WallpaperStyle", 2);
            // Whether or not this wallpaper will be displayed as a tile
            rkWallPaper.SetValue("TileWallpaper", 0);
            

            wallpaperNum = wallpaperNum + 1 >= pics.Length ? 0 : ++wallpaperNum;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SetWallpaper();
        }
    }
}
