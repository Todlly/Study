namespace DataGrids
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.studentsDataGrid = new System.Windows.Forms.DataGridView();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabStudents = new System.Windows.Forms.TabPage();
            this.butonReadFromFile = new System.Windows.Forms.Button();
            this.buttonRandomize = new System.Windows.Forms.Button();
            this.boxColumnsCount = new System.Windows.Forms.NumericUpDown();
            this.boxRowsCount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.BoxRowCount = new System.Windows.Forms.Label();
            this.tabAverage = new System.Windows.Forms.TabPage();
            this.averageDataGrid = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGrid)).BeginInit();
            this.TabControl.SuspendLayout();
            this.tabStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxColumnsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxRowsCount)).BeginInit();
            this.tabAverage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.averageDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // studentsDataGrid
            // 
            this.studentsDataGrid.AllowDrop = true;
            this.studentsDataGrid.AllowUserToAddRows = false;
            this.studentsDataGrid.AllowUserToDeleteRows = false;
            this.studentsDataGrid.AllowUserToResizeColumns = false;
            this.studentsDataGrid.AllowUserToResizeRows = false;
            this.studentsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.studentsDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.studentsDataGrid.BackgroundColor = System.Drawing.Color.DarkGray;
            this.studentsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsDataGrid.Location = new System.Drawing.Point(3, 35);
            this.studentsDataGrid.Name = "studentsDataGrid";
            this.studentsDataGrid.RowHeadersWidth = 130;
            this.studentsDataGrid.Size = new System.Drawing.Size(876, 438);
            this.studentsDataGrid.TabIndex = 0;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabStudents);
            this.TabControl.Controls.Add(this.tabAverage);
            this.TabControl.Controls.Add(this.tabPage3);
            this.TabControl.Controls.Add(this.tabPage4);
            this.TabControl.Controls.Add(this.tabPage5);
            this.TabControl.Location = new System.Drawing.Point(12, 12);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(890, 554);
            this.TabControl.TabIndex = 1;
            // 
            // tabStudents
            // 
            this.tabStudents.Controls.Add(this.butonReadFromFile);
            this.tabStudents.Controls.Add(this.buttonRandomize);
            this.tabStudents.Controls.Add(this.boxColumnsCount);
            this.tabStudents.Controls.Add(this.boxRowsCount);
            this.tabStudents.Controls.Add(this.label2);
            this.tabStudents.Controls.Add(this.BoxRowCount);
            this.tabStudents.Controls.Add(this.studentsDataGrid);
            this.tabStudents.Location = new System.Drawing.Point(4, 22);
            this.tabStudents.Name = "tabStudents";
            this.tabStudents.Padding = new System.Windows.Forms.Padding(3);
            this.tabStudents.Size = new System.Drawing.Size(882, 528);
            this.tabStudents.TabIndex = 0;
            this.tabStudents.Text = "Students";
            this.tabStudents.UseVisualStyleBackColor = true;
            // 
            // butonReadFromFile
            // 
            this.butonReadFromFile.Location = new System.Drawing.Point(146, 479);
            this.butonReadFromFile.Name = "butonReadFromFile";
            this.butonReadFromFile.Size = new System.Drawing.Size(106, 23);
            this.butonReadFromFile.TabIndex = 6;
            this.butonReadFromFile.Text = "Read from file";
            this.butonReadFromFile.UseVisualStyleBackColor = true;
            this.butonReadFromFile.Click += new System.EventHandler(this.butonReadFromFile_Click);
            // 
            // buttonRandomize
            // 
            this.buttonRandomize.Location = new System.Drawing.Point(9, 479);
            this.buttonRandomize.Name = "buttonRandomize";
            this.buttonRandomize.Size = new System.Drawing.Size(75, 23);
            this.buttonRandomize.TabIndex = 5;
            this.buttonRandomize.Text = "Randomize";
            this.buttonRandomize.UseVisualStyleBackColor = true;
            this.buttonRandomize.Click += new System.EventHandler(this.ButtonRandomize_Click);
            // 
            // boxColumnsCount
            // 
            this.boxColumnsCount.Location = new System.Drawing.Point(407, 8);
            this.boxColumnsCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.boxColumnsCount.Name = "boxColumnsCount";
            this.boxColumnsCount.ReadOnly = true;
            this.boxColumnsCount.Size = new System.Drawing.Size(120, 20);
            this.boxColumnsCount.TabIndex = 4;
            this.boxColumnsCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.boxColumnsCount.ValueChanged += new System.EventHandler(this.MoveColumnsCount);
            // 
            // boxRowsCount
            // 
            this.boxRowsCount.Location = new System.Drawing.Point(61, 8);
            this.boxRowsCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.boxRowsCount.Name = "boxRowsCount";
            this.boxRowsCount.ReadOnly = true;
            this.boxRowsCount.Size = new System.Drawing.Size(120, 20);
            this.boxRowsCount.TabIndex = 3;
            this.boxRowsCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.boxRowsCount.ValueChanged += new System.EventHandler(this.MoveRowsCount);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Subjects";
            // 
            // BoxRowCount
            // 
            this.BoxRowCount.AutoSize = true;
            this.BoxRowCount.Location = new System.Drawing.Point(6, 12);
            this.BoxRowCount.Name = "BoxRowCount";
            this.BoxRowCount.Size = new System.Drawing.Size(49, 13);
            this.BoxRowCount.TabIndex = 1;
            this.BoxRowCount.Text = "Students";
            // 
            // tabAverage
            // 
            this.tabAverage.Controls.Add(this.averageDataGrid);
            this.tabAverage.Location = new System.Drawing.Point(4, 22);
            this.tabAverage.Name = "tabAverage";
            this.tabAverage.Padding = new System.Windows.Forms.Padding(3);
            this.tabAverage.Size = new System.Drawing.Size(882, 528);
            this.tabAverage.TabIndex = 1;
            this.tabAverage.Text = "Average";
            this.tabAverage.UseVisualStyleBackColor = true;
            this.tabAverage.Enter += new System.EventHandler(this.tabAverage_Enter);
            // 
            // averageDataGrid
            // 
            this.averageDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.averageDataGrid.Location = new System.Drawing.Point(6, 84);
            this.averageDataGrid.Name = "averageDataGrid";
            this.averageDataGrid.Size = new System.Drawing.Size(870, 438);
            this.averageDataGrid.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(882, 528);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(882, 528);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(882, 528);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 620);
            this.Controls.Add(this.TabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGrid)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.tabStudents.ResumeLayout(false);
            this.tabStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxColumnsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxRowsCount)).EndInit();
            this.tabAverage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.averageDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView studentsDataGrid;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabStudents;
        private System.Windows.Forms.TabPage tabAverage;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.NumericUpDown boxColumnsCount;
        private System.Windows.Forms.NumericUpDown boxRowsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label BoxRowCount;
        private System.Windows.Forms.Button buttonRandomize;
        private System.Windows.Forms.Button butonReadFromFile;
        private System.Windows.Forms.DataGridView averageDataGrid;
    }
}

