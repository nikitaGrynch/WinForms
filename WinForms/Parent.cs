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
    public partial class Parent : Form
    {
        public Child child { get; set; }
        public String text { 
            get
            {
                return this.textBox.Text;
            }
            set
            {
                this.textBox.Text = value;
            }
        }
        public Parent()
        {
            InitializeComponent();

            this.child = new Child();
            this.child.parent = this;
            child.Show();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            child.text = textBox.Text;
        }
    }
}
