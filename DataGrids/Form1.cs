using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGrids
{
    public partial class Form1 : Form
    {
        private int studentsCount;
        int StudentsCount
        {
            get
            {
                return studentsCount;
            }
            set
            {
                if (value > dataGridView1.RowCount-1)
                {
                    studentsCount = value;
                    DataGridViewRow row = new DataGridViewRow();
                    row.HeaderCell.Value = "Student" + value;
                    dataGridView1.Rows.Add(row);
                }
                else if (value < dataGridView1.RowCount)
                {
                    dataGridView1.Rows.RemoveAt(value);
                }
            }
        }
        private int subjectsCount;
        int SubjectsCount
        {
            get
            {
                return subjectsCount;
            }
            set
            {
                if (value >= 0)
                {
                    subjectsCount = value;
                    dataGridView1.ColumnCount = value;
                    dataGridView1.Columns[value - 1].Name = "Subject " + value.ToString();
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SubjectsCount = 1;
            StudentsCount = 1;
        }

        private void BoxRowsCount_ValueChanged(object sender, EventArgs e)
        {
            StudentsCount = (int)BoxRowsCount.Value;
        }

        private void BoxColumnsCount_ValueChanged(object sender, EventArgs e)
        {
            SubjectsCount = (int)BoxColumnsCount.Value;
        }

        private void ButtonRandomize_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            for(int i = 0; i < dataGridView1.RowCount; i++)
            {
                for(int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if(dataGridView1[j, i].Value == null)
                    dataGridView1[j, i].Value = rand.Next(2, 6).ToString();
                }
            }
        }
    }
}
