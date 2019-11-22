namespace _15
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Shffler = new System.Windows.Forms.Button();
            this.shuffleTimes = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MovesLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SizeChooser = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 300);
            this.panel1.TabIndex = 0;
            // 
            // Shffler
            // 
            this.Shffler.Location = new System.Drawing.Point(3, 53);
            this.Shffler.Name = "Shffler";
            this.Shffler.Size = new System.Drawing.Size(76, 25);
            this.Shffler.TabIndex = 1;
            this.Shffler.Text = "Shuffle";
            this.Shffler.UseVisualStyleBackColor = true;
            this.Shffler.Click += new System.EventHandler(this.Shffler_Click);
            // 
            // shuffleTimes
            // 
            this.shuffleTimes.Location = new System.Drawing.Point(3, 27);
            this.shuffleTimes.Name = "shuffleTimes";
            this.shuffleTimes.Size = new System.Drawing.Size(76, 20);
            this.shuffleTimes.TabIndex = 2;
            this.shuffleTimes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.shuffleTimes_KeyPress);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MovesLabel
            // 
            this.MovesLabel.AutoSize = true;
            this.MovesLabel.Location = new System.Drawing.Point(159, 12);
            this.MovesLabel.Name = "MovesLabel";
            this.MovesLabel.Size = new System.Drawing.Size(39, 13);
            this.MovesLabel.TabIndex = 4;
            this.MovesLabel.Text = "Moves";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(85, 8);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(69, 70);
            this.StartButton.TabIndex = 5;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(160, 37);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(35, 13);
            this.TimeLabel.TabIndex = 6;
            this.TimeLabel.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.SizeChooser);
            this.panel2.Controls.Add(this.StartButton);
            this.panel2.Controls.Add(this.TimeLabel);
            this.panel2.Controls.Add(this.Shffler);
            this.panel2.Controls.Add(this.shuffleTimes);
            this.panel2.Controls.Add(this.MovesLabel);
            this.panel2.Location = new System.Drawing.Point(1, 307);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 141);
            this.panel2.TabIndex = 7;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.progressBar1.Location = new System.Drawing.Point(3, 111);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(244, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 9;
            // 
            // SizeChooser
            // 
            this.SizeChooser.FormattingEnabled = true;
            this.SizeChooser.Items.AddRange(new object[] {
            "3",
            "8",
            "15",
            "24"});
            this.SizeChooser.Location = new System.Drawing.Point(3, 84);
            this.SizeChooser.Name = "SizeChooser";
            this.SizeChooser.Size = new System.Drawing.Size(121, 21);
            this.SizeChooser.TabIndex = 8;
            this.SizeChooser.Text = "Size";
            this.SizeChooser.SelectedIndexChanged += new System.EventHandler(this.SizeChooser_SelectedIndexChanged);
            this.SizeChooser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SizeChooser_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Shuffle times";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 452);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "15";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Shffler;
        private System.Windows.Forms.TextBox shuffleTimes;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label MovesLabel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox SizeChooser;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
    }
}

