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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Shffler = new System.Windows.Forms.Button();
            this.shuffleTimes = new System.Windows.Forms.TextBox();
            this.TryWin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 353);
            this.panel1.TabIndex = 0;
            // 
            // Shffler
            // 
            this.Shffler.Location = new System.Drawing.Point(409, 256);
            this.Shffler.Name = "Shffler";
            this.Shffler.Size = new System.Drawing.Size(132, 66);
            this.Shffler.TabIndex = 1;
            this.Shffler.Text = "Shuffle";
            this.Shffler.UseVisualStyleBackColor = true;
            this.Shffler.Click += new System.EventHandler(this.Shffler_Click);
            // 
            // shuffleTimes
            // 
            this.shuffleTimes.Location = new System.Drawing.Point(409, 230);
            this.shuffleTimes.Name = "shuffleTimes";
            this.shuffleTimes.Size = new System.Drawing.Size(100, 20);
            this.shuffleTimes.TabIndex = 2;
            this.shuffleTimes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.shuffleTimes_KeyPress);
            // 
            // TryWin
            // 
            this.TryWin.Location = new System.Drawing.Point(409, 173);
            this.TryWin.Name = "TryWin";
            this.TryWin.Size = new System.Drawing.Size(132, 41);
            this.TryWin.TabIndex = 3;
            this.TryWin.Text = "Check";
            this.TryWin.UseVisualStyleBackColor = true;
            this.TryWin.Click += new System.EventHandler(this.TryWin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 450);
            this.Controls.Add(this.TryWin);
            this.Controls.Add(this.shuffleTimes);
            this.Controls.Add(this.Shffler);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Shffler;
        private System.Windows.Forms.TextBox shuffleTimes;
        private System.Windows.Forms.Button TryWin;
    }
}

