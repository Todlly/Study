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
            Splitter = new char[] { ',', ';', ' ' };
        }

        private void MoveRowsCount(object sender, EventArgs e)
        {
            if (reading)
                return;

            int newValue = (int)boxRowsCount.Value;

            if (newValue > studentsDataGrid.RowCount - 1)
            {
                studentsDataGrid.Rows.Add(new DataGridViewRow());
            }
            else if (newValue < studentsDataGrid.RowCount)
            {
                studentsDataGrid.Rows.RemoveAt(newValue);
            }

            StudentsCount = newValue;
            NameTable();
        }

        private void MoveColumnsCount(object sender, EventArgs e)
        {
            if (reading)
                return;

            int newValue = (int)boxColumnsCount.Value;

            SubjectsCount = newValue;
            studentsDataGrid.ColumnCount = newValue;
            NameTable();
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
            reading = true;

            boxColumnsCount.Minimum = 0;
            boxRowsCount.Minimum = 0;
            boxColumnsCount.Value = 0;
            boxRowsCount.Value = 0;
            studentsDataGrid.RowCount = 0;
            studentsDataGrid.ColumnCount = 0;
            SubjectsCount = 0;
            StudentsCount = 0;

            StreamReader reader = new StreamReader(Path);

            string str;

            while ((str = reader.ReadLine()) != null)
            {
                string[] cells = str.Split(Splitter);

                if (SubjectsCount == 0)
                {
                    studentsDataGrid.ColumnCount = cells.Length - 1;
                    for (int i = 1; i < cells.Length; i++)
                    {
                        SubjectsCount++;
                        boxColumnsCount.Value++;
                        studentsDataGrid.Columns[i - 1].Name = cells[i];
                    }
                    continue;
                }

                reading = true;
                StudentsCount++;
                boxRowsCount.Value++;

                studentsDataGrid.Rows.Add();
                studentsDataGrid.Rows[studentsDataGrid.RowCount - 1].HeaderCell.Value = cells[0];
                for(int i = 0; i < studentsDataGrid.ColumnCount; i++)
                {
                    studentsDataGrid[i, studentsDataGrid.RowCount - 1].Value = cells[i + 1];
                }

            }

            boxColumnsCount.Minimum = 1;
            boxRowsCount.Minimum = 1;
            reading = false;
            reader.Close();
        }

        private void NameTable()
        {
            for (int i = 0; i < studentsDataGrid.ColumnCount; i++)
            {
                if (studentsDataGrid.Columns[i].Name == string.Empty)
                {
                    studentsDataGrid.Columns[i].Name = "Subject " + (i + 1).ToString();
                }
            }
            for (int i = 0; i < studentsDataGrid.RowCount; i++)
            {
                if (studentsDataGrid.Rows[i].HeaderCell.Value == null)
                {
                    studentsDataGrid.Rows[i].HeaderCell.Value = "Student " + (i + 1).ToString();
                }
            }
        }
    }
}
