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
        public Pen Pen { get; set; }
        public double Radius { get; set; }
        public Color PenColor;
        public double AngleOffset { get; set; }
        public bool Rotating { get; set; }
        Graphics Drawer { get; set; }

        public Form1()
        {
            InitializeComponent();
            trackBarRadius.Maximum = pictureBox.Height / 2;
            Drawer = pictureBox.CreateGraphics();
            PenColor = Color.Black;
            Pen = new Pen(PenColor);
            Pen.Width = 3;
            Pen.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
            Radius = 100;
            numericUpDownNodesCount.Minimum = 3;
            Rotating = false;
        }


        public void Redraw(object sender, EventArgs e)
        {
            pictureBox.Refresh();

            Random rand = new Random();
            Nodes = (new Point[(int)numericUpDownNodesCount.Value]);
            double dAlpha = 2 * Math.PI / Nodes.Length;
            double Alpha = 0;
            Point center = new Point(pictureBox.Width / 2, pictureBox.Height / 2);
            Radius = trackBarRadius.Value;
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
                    AngleOffset += offset;
                else if(CKWButt.Checked)
                    AngleOffset -= offset;
                Redraw(null, null);
                await Task.Run(() =>
                {
                    Task.Delay(51 / (int)numericUpDownRotatePause.Value).Wait();
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
