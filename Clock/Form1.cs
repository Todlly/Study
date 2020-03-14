using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class Form1 : Form
    {
        private Pen dialPen = new Pen(Color.White);
        private float arrowAng;
        private int diameter;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Load("back.jpg");
            timer1.Interval = (1000 * 60 / 360);
            timer1.Start();
            diameter = pictureBox1.Height - 20;
        }

        private void DrawDial(Graphics drawer, int radius)
        {
            dialPen.Width = 10;
            dialPen.Color = Color.White;
            drawer.DrawEllipse(dialPen, dialPen.Width, dialPen.Width, radius, radius);


            dialPen.Color = Color.Aqua;
            dialPen.Width = 5;
            drawer.TranslateTransform(pictureBox1.Width / 2, pictureBox1.Height / 2);

            drawer.RotateTransform(210);

            for (int i = 1; i <= 12; i++)
            {
                drawer.DrawLine(dialPen, new Point(0, radius / 2 - 15), new Point(0, radius / 2 - 5));
                drawer.DrawString(i.ToString(), SystemFonts.DefaultFont, dialPen.Brush, new Point(-5, radius / 2 - 30), new StringFormat(StringFormatFlags.DisplayFormatControl));
                drawer.RotateTransform(30);
            }
            drawer.RotateTransform(-30);
            drawer.RotateTransform(arrowAng);
            drawer.DrawLine(dialPen, 0, 0, 0, radius / 2 - 30);
        }
        

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics drawer = e.Graphics;
            
            DrawDial(drawer, diameter);
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            arrowAng += 0.5f;
            pictureBox1.Invalidate();
        }
    }
}
