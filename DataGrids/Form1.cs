using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGrids
{
    public partial class Form1 : Form
    {
        public bool Reading { get; set; }

        public int StudentsCount { get; set; }

        public int SubjectsCount { get; set; }

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
            if (Reading)
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
            if (Reading)
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
                    {
                        int mark = rand.Next(1, 6);
                        if (mark == 1)
                            studentsDataGrid[j, i].Value = "N/A";
                        else
                            studentsDataGrid[j, i].Value = mark.ToString();
                    }
                }
            }
        }

        private void butonReadFromFile_Click(object sender, EventArgs e)
        {
            Reading = true;

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

                Reading = true;
                StudentsCount++;
                boxRowsCount.Value++;

                studentsDataGrid.Rows.Add();
                studentsDataGrid.Rows[studentsDataGrid.RowCount - 1].HeaderCell.Value = cells[0];
                for (int i = 0; i < studentsDataGrid.ColumnCount; i++)
                {
                    if (Regex.IsMatch(cells[i + 1], @"N/A|[2-5]"))
                        studentsDataGrid[i, studentsDataGrid.RowCount - 1].Value = cells[i + 1];
                    else
                        studentsDataGrid[i, studentsDataGrid.RowCount - 1].Value = "Err";
                }

            }

            boxColumnsCount.Minimum = 1;
            boxRowsCount.Minimum = 1;
            Reading = false;
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

        private float AverageMark(DataGridViewRow row)
        {
            float counter = 0;
            foreach (DataGridViewCell cell in row.Cells)
            {
                if (cell.Value.ToString() != "N/A" && cell.Value.ToString() != "Err")
                    counter += Convert.ToInt32(cell.Value);
                else
                    counter++;
            }
            counter /= SubjectsCount;
            return counter;
        }

        private int CountValues(DataGridViewRow row, string val)
        {
            int counter = 0;
            foreach (DataGridViewCell cell in row.Cells)
            {
                if (cell.Value.ToString() == val)
                    counter++;
            }
            return counter;
        }

        private bool CheckStudentsTable()
        {
            foreach (DataGridViewRow row in studentsDataGrid.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == null)
                    {
                        MessageBox.Show("Fill the table first!");
                        TabControl.SelectedIndex = 0;
                        return false;
                    }
                }
            }
            return true;
        }

        private void tabAverage_Enter(object sender, EventArgs e)
        {
            if (CheckStudentsTable())
            {
                averageDataGrid.ColumnCount = 6;

                averageDataGrid.TopLeftHeaderCell.Value = "Students";
                averageDataGrid.Columns[0].Name = "N/A";
                averageDataGrid.Columns[1].Name = "2";
                averageDataGrid.Columns[2].Name = "3";
                averageDataGrid.Columns[3].Name = "4";
                averageDataGrid.Columns[4].Name = "5";
                averageDataGrid.Columns[5].Name = "Average";

                averageDataGrid.RowCount = StudentsCount + 1;
                averageDataGrid.Rows[StudentsCount].HeaderCell.Value = "Total:";

                for (int i = 0; i < studentsDataGrid.RowCount; i++)
                {
                    averageDataGrid.Rows[i].HeaderCell.Value = studentsDataGrid.Rows[i].HeaderCell.Value;
                    for (int m = 0; m < 5; m++)
                    {
                        averageDataGrid[m, i].Value = CountValues(studentsDataGrid.Rows[i], averageDataGrid.Columns[m].Name).ToString();
                    }
                    averageDataGrid[5, i].Value = AverageMark(studentsDataGrid.Rows[i]).ToString("0.0");
                }

                for (int i = 0; i < averageDataGrid.ColumnCount - 1; i++)
                {
                    double count = 0;
                    for (int j = 0; j < averageDataGrid.RowCount - 1; j++)
                    {
                        count += Convert.ToDouble(averageDataGrid[i, j].Value);
                    }
                    averageDataGrid[i, averageDataGrid.RowCount - 1].Value = count;
                }
            }
        }

        private void tabSubjects_Enter(object sender, EventArgs e)
        {
            if (!CheckStudentsTable())
                return;


            for (int i = -1; i < StudentsCount; i++)
            {
                for (int j = 0; j < SubjectsCount; j++)
                {
                    if(i == -1)
                    {
                     //   subjectsDataGrid[]
                    }
                }
            }
        }
    }
}
