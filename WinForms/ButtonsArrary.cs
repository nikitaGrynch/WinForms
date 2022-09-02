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

    public partial class ButtonsArrary : Form
    {
        private const int M = 5;
        private const int N = 5;
        private const int X = 40;     // width and height of button
        private const int Y = 4;      // spacing between buttons
        private const int startPosX = 10;
        private const int startPosY = 10;
        public ButtonsArrary()
        {
            InitializeComponent();
            int buttonNumber = 1;
            int buttonPosX = startPosX, buttonPosY = startPosY;
            Random rnd = new Random();
            for(int i = 1; i <= M; i++)
            {
                for (int j = 1; j <= N; j++)
                {
                    Button button = new Button();
                    button.Location = new Point(buttonPosX, buttonPosY);
                    button.Size = new Size(X, X);

                    Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                    button.BackColor = randomColor;

                    button.Text = buttonNumber.ToString();

                    button.MouseDown += Button_MouseDown;

                    button.Parent = this;
                    
                    
                    buttonPosX += X + Y;
                    buttonNumber++;
                }
                buttonPosX = startPosX;
                buttonPosY = startPosY + ((X + Y) * i);
            }
        }

        private void Button_MouseDown(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            if (button == null) return;
            button.Dispose();
        }
    }
}
