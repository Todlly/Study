using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Photoshop
{
    public partial class Form1 : Form
    {
        private Bitmap image;

        public Bitmap Image
        {
            get
            {
                return image;
            }
            set
            {
                image = value;
                PictureBox.Size = Image.Size;
                PictureBox.Image = Image;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtLoad_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            Image = new Bitmap(openFileDialog1.FileName);
            
        }

        private void ButtSave_Click(object sender, EventArgs e)
        {
            
            saveFileDialog1.ShowDialog();
            string path = saveFileDialog1.FileName;
            Image.Save(path);
        }

        private void ButtShrink_Click(object sender, EventArgs e)
        {
            Image = new Bitmap(PictureBox.Image, new Size((int)(PictureBox.Size.Width * 0.9), (int)PictureBox.Size.Height * 0.9));
        }
    }
}
