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

namespace DataGrids
{
    public partial class Form1 : Form
    {
        private bool reading;
        private int studentsCount;
        private int subjectsCount;

        public int StudentsCount
        {
            get => studentsCount;
            set
            {
                studentsCount = value;
            }
        }

        public int SubjectsCount
        {
            get => subjectsCount;
            set
            {
                subjectsCount = value;
            }
        }

        private string Path { get; set; }

        public char[] Splitter { get; set; }

        public Form1()
        {
            InitializeComponent();
            Path = Application.StartupPath + "\\Students.csv";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MoveColumnsCount(null, null);
            MoveRowsCount(null, null);
            Splitter = new char[] { ',' };
        }

        private void MoveRowsCount(object sender, EventArgs e)
        {
            if (reading)
                return;

            int newValue = (int)boxRowsCount.Value;

            if (newValue > studentsDataGrid.RowCount - 1)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.HeaderCell.Value = "Student" + newValue;
                studentsDataGrid.Rows.Add(row);
            }
            else if (newValue < studentsDataGrid.RowCount)
            {
                studentsDataGrid.Rows.RemoveAt(newValue);
            }

            StudentsCount = newValue;
        }

        private void MoveColumnsCount(object sender, EventArgs e)
        {
            if (reading)
                return;

            int newValue = (int)boxColumnsCount.Value;

            SubjectsCount = newValue;
            studentsDataGrid.ColumnCount = newValue;
            if (newValue > 0)
                studentsDataGrid.Columns[newValue - 1].Name = "Subject " + newValue.ToString();
        }

        private void ButtonRandomize_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            for (int i = 0; i < studentsDataGrid.RowCount; i++)
            {
                for (int j = 0; j < studentsDataGrid.ColumnCount; j++)
                {
                    if (studentsDataGrid[j, i].Value == null)
                        studentsDataGrid[j, i].Value = rand.Next(2, 6).ToString();
                }
            }
        }

        private void butonReadFromFile_Click(object sender, EventArgs e)
        {
            boxColumnsCount.Minimum = 0;
            boxRowsCount.Minimum = 0;
            SubjectsCount = 0;
            StudentsCount = 0;
            studentsDataGrid.RowCount = 0;
            studentsDataGrid.ColumnCount = 0;

            StreamReader reader = new StreamReader(Path);

            string str;

            while ((str = reader.ReadLine()) != null)
            {
                string[] cells = str.Split(Splitter);

                if (SubjectsCount == 0)
                {
                    for (int i = 1; i < cells.Length; i++)
                    {
                        SubjectsCount++;
                        boxColumnsCount.Value++;
                        studentsDataGrid.Columns[i - 1].Name = cells[i];
                    }
                }

                reading = true;
                StudentsCount++;
                boxRowsCount.Value++;
                DataGridViewRow row = new DataGridViewRow();
                row.HeaderCell.Value = cells[0];
                
                for(int i = 1; i < cells.Length; i++)
                {
                    row.Cells[i].Value = cells[i];
                }
                studentsDataGrid.Rows.Add(row);
            }

            boxColumnsCount.Minimum = 1;
            boxRowsCount.Minimum = 1;
            reading = false;
        }
    }
}
