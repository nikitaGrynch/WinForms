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
        private int counter;
        public Form1()
        {
            counter = 0;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            counter++;
            button1.Text = counter.ToString();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Random rnd = new Random();
            //button1.BackColor = Color.Red;
            int newX = rnd.Next(this.Size.Width - button1.Size.Width);
            int newY = rnd.Next(this.Size.Height - button1.Size.Height);
            button1.Location = new Point(newX, newY);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            // button1.BackColor = Color.Blue;
        }
    }
}
