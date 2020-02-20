using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polygons
{
    public partial class Form1 : Form
    {
        public Point[] Nodes { get; set; }
        public double Radius { get; set; }
        public double AngleOffset { get; set; }
        public bool Rotating { get; set; }
        public Color PenColor { get; set; }
        public Pen Pen { get; }
        Graphics Drawer { get; }

        public Form1()
        {
            InitializeComponent();
            Pen = new Pen(PenColor);
            Pen.Width = 3;
            Pen.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
            NodesCountBox.Minimum = 3;
            RadiusBar.Maximum = pictureBox.Height / 2;
            Drawer = pictureBox.CreateGraphics();
            PenColor = Color.Black;
            Rotating = false;
            Radius = 100;
            AngleOffset = 0;
        }


        public void Redraw(object sender, EventArgs e)
        {
            pictureBox.Refresh();

            Random rand = new Random();
            Nodes = (new Point[(int)NodesCountBox.Value]);
            double dAlpha = 2 * Math.PI / Nodes.Length;
            double Alpha = 0;
            Point center = new Point(pictureBox.Width / 2, pictureBox.Height / 2);
            Radius = RadiusBar.Value;
            Pen.Width = ThicknessBar.Value;
            if (ColorMono.Checked)
                Pen.Color = PenColor;

            for (int i = 0; i < Nodes.Length; i++)
            {
                Nodes[i] = new Point();
            }
            if (Rotating)
            {
                Alpha += AngleOffset;
            }

            for (int i = 0; i < Nodes.Length; i++)
            {
                Nodes[i] = new Point((int)(center.X + Radius * Math.Cos(Alpha)), (int)(center.Y - Radius * Math.Sin(Alpha)));
                Alpha += dAlpha;
            }

            for (int i = 0; i < Nodes.Length - 1; i++)
            {
                if (ColorRandom.Checked)
                    Pen.Color = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));

                Drawer.DrawLine(Pen, Nodes[i], Nodes[i + 1]);
            }

            Drawer.DrawLine(Pen, Nodes[0], Nodes[Nodes.Length - 1]);

            if (checkBoxCTN.Checked)
            {
                foreach (Point point1 in Nodes)
                {
                    foreach (Point point2 in Nodes)
                    {
                        if (ColorRandom.Checked)
                            Pen.Color = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
                        Drawer.DrawLine(Pen, point1, point2);
                    }
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            pictureBox.Refresh();
        }

        private void ChooseColorButt_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            PenColor = colorDialog1.Color;
            ChooseColorButt.Text = string.Empty;
            ChooseColorButt.BackColor = PenColor;
            Redraw(null, null);
        }

        private async void Rotate()
        {
            double offset = 2 * Math.PI / 60;
            Rotating = true;
            while (checkBoxRotate.Checked)
            {
                if (CoCKWButt.Checked)
                {
                    AngleOffset += offset;
                    if (offset > 2 * Math.PI)
                        offset %= 2 * Math.PI;
                }
                else if (CKWButt.Checked)
                {
                    AngleOffset -= offset;
                    if (offset < 2 * Math.PI)
                        offset %= 2 * Math.PI;
                }
                Redraw(null, null);
                await Task.Run(() =>
                {
                    Task.Delay(51 / (int)RotationSpeedBox.Value).Wait();
                });
            }
            Rotating = false;
            AngleOffset = 0;
        }

        private void checkBoxRotate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRotate.Checked)
            {
                Rotate();
            }
        }


    }
}
