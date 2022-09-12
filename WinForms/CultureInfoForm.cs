using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace WinForms
{
    public partial class CultureInfoForm : Form
    {
        public CultureInfoForm()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentTimeListBox.Items.Clear();
            DateTime time = DateTime.Now;
            // New Your
            var newYorkTime = TimeZoneInfo
                .ConvertTimeBySystemTimeZoneId(time, "Eastern Standard Time")
                .ToString(new CultureInfo("en-US")
               .DateTimeFormat);
            currentTimeListBox.Items.Add($"New York City - {newYorkTime}");

            // London
            var londonTime = TimeZoneInfo
                .ConvertTimeBySystemTimeZoneId(time, "GMT Standard Time")
                .ToString(new CultureInfo("en-GB")
                .DateTimeFormat);
            currentTimeListBox.Items.Add($"London - {londonTime}");

            // California
            var californiaTime = TimeZoneInfo
                .ConvertTimeBySystemTimeZoneId(time, "Pacific Standard Time")
                .ToString(new CultureInfo("en-US")
                .DateTimeFormat);
            currentTimeListBox.Items.Add($"California - {californiaTime}");

            // Tokyo
            var tokyoTime = TimeZoneInfo
                .ConvertTimeBySystemTimeZoneId(time, "Tokyo Standard Time")
                .ToString(new CultureInfo("ja-JP")
                .DateTimeFormat);
            currentTimeListBox.Items.Add($"Tokyo - {tokyoTime}");

            // Kyiv
            var kyivTime = TimeZoneInfo
                .ConvertTimeBySystemTimeZoneId(time, "FLE Standard Time")
                .ToString(new CultureInfo("uk-UA")
                .DateTimeFormat);
            currentTimeListBox.Items.Add($"Kyiv - {kyivTime}");

        }
    }
}
