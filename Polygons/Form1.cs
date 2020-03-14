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
        public string WheelMode { get; set; }

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
            Radius = 1;
            Drawer.TranslateTransform(pictureBox.Width / 2, pictureBox.Height / 2);
            MouseWheel += Scroll;
            pictureBox.MouseDown += ChangeWheelMode;
            WheelMode = "Rotate";
            RecalculateNodes();
        }


        private void ChangeWheelMode(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                if (WheelMode == "Rotate")
                {
                    WheelMode = "Size";
                }
                else if (WheelMode == "Size")
                {
                    WheelMode = "Rotate";
                }
            }
        }

        private void Scroll(object sender, MouseEventArgs e)
        {
            if (WheelMode == "Rotate")
            {
                if (e.Delta < 0)
                    TrueRotate(true);
                else
                    TrueRotate(false);
            }
            else if (WheelMode == "Size")
            {
                if (e.Delta > 0)
                    Drawer.ScaleTransform(1.1f, 1.1f);
                else
                    Drawer.ScaleTransform(0.9f, 0.9f);
                Redraw(null, null);
            }
        }

        private void HUI() => Text = "hui";

        private void RecalculateNodes()
        {
            Nodes = (new Point[(int)NodesCountBox.Value]);

            double dAlpha = 2 * Math.PI / Nodes.Length;
            double Alpha = 0;
            Radius = RadiusBar.Value;
            
            for (int i = 0; i < Nodes.Length; i++)
            {
                Nodes[i] = new Point();
            }

            for (int i = 0; i < Nodes.Length; i++)
            {
                Nodes[i] = new Point((int)(Radius * Math.Cos(Alpha)), (int)(Radius * Math.Sin(Alpha)));
                Alpha += dAlpha;
            }
        }

        public void Redraw(object sender, EventArgs e)
        {
            pictureBox.Refresh();
            Random rand = new Random();
            Pen.Width = ThicknessBar.Value;

            if (ColorMono.Checked)
                Pen.Color = PenColor;
            
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

        private void TrueRotate(bool CKW)
        {
            if (CKW)
                Drawer.RotateTransform(3);
            else
                Drawer.RotateTransform(-3);
            Redraw(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TrueRotate(CKWButt.Checked);
            Redraw(null, null);
        }

        private async void checkBoxRotate_CheckedChanged(object sender, EventArgs e)
        {
            while (checkBoxRotate.Checked)
            {
                TrueRotate(CKWButt.Checked);

                await Task.Delay((int)(510 / (double)RotationSpeedBox.Value));
            }
        }
        
        private void UpdatePolygon(object sender, EventArgs e)
        {
            RecalculateNodes();
            Redraw(null, null);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image|*.jpg;*.png;*.gif;";
            dialog.ShowDialog();
            Image img = Image.FromFile(dialog.FileName);
            Drawer.DrawImage(img, new Point(0, 0));
        }
    }
}
