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
    public partial class Form1 : Form
    {
        private static int count;
        public Form1()
        {
            count = 0;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            button1.Text = count.ToString();
        }
    }
}
