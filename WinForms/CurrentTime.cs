using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class CurrentTime : Form
    {
        DateTime startTime;
        public CurrentTime()
        {
            InitializeComponent();
            startTime = DateTime.Now;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = (DateTime.Now - startTime).ToString();
        }
    }
}
