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
        private int[,] winPos, currPos;
        private int movesCounter, gridSize, emptyNumber;
        private float time;
        private bool runningGame, shuffling;
        private Button[,] buttons;

        public Form1()
        {
            InitializeComponent();
            movesCounter = 0;
            MovesLabel.Text = "Moves: " + movesCounter;
            runningGame = false;
            shuffling = false;
            TimeLabel.Text = "Time: " + time;
            timer1.Interval = 1000;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Left -= 50;
            panel1.Top -= 50;
            panel2.Top -= 50;
            this.Height -= 50;
            gridSize = 4;
            BuildField(gridSize);
        }

        private void BuildField(int size)
        {
            Reset();
            panel1.Controls.Clear();
            gridSize = size;
            emptyNumber = (gridSize - 2) * (gridSize - 2);
            winPos = new int[gridSize, gridSize];
            currPos = new int[gridSize, gridSize];
            buttons = new Button[gridSize, gridSize];

            int counter = 1;

            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    if (i == 0 || i == gridSize - 1 || j == 0 || j == gridSize - 1)
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
            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Height = 50;
                    buttons[i, j].Width = 50;
                    buttons[i, j].Left = j * 50;
                    buttons[i, j].Top = i * 50;
                    buttons[i, j].Text = winPos[i, j].ToString();
                    if (buttons[i, j].Text != "-1" && buttons[i, j].Text != emptyNumber.ToString())
                    {
                        panel1.Controls.Add(buttons[i, j]);
                        buttons[i, j].Click += new EventHandler(ButtonClick);
                    }
                    else if (buttons[i, j].Text == emptyNumber.ToString())
                    {
                        buttons[i, j].Text = emptyNumber.ToString();
                    }
                }
            }
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            if (!runningGame && !shuffling)
                return;
            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    if (currPos[i, j] == Convert.ToInt32((sender as Button).Text))
                    {
                        if (currPos[i - 1, j] == emptyNumber)
                        {
                            Swap(sender as Button, i, j, i - 1, j);
                            return;
                        }
                        else if (currPos[i + 1, j] == emptyNumber)
                        {
                            Swap(sender as Button, i, j, i + 1, j);
                            return;
                        }
                        else if (currPos[i, j - 1] == emptyNumber)
                        {
                            Swap(sender as Button, i, j, i, j - 1);
                            return;
                        }
                        else if (currPos[i, j + 1] == emptyNumber)
                        {
                            Swap(sender as Button, i, j, i, j + 1);
                            return;
                        }
                    }
                }
            }
        }

        private void Swap(Button pos1, int n, int m, int d, int k)
        {
            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    if (buttons[i, j].Text == emptyNumber.ToString())
                    {
                        int top, left;
                        top = pos1.Top;
                        left = pos1.Left;
                        pos1.Left = buttons[i, j].Left;
                        pos1.Top = buttons[i, j].Top;
                        buttons[i, j].Left = left;
                        buttons[i, j].Top = top;
                        currPos[n, m] = emptyNumber;
                        currPos[d, k] = Convert.ToInt32(pos1.Text);
                    }
                }
            }
            AddTurn();
            if (CheckPositions() && runningGame)
                Win();
        }

        private void Shuffle(int times)
        {
            Random rand = new Random();
            for (int i = 0; i < times; i++)
            {
                int number = rand.Next(1, emptyNumber - 1);
                foreach (var button in buttons)
                {
                    if (button.Text == number.ToString())
                    {
                        ButtonClick(button, null);
                    }
                }
            }
            movesCounter = 0;
            MovesLabel.Text = "Moves: " + movesCounter;
        }

        private void Shffler_Click(object sender, EventArgs e)
        {
            shuffling = true;
            Shuffle(Convert.ToInt32(shuffleTimes.Text));
            shuffling = false;
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
            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    if (currPos[i, j] != winPos[i, j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void SizeChooser_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (SizeChooser.SelectedItem)
            {
                case "3":
                    BuildField(4);
                    break;
                case "8":
                    BuildField(5);
                    break;
                case "15":
                    BuildField(6);
                    break;
                case "24":
                    BuildField(7);
                    break;
            }
        }

        private void Reset()
        {
            timer1.Stop();
            runningGame = false;
            time = 0;
            TimeLabel.Text = "Time: " + time;
            movesCounter = 0;
            MovesLabel.Text = "Moves: " + movesCounter;
        }

        private void SizeChooser_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Win()
        {
            timer1.Stop();
            MessageBox.Show($"Your time: {time} seconds, moves: {movesCounter}", "You win!");
            Reset();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (!runningGame)
            {
                if (CheckPositions())
                {
                    MessageBox.Show("Shuffle first!");
                }
                else
                {
                    TimeLabel.Text = "Time: " + time;
                    shuffleTimes.Text = "0";
                    timer1.Start();
                    runningGame = true;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time += 1f;
            TimeLabel.Text = "Time: " + time;
        }

        private void AddTurn()
        {
            movesCounter++;
            MovesLabel.Text = "Moves: " + movesCounter;
        }
    }
}
