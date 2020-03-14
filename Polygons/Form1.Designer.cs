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
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelNodes = new System.Windows.Forms.Label();
            this.labelThickness = new System.Windows.Forms.Label();
            this.NodesCountBox = new System.Windows.Forms.NumericUpDown();
            this.RadiusBar = new System.Windows.Forms.TrackBar();
            this.labelRadius = new System.Windows.Forms.Label();
            this.checkBoxCTN = new System.Windows.Forms.CheckBox();
            this.ColorMono = new System.Windows.Forms.RadioButton();
            this.ThicknessBar = new System.Windows.Forms.TrackBar();
            this.ColorRandom = new System.Windows.Forms.RadioButton();
            this.ChooseColorButt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RotationSpeedBox = new System.Windows.Forms.TrackBar();
            this.checkBoxRotate = new System.Windows.Forms.CheckBox();
            this.CoCKWButt = new System.Windows.Forms.RadioButton();
            this.CKWButt = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NodesCountBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadiusBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThicknessBar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RotationSpeedBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.panel2);
            this.panel.Controls.Add(this.panel1);
            this.panel.Controls.Add(this.buttonClear);
            this.panel.Controls.Add(this.buttonDraw);
            this.panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(233, 450);
            this.panel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelNodes);
            this.panel2.Controls.Add(this.labelThickness);
            this.panel2.Controls.Add(this.NodesCountBox);
            this.panel2.Controls.Add(this.RadiusBar);
            this.panel2.Controls.Add(this.labelRadius);
            this.panel2.Controls.Add(this.checkBoxCTN);
            this.panel2.Controls.Add(this.ColorMono);
            this.panel2.Controls.Add(this.ThicknessBar);
            this.panel2.Controls.Add(this.ColorRandom);
            this.panel2.Controls.Add(this.ChooseColorButt);
            this.panel2.Location = new System.Drawing.Point(8, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 231);
            this.panel2.TabIndex = 17;
            // 
            // labelNodes
            // 
            this.labelNodes.AutoSize = true;
            this.labelNodes.Location = new System.Drawing.Point(3, 15);
            this.labelNodes.Name = "labelNodes";
            this.labelNodes.Size = new System.Drawing.Size(82, 13);
            this.labelNodes.TabIndex = 0;
            this.labelNodes.Text = "Кол-во вершин";
            // 
            // labelThickness
            // 
            this.labelThickness.AutoSize = true;
            this.labelThickness.Location = new System.Drawing.Point(21, 164);
            this.labelThickness.Name = "labelThickness";
            this.labelThickness.Size = new System.Drawing.Size(53, 13);
            this.labelThickness.TabIndex = 13;
            this.labelThickness.Text = "Толщина";
            // 
            // NodesCountBox
            // 
            this.NodesCountBox.Location = new System.Drawing.Point(91, 13);
            this.NodesCountBox.Name = "NodesCountBox";
            this.NodesCountBox.Size = new System.Drawing.Size(54, 20);
            this.NodesCountBox.TabIndex = 1;
            this.NodesCountBox.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NodesCountBox.ValueChanged += new System.EventHandler(this.UpdatePolygon);
            // 
            // RadiusBar
            // 
            this.RadiusBar.Location = new System.Drawing.Point(73, 39);
            this.RadiusBar.Maximum = 250;
            this.RadiusBar.Minimum = 50;
            this.RadiusBar.Name = "RadiusBar";
            this.RadiusBar.Size = new System.Drawing.Size(107, 45);
            this.RadiusBar.TabIndex = 2;
            this.RadiusBar.Value = 50;
            this.RadiusBar.Scroll += new System.EventHandler(this.UpdatePolygon);
            // 
            // labelRadius
            // 
            this.labelRadius.AutoSize = true;
            this.labelRadius.Location = new System.Drawing.Point(4, 55);
            this.labelRadius.Name = "labelRadius";
            this.labelRadius.Size = new System.Drawing.Size(43, 13);
            this.labelRadius.TabIndex = 3;
            this.labelRadius.Text = "Радиус";
            // 
            // checkBoxCTN
            // 
            this.checkBoxCTN.AutoSize = true;
            this.checkBoxCTN.Location = new System.Drawing.Point(20, 202);
            this.checkBoxCTN.Name = "checkBoxCTN";
            this.checkBoxCTN.Size = new System.Drawing.Size(129, 17);
            this.checkBoxCTN.TabIndex = 8;
            this.checkBoxCTN.Text = "Соединить вершины";
            this.checkBoxCTN.UseVisualStyleBackColor = true;
            this.checkBoxCTN.Click += new System.EventHandler(this.Redraw);
            // 
            // ColorMono
            // 
            this.ColorMono.AutoSize = true;
            this.ColorMono.Checked = true;
            this.ColorMono.Location = new System.Drawing.Point(6, 94);
            this.ColorMono.Name = "ColorMono";
            this.ColorMono.Size = new System.Drawing.Size(52, 17);
            this.ColorMono.TabIndex = 4;
            this.ColorMono.TabStop = true;
            this.ColorMono.Text = "Моно";
            this.ColorMono.UseVisualStyleBackColor = true;
            this.ColorMono.Click += new System.EventHandler(this.Redraw);
            // 
            // ThicknessBar
            // 
            this.ThicknessBar.Location = new System.Drawing.Point(87, 151);
            this.ThicknessBar.Name = "ThicknessBar";
            this.ThicknessBar.Size = new System.Drawing.Size(104, 45);
            this.ThicknessBar.TabIndex = 7;
            this.ThicknessBar.ValueChanged += new System.EventHandler(this.Redraw);
            // 
            // ColorRandom
            // 
            this.ColorRandom.AutoSize = true;
            this.ColorRandom.Location = new System.Drawing.Point(6, 117);
            this.ColorRandom.Name = "ColorRandom";
            this.ColorRandom.Size = new System.Drawing.Size(68, 17);
            this.ColorRandom.TabIndex = 5;
            this.ColorRandom.Text = "Цветной";
            this.ColorRandom.UseVisualStyleBackColor = true;
            this.ColorRandom.Click += new System.EventHandler(this.Redraw);
            // 
            // ChooseColorButt
            // 
            this.ChooseColorButt.Location = new System.Drawing.Point(80, 94);
            this.ChooseColorButt.Name = "ChooseColorButt";
            this.ChooseColorButt.Size = new System.Drawing.Size(75, 23);
            this.ChooseColorButt.TabIndex = 6;
            this.ChooseColorButt.Text = "Цвет";
            this.ChooseColorButt.UseVisualStyleBackColor = true;
            this.ChooseColorButt.Click += new System.EventHandler(this.ChooseColorButt_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RotationSpeedBox);
            this.panel1.Controls.Add(this.checkBoxRotate);
            this.panel1.Controls.Add(this.CoCKWButt);
            this.panel1.Controls.Add(this.CKWButt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(8, 244);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 126);
            this.panel1.TabIndex = 16;
            // 
            // RotationSpeedBox
            // 
            this.RotationSpeedBox.Location = new System.Drawing.Point(0, 54);
            this.RotationSpeedBox.Maximum = 70;
            this.RotationSpeedBox.Minimum = 1;
            this.RotationSpeedBox.Name = "RotationSpeedBox";
            this.RotationSpeedBox.Size = new System.Drawing.Size(104, 45);
            this.RotationSpeedBox.TabIndex = 16;
            this.RotationSpeedBox.Value = 1;
            // 
            // checkBoxRotate
            // 
            this.checkBoxRotate.AutoSize = true;
            this.checkBoxRotate.Location = new System.Drawing.Point(7, 8);
            this.checkBoxRotate.Name = "checkBoxRotate";
            this.checkBoxRotate.Size = new System.Drawing.Size(71, 17);
            this.checkBoxRotate.TabIndex = 9;
            this.checkBoxRotate.Text = "Вращать";
            this.checkBoxRotate.UseVisualStyleBackColor = true;
            this.checkBoxRotate.CheckedChanged += new System.EventHandler(this.checkBoxRotate_CheckedChanged);
            // 
            // CoCKWButt
            // 
            this.CoCKWButt.AutoSize = true;
            this.CoCKWButt.Checked = true;
            this.CoCKWButt.Location = new System.Drawing.Point(85, 31);
            this.CoCKWButt.Name = "CoCKWButt";
            this.CoCKWButt.Size = new System.Drawing.Size(106, 17);
            this.CoCKWButt.TabIndex = 15;
            this.CoCKWButt.TabStop = true;
            this.CoCKWButt.Text = "Против часовой";
            this.CoCKWButt.UseVisualStyleBackColor = true;
            // 
            // CKWButt
            // 
            this.CKWButt.AutoSize = true;
            this.CKWButt.Location = new System.Drawing.Point(85, 8);
            this.CKWButt.Name = "CKWButt";
            this.CKWButt.Size = new System.Drawing.Size(83, 17);
            this.CKWButt.TabIndex = 14;
            this.CKWButt.Text = "По часовой";
            this.CKWButt.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Скорость";
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
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(233, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(453, 450);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 450);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Polygons";
            this.panel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NodesCountBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadiusBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThicknessBar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RotationSpeedBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label labelThickness;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.CheckBox checkBoxRotate;
        private System.Windows.Forms.CheckBox checkBoxCTN;
        private System.Windows.Forms.TrackBar ThicknessBar;
        private System.Windows.Forms.Button ChooseColorButt;
        private System.Windows.Forms.RadioButton ColorRandom;
        private System.Windows.Forms.RadioButton ColorMono;
        private System.Windows.Forms.Label labelRadius;
        private System.Windows.Forms.TrackBar RadiusBar;
        private System.Windows.Forms.NumericUpDown NodesCountBox;
        private System.Windows.Forms.Label labelNodes;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton CoCKWButt;
        private System.Windows.Forms.RadioButton CKWButt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TrackBar RotationSpeedBox;
    }
}

