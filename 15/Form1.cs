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

            int counter = 0;

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
            for(int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Height = 70;
                    buttons[i, j].Width = 70;
                    buttons[i, j].Left = j * 5 + 2;
                    buttons[i, j].Top = i * 5 + 2;
                    buttons[i, j].Text = winPos[i, j].ToString();
                    if(winPos[i,j] != -1 || winPos[i,j] != 16)
                    {
                        buttons[i, j].Visible = true;
                    }
                    buttons[i, j].Show();
                }
            }
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            for(int i = 0; i < 6; i++)
            {
                for(int j = 0; j < 6; j++)
                {
                    if(buttons[i,j] == sender as Button)
                    {
                        if(currPos[i - 1, j] == 16)
                        {
                            Swap(buttons[i, j], buttons[i - 1, j]);
                            currPos[i, j] = currPos[i - 1, j];
                            currPos[i - 1, j] = Convert.ToInt32((sender as Button).Text);
                        }else if(currPos[i + 1, j] == 16)
                        {
                            Swap(buttons[i, j], buttons[i + 1, j]);
                            currPos[i, j] = currPos[i + 1, j];
                            currPos[i + 1, j] = Convert.ToInt32((sender as Button).Text);
                        }
                        else if(currPos[i, j - 1] == 16)
                        {
                            Swap(buttons[i, j], buttons[i, j - 1]);
                            currPos[i, j] = currPos[i, j - 1];
                            currPos[i, j - 1] = Convert.ToInt32((sender as Button).Text);
                        }
                        else if(currPos[i, j + 1] == 16)
                        {
                            Swap(buttons[i, j], buttons[i, j + 1]);
                            currPos[i, j] = currPos[i, j + 1];
                            currPos[i, j + 1] = Convert.ToInt32((sender as Button).Text);
                        }
                    }
                }
            }
        }

        private void Swap(Button pos, Button dest)
        {
            Point posit = new Point(pos.Left, pos.Top);
            pos.Left = dest.Left;
            pos.Top = dest.Top;
            dest.Left = posit.X;
            dest.Top = posit.Y;
        }



    }
}
