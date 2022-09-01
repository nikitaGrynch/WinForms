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
        private bool isPressed = false;
        private Button newButton;
        private Point prevPos;

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
            
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            counter++;
            isPressed = true;
            newButton = new Button();
            var currentMousePos = this.PointToClient(Cursor.Position);
            prevPos = currentMousePos;
            newButton.Location = new Point(currentMousePos.X, currentMousePos.Y);
            newButton.Size = new Size(0, 0);
            newButton.Text = counter.ToString();
            this.Controls.Add(newButton);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isPressed = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isPressed)
            {
                var currentMousePos = this.PointToClient(Cursor.Position);
                int newSizeX = 0;
                int newSizeY = 0;
                int newLocationX = 0;
                int newLocationY = 0;

                bool isChangeLocation = false;
                if(currentMousePos.X - prevPos.X > 0 && currentMousePos.Y - prevPos.Y > 0)
                {
                    newSizeX = currentMousePos.X - prevPos.X;
                    newSizeY = currentMousePos.Y - prevPos.Y;
                }
                else if(currentMousePos.X - prevPos.X < 0 && currentMousePos.Y - prevPos.Y > 0)
                {
                    newLocationX = currentMousePos.X;
                    newLocationY = prevPos.Y;
                    newSizeX = prevPos.X - currentMousePos.X;
                    newSizeY = currentMousePos.Y - prevPos.Y;
                    isChangeLocation = true;
                }
                else if (currentMousePos.X - prevPos.X > 0 && currentMousePos.Y - prevPos.Y < 0)
                {
                    newLocationX = prevPos.X;
                    newLocationY = currentMousePos.Y;
                    newSizeX = currentMousePos.X - prevPos.X;
                    newSizeY = prevPos.Y - currentMousePos.Y;
                    isChangeLocation = true;
                }
                else if(currentMousePos.X - prevPos.X < 0 && currentMousePos.Y - prevPos.Y < 0)
                {
                    newLocationX = currentMousePos.X;
                    newLocationY = currentMousePos.Y;
                    newSizeX = prevPos.X - currentMousePos.X;
                    newSizeY = prevPos.Y - currentMousePos.Y;
                    isChangeLocation = true;

                }
                if (isChangeLocation)
                    newButton.Location = new Point(newLocationX, newLocationY);

                Size newSize = new Size(newSizeX, newSizeY);
                newButton.Size = newSize;
            }
        }
    }
}
