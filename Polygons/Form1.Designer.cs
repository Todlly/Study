namespace Polygons
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
            this.panel = new System.Windows.Forms.Panel();
            this.labelThickness = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.numericUpDownRotatePause = new System.Windows.Forms.NumericUpDown();
            this.checkBoxRotate = new System.Windows.Forms.CheckBox();
            this.checkBoxCTN = new System.Windows.Forms.CheckBox();
            this.ThicknessBar = new System.Windows.Forms.TrackBar();
            this.ChooseColorButt = new System.Windows.Forms.Button();
            this.ColorRandom = new System.Windows.Forms.RadioButton();
            this.ColorMono = new System.Windows.Forms.RadioButton();
            this.labelRadius = new System.Windows.Forms.Label();
            this.trackBarRadius = new System.Windows.Forms.TrackBar();
            this.numericUpDownNodesCount = new System.Windows.Forms.NumericUpDown();
            this.labelNodes = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.CKWButt = new System.Windows.Forms.RadioButton();
            this.CoCKWButt = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRotatePause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThicknessBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNodesCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.panel1);
            this.panel.Controls.Add(this.labelThickness);
            this.panel.Controls.Add(this.buttonClear);
            this.panel.Controls.Add(this.buttonDraw);
            this.panel.Controls.Add(this.checkBoxCTN);
            this.panel.Controls.Add(this.ThicknessBar);
            this.panel.Controls.Add(this.ChooseColorButt);
            this.panel.Controls.Add(this.ColorRandom);
            this.panel.Controls.Add(this.ColorMono);
            this.panel.Controls.Add(this.labelRadius);
            this.panel.Controls.Add(this.trackBarRadius);
            this.panel.Controls.Add(this.numericUpDownNodesCount);
            this.panel.Controls.Add(this.labelNodes);
            this.panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(233, 450);
            this.panel.TabIndex = 0;
            // 
            // labelThickness
            // 
            this.labelThickness.AutoSize = true;
            this.labelThickness.Location = new System.Drawing.Point(41, 175);
            this.labelThickness.Name = "labelThickness";
            this.labelThickness.Size = new System.Drawing.Size(53, 13);
            this.labelThickness.TabIndex = 13;
            this.labelThickness.Text = "Толщина";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(12, 415);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 12;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(12, 386);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(75, 23);
            this.buttonDraw.TabIndex = 11;
            this.buttonDraw.Text = "Рисовать";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.Redraw);
            // 
            // numericUpDownRotatePause
            // 
            this.numericUpDownRotatePause.Location = new System.Drawing.Point(74, 4);
            this.numericUpDownRotatePause.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownRotatePause.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRotatePause.Name = "numericUpDownRotatePause";
            this.numericUpDownRotatePause.Size = new System.Drawing.Size(39, 20);
            this.numericUpDownRotatePause.TabIndex = 10;
            this.numericUpDownRotatePause.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBoxRotate
            // 
            this.checkBoxRotate.AutoSize = true;
            this.checkBoxRotate.Location = new System.Drawing.Point(3, 4);
            this.checkBoxRotate.Name = "checkBoxRotate";
            this.checkBoxRotate.Size = new System.Drawing.Size(71, 17);
            this.checkBoxRotate.TabIndex = 9;
            this.checkBoxRotate.Text = "Вращать";
            this.checkBoxRotate.UseVisualStyleBackColor = true;
            this.checkBoxRotate.CheckedChanged += new System.EventHandler(this.checkBoxRotate_CheckedChanged);
            // 
            // checkBoxCTN
            // 
            this.checkBoxCTN.AutoSize = true;
            this.checkBoxCTN.Location = new System.Drawing.Point(21, 211);
            this.checkBoxCTN.Name = "checkBoxCTN";
            this.checkBoxCTN.Size = new System.Drawing.Size(129, 17);
            this.checkBoxCTN.TabIndex = 8;
            this.checkBoxCTN.Text = "Соединить вершины";
            this.checkBoxCTN.UseVisualStyleBackColor = true;
            this.checkBoxCTN.Click += new System.EventHandler(this.Redraw);
            // 
            // ThicknessBar
            // 
            this.ThicknessBar.Location = new System.Drawing.Point(107, 162);
            this.ThicknessBar.Name = "ThicknessBar";
            this.ThicknessBar.Size = new System.Drawing.Size(104, 45);
            this.ThicknessBar.TabIndex = 7;
            this.ThicknessBar.ValueChanged += new System.EventHandler(this.Redraw);
            // 
            // ChooseColorButt
            // 
            this.ChooseColorButt.Location = new System.Drawing.Point(136, 114);
            this.ChooseColorButt.Name = "ChooseColorButt";
            this.ChooseColorButt.Size = new System.Drawing.Size(75, 23);
            this.ChooseColorButt.TabIndex = 6;
            this.ChooseColorButt.Text = "Цвет";
            this.ChooseColorButt.UseVisualStyleBackColor = true;
            this.ChooseColorButt.Click += new System.EventHandler(this.ChooseColorButt_Click);
            // 
            // ColorRandom
            // 
            this.ColorRandom.AutoSize = true;
            this.ColorRandom.Location = new System.Drawing.Point(21, 137);
            this.ColorRandom.Name = "ColorRandom";
            this.ColorRandom.Size = new System.Drawing.Size(68, 17);
            this.ColorRandom.TabIndex = 5;
            this.ColorRandom.Text = "Цветной";
            this.ColorRandom.UseVisualStyleBackColor = true;
            this.ColorRandom.Click += new System.EventHandler(this.Redraw);
            // 
            // ColorMono
            // 
            this.ColorMono.AutoSize = true;
            this.ColorMono.Checked = true;
            this.ColorMono.Location = new System.Drawing.Point(21, 114);
            this.ColorMono.Name = "ColorMono";
            this.ColorMono.Size = new System.Drawing.Size(52, 17);
            this.ColorMono.TabIndex = 4;
            this.ColorMono.TabStop = true;
            this.ColorMono.Text = "Моно";
            this.ColorMono.UseVisualStyleBackColor = true;
            this.ColorMono.Click += new System.EventHandler(this.Redraw);
            // 
            // labelRadius
            // 
            this.labelRadius.AutoSize = true;
            this.labelRadius.Location = new System.Drawing.Point(4, 59);
            this.labelRadius.Name = "labelRadius";
            this.labelRadius.Size = new System.Drawing.Size(43, 13);
            this.labelRadius.TabIndex = 3;
            this.labelRadius.Text = "Радиус";
            // 
            // trackBarRadius
            // 
            this.trackBarRadius.Location = new System.Drawing.Point(74, 50);
            this.trackBarRadius.Maximum = 250;
            this.trackBarRadius.Minimum = 50;
            this.trackBarRadius.Name = "trackBarRadius";
            this.trackBarRadius.Size = new System.Drawing.Size(104, 45);
            this.trackBarRadius.TabIndex = 2;
            this.trackBarRadius.Value = 50;
            this.trackBarRadius.ValueChanged += new System.EventHandler(this.Redraw);
            // 
            // numericUpDownNodesCount
            // 
            this.numericUpDownNodesCount.Location = new System.Drawing.Point(92, 22);
            this.numericUpDownNodesCount.Name = "numericUpDownNodesCount";
            this.numericUpDownNodesCount.Size = new System.Drawing.Size(54, 20);
            this.numericUpDownNodesCount.TabIndex = 1;
            this.numericUpDownNodesCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownNodesCount.ValueChanged += new System.EventHandler(this.Redraw);
            // 
            // labelNodes
            // 
            this.labelNodes.AutoSize = true;
            this.labelNodes.Location = new System.Drawing.Point(4, 24);
            this.labelNodes.Name = "labelNodes";
            this.labelNodes.Size = new System.Drawing.Size(82, 13);
            this.labelNodes.TabIndex = 0;
            this.labelNodes.Text = "Кол-во вершин";
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox.Location = new System.Drawing.Point(233, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(567, 450);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Скорость";
            // 
            // CKWButt
            // 
            this.CKWButt.AutoSize = true;
            this.CKWButt.Location = new System.Drawing.Point(74, 30);
            this.CKWButt.Name = "CKWButt";
            this.CKWButt.Size = new System.Drawing.Size(83, 17);
            this.CKWButt.TabIndex = 14;
            this.CKWButt.Text = "По часовой";
            this.CKWButt.UseVisualStyleBackColor = true;
            // 
            // CoCKWButt
            // 
            this.CoCKWButt.AutoSize = true;
            this.CoCKWButt.Checked = true;
            this.CoCKWButt.Location = new System.Drawing.Point(74, 53);
            this.CoCKWButt.Name = "CoCKWButt";
            this.CoCKWButt.Size = new System.Drawing.Size(106, 17);
            this.CoCKWButt.TabIndex = 15;
            this.CoCKWButt.TabStop = true;
            this.CoCKWButt.Text = "Против часовой";
            this.CoCKWButt.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxRotate);
            this.panel1.Controls.Add(this.CoCKWButt);
            this.panel1.Controls.Add(this.numericUpDownRotatePause);
            this.panel1.Controls.Add(this.CKWButt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 234);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 100);
            this.panel1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Polygons";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRotatePause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThicknessBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNodesCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label labelThickness;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.NumericUpDown numericUpDownRotatePause;
        private System.Windows.Forms.CheckBox checkBoxRotate;
        private System.Windows.Forms.CheckBox checkBoxCTN;
        private System.Windows.Forms.TrackBar ThicknessBar;
        private System.Windows.Forms.Button ChooseColorButt;
        private System.Windows.Forms.RadioButton ColorRandom;
        private System.Windows.Forms.RadioButton ColorMono;
        private System.Windows.Forms.Label labelRadius;
        private System.Windows.Forms.TrackBar trackBarRadius;
        private System.Windows.Forms.NumericUpDown numericUpDownNodesCount;
        private System.Windows.Forms.Label labelNodes;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton CoCKWButt;
        private System.Windows.Forms.RadioButton CKWButt;
        private System.Windows.Forms.Panel panel1;
    }
}

