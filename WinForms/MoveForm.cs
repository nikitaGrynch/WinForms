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
    public partial class MoveForm : Form
    {
        public MoveForm()
        {
            InitializeComponent();
        }

        private void MoveForm_KeyDown(object sender, KeyEventArgs e)
        {
            int newX, newY = 0;
            if(e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                if((this.Location.X - 50) >= 0)
                {
                    newX = this.Location.X - 50;
                    newY = this.Location.Y;
                    
                }
                else
                {
                    newX = 0;
                    newY = this.Location.Y;
                }
                this.Location = new Point(newX, newY);
            }
            else if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                if ((this.Location.Y - 50) >= 0)
                {
                    newX = this.Location.X;
                    newY = this.Location.Y - 50;
                }
                else
                {
                    newX = this.Location.X;
                    newY = 0;
                }
                this.Location = new Point(newX, newY);
            }
            else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                if ((this.Location.X + this.Size.Width + 50) <= Screen.PrimaryScreen.Bounds.Width)
                {
                    newX = this.Location.X + 50;
                    newY = this.Location.Y;
                    this.Location = new Point(newX, newY);
                }
                else
                {
                    newX = Screen.PrimaryScreen.Bounds.Width - this.Width;
                    newY = this.Location.Y;
                }
                this.Location = new Point(newX, newY);

            }
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                if ((this.Location.Y + this.Size.Height + 50) <= Screen.PrimaryScreen.Bounds.Height)
                {
                    newX = this.Location.X;
                    newY = this.Location.Y + 50;
                    this.Location = new Point(newX, newY);
                }
                else
                {
                    newX = this.Location.X;
                    newY = Screen.PrimaryScreen.Bounds.Height - this.Height;
                }
                this.Location = new Point(newX, newY);
            }

        }
    }
}
