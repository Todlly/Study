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
        private Dictionary<string, int> prices = new Dictionary<string, int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Reading prices from txt and adding it to the prices variable
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
        }

    }
}
