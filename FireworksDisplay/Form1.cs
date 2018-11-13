using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace FireworksDisplay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Visible = false;

            Graphics g = this.CreateGraphics();
            SolidBrush drawBrush = new SolidBrush(Color.White);
            Pen drawPen = new Pen(Color.White, 10);


            int grow = 1;
            int x = this.Width / 2 - 5;
            int y = this.Height;
            int fwork = 10;

            while (y > this.Height/2 - 10)
            {
                g.Clear(Color.Black);
                g.FillRectangle(drawBrush, x, y, fwork, fwork);
                Thread.Sleep(10);

                y--;
            }
            while (grow < 499)
            {
                g.Clear(Color.Black);
                g.DrawEllipse(drawPen, x - grow / 2, y - grow / 2, fwork + grow, fwork + grow);
                Thread.Sleep(3);

                grow++;
            }
        }
    }
}
