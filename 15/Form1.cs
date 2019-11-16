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

namespace _15
{
    public partial class Form1 : Form
    {
        int[,] winPos, currPos;
        Button[,] buttons;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            winPos = new int[6, 6];
            currPos = new int[6, 6];
            buttons = new Button[6, 6];

            int counter = 1;

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (i == 0 || i == 5 || j == 0 || j == 5)
                    {
                        winPos[i, j] = -1;
                        currPos[i, j] = -1;
                    }
                    else
                    {
                        winPos[i, j] = counter;
                        currPos[i, j] = counter;
                        counter++;
                    }
                }
            }
            CreateButtons();
        }

        private void CreateButtons()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Height = 50;
                    buttons[i, j].Width = 50;
                    buttons[i, j].Left = j * 50;
                    buttons[i, j].Top = i * 50;
                    buttons[i, j].Text = winPos[i, j].ToString();
                    if (buttons[i, j].Text != "-1" /* && buttons[i, j].Text != "16" */)
                    {
                        panel1.Controls.Add(buttons[i, j]);
                        buttons[i, j].Click += new EventHandler(ButtonClick);
                    }
                }
            }
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (currPos[i, j] == Convert.ToInt32((sender as Button).Text))
                    {
                        if (currPos[i - 1, j] == 16)
                        {
                            currPos[i, j] = 16;
                            currPos[i - 1, j] = Convert.ToInt32((sender as Button).Text);
                            Swap(sender as Button);
                            
                        }
                        else if (currPos[i + 1, j] == 16)
                        {
                            currPos[i, j] = 16;
                            currPos[i + 1, j] = Convert.ToInt32((sender as Button).Text);
                            Swap(sender as Button);
                        }
                        else if (currPos[i, j - 1] == 16)
                        {
                            currPos[i, j] = 16;
                            currPos[i, j - 1] = Convert.ToInt32((sender as Button).Text);
                            Swap(sender as Button);
                        }
                        else if (currPos[i, j + 1] == 16)
                        {
                            currPos[i, j] = 16;
                            currPos[i, j + 1] = Convert.ToInt32((sender as Button).Text);
                            Swap(sender as Button);
                        }
                    }
                }
            }
        }

        private void Swap(Button pos1)
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (buttons[i, j].Text == "16")
                    {
                        Point pos3 = new Point(pos1.Left, pos1.Top);
                        pos1.Left = buttons[i,j].Left;
                        pos1.Top = buttons[i,j].Top;
                        buttons[i,j].Left = pos3.X;
                        buttons[i,j].Top = pos3.Y;
                    }
                }
            }
        }



    }
}
