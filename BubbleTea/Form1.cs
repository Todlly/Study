using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BubbleTea
{
    public partial class Form1 : Form
    {
        private bool sizeChosen, milkChosen, typeChosen, tempChosen, flavorChosen, transApproved;
        private string size, milk, type, temp, flavor;

        private void CowMilk_CheckedChanged(object sender, EventArgs e)
        {
            milk = "cow";
            milkChosen = true;
        }

        private void SoyMilk_CheckedChanged(object sender, EventArgs e)
        {
            milk = "extra";
            milkChosen = true;
        }

        private void CoconutMilk_CheckedChanged(object sender, EventArgs e)
        {
            milk = "extra";
            milkChosen = true;
        }

        private void AlmondMilk_CheckedChanged(object sender, EventArgs e)
        {
            milk = "extra";
            milkChosen = true;
        }

        private void ColdTemp_CheckedChanged(object sender, EventArgs e)
        {
            temp = "cold";
            tempChosen = true;
        }

        private void WarmTemp_CheckedChanged(object sender, EventArgs e)
        {
            temp = "warm";
            tempChosen = true;
        }

        private void HotTemp_CheckedChanged(object sender, EventArgs e)
        {
            temp = "hot";
            tempChosen = true;
        }

        private void StrawberryFlavor_CheckedChanged(object sender, EventArgs e)
        {
            flavor = "strawberry";
            TeaPictureBox.Image = Image.FromFile(Application.StartupPath + @"/Flavors/strawberry.png");
            flavorChosen = true;
        }

        private void CoconutFlavor_CheckedChanged(object sender, EventArgs e)
        {
            flavor = "coconut";
            TeaPictureBox.Image = Image.FromFile(Application.StartupPath + @"/Flavors/coco.png");
            flavorChosen = true;
        }

        private void BananaFlavor_CheckedChanged(object sender, EventArgs e)
        {
            flavor = "banana";
            TeaPictureBox.Image = Image.FromFile(Application.StartupPath + @"/Flavors/banana.png");
            flavorChosen = true;
        }

        private void ChocolateFlavor_CheckedChanged(object sender, EventArgs e)
        {
            flavor = "chocolate";
            TeaPictureBox.Image = Image.FromFile(Application.StartupPath + @"/Flavors/chocolate.png");
            flavorChosen = true;
        }

        private void BlueberryFlavor_CheckedChanged(object sender, EventArgs e)
        {
            flavor = "blueberry";
            TeaPictureBox.Image = Image.FromFile(Application.StartupPath + @"/Flavors/blueberry.png");
            flavorChosen = true;
        }

        private void MintFlavor_CheckedChanged(object sender, EventArgs e)
        {
            flavor = "mint";
            TeaPictureBox.Image = Image.FromFile(Application.StartupPath + @"/Flavors/mint.png");
            flavorChosen = true;
        }

        private void SolveAmountButton_Click(object sender, EventArgs e)
        {
            if (!sizeChosen)
                MessageBox.Show("Choose size");
            else if (!typeChosen)
                MessageBox.Show("Choose type");
            else if (!milkChosen)
                MessageBox.Show("Choose milk");
            else if (!tempChosen)
                MessageBox.Show("Choose temperature");
            else if (!flavorChosen)
                MessageBox.Show("Choose flavor");
            else
            {
                int amount = 0;
                switch (size)
                {
                    case "small":
                        amount += prices["SmallSize"];
                        break;
                    case "medium":
                        amount += prices["MediumSize"];
                        break;
                    case "big":
                        amount += prices["BigSize"];
                        break;
                }
                if (milk == "extra")
                    amount += prices["ExtraMilk"];
                TotalBox.Text = amount.ToString();
            }
        }

        private void GreenType_CheckedChanged(object sender, EventArgs e)
        {
            type = "green";
            typeChosen = true;
        }

        private Dictionary<string, int> prices = new Dictionary<string, int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void BlackType_CheckedChanged(object sender, EventArgs e)
        {
            type = "black";
            typeChosen = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Reading prices from txt and adding it to the prices list
            StreamReader reader = new StreamReader(Application.StartupPath + @"\PriceList.txt");
            string str;
            while((str = reader.ReadLine()) != null)
            {
                if(str != "-")
                {
                    string[] nameNprice = str.Split(new char[] { '-' });
                    prices.Add(nameNprice[0], Convert.ToInt32(nameNprice[1]));
                }
            }

            SmallSizePrice.Text = prices["SmallSize"].ToString();
            MediumSizePrice.Text = prices["MediumSize"].ToString();
            BigSizePrice.Text = prices["BigSize"].ToString();
            ExtraMilk1.Text = "+" + prices["ExtraMilk"];
            ExtraMilk2.Text = "+" + prices["ExtraMilk"];
            ExtraMilk3.Text = "+" + prices["ExtraMilk"];

            TeaPictureBox.Image = Image.FromFile(Application.StartupPath + @"/Flavors/coco.png");
        }

        private void BigSize_CheckedChanged(object sender, EventArgs e)
        {
            size = "big";
            SizeLabel.Text = "450ml";
            sizeChosen = true;
        }

        private void MediumSize_CheckedChanged(object sender, EventArgs e)
        {
            size = "medium";
            SizeLabel.Text = "350ml";
            sizeChosen = true;
        }

        private void SmallSize_CheckedChanged(object sender, EventArgs e)
        {
            size = "small";
            SizeLabel.Text = "250ml";
            sizeChosen = true;
        }
    }
}
