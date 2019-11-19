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
            shuffleTimes.Text = "0";
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
                    if (buttons[i, j].Text != "-1" && buttons[i, j].Text != "16")
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
                            return;
                        }
                        else if (currPos[i + 1, j] == 16)
                        {
                            currPos[i, j] = 16;
                            currPos[i + 1, j] = Convert.ToInt32((sender as Button).Text);
                            Swap(sender as Button);
                            return;
                        }
                        else if (currPos[i, j - 1] == 16)
                        {
                            currPos[i, j] = 16;
                            currPos[i, j - 1] = Convert.ToInt32((sender as Button).Text);
                            Swap(sender as Button);
                            return;
                        }
                        else if (currPos[i, j + 1] == 16)
                        {
                            currPos[i, j] = 16;
                            currPos[i, j + 1] = Convert.ToInt32((sender as Button).Text);
                            Swap(sender as Button);
                            return;
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
                        int top, left;
                        top = pos1.Top;
                        left = pos1.Left;
                        pos1.Left = buttons[i, j].Left;
                        pos1.Top = buttons[i, j].Top;
                        buttons[i, j].Left = left;
                        buttons[i, j].Top = top;
                    }
                }
            }
        }

        private void Shuffle(int times)
        {
            Random rand = new Random();
            for (int i = 0; i < times; i++)
            {
                int number = rand.Next(1, 15);
                foreach (var button in buttons)
                {
                    if (button.Text == number.ToString())
                    {
                        ButtonClick(button, null);
                    }
                }
            }
        }

        private void Shffler_Click(object sender, EventArgs e)
        {
            Shuffle(Convert.ToInt32(shuffleTimes.Text));
        }

        private void shuffleTimes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }

        private bool CheckPositions()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if(currPos[i,j] != winPos[i, j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void TryWin_Click(object sender, EventArgs e)
        {
            if (CheckPositions())
                MessageBox.Show("You win!");
            else
                MessageBox.Show("Not yet right!");
        }
        
        
    }
}
