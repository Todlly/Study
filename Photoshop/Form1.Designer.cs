namespace Photoshop
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
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.ButtSave = new System.Windows.Forms.Button();
            this.ButtLoad = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.ButtShrink = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.panel1.AutoScrollMinSize = new System.Drawing.Size(10, 10);
            this.panel1.Controls.Add(this.PictureBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 350);
            this.panel1.TabIndex = 0;
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(6, 6);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(320, 320);
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            // 
            // ButtSave
            // 
            this.ButtSave.Location = new System.Drawing.Point(101, 424);
            this.ButtSave.Name = "ButtSave";
            this.ButtSave.Size = new System.Drawing.Size(75, 23);
            this.ButtSave.TabIndex = 1;
            this.ButtSave.Text = "Save";
            this.ButtSave.UseVisualStyleBackColor = true;
            this.ButtSave.Click += new System.EventHandler(this.ButtSave_Click);
            // 
            // ButtLoad
            // 
            this.ButtLoad.Location = new System.Drawing.Point(20, 424);
            this.ButtLoad.Name = "ButtLoad";
            this.ButtLoad.Size = new System.Drawing.Size(75, 23);
            this.ButtLoad.TabIndex = 2;
            this.ButtLoad.Text = "Load";
            this.ButtLoad.UseVisualStyleBackColor = true;
            this.ButtLoad.Click += new System.EventHandler(this.ButtLoad_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ButtShrink
            // 
            this.ButtShrink.Location = new System.Drawing.Point(368, 12);
            this.ButtShrink.Name = "ButtShrink";
            this.ButtShrink.Size = new System.Drawing.Size(75, 23);
            this.ButtShrink.TabIndex = 3;
            this.ButtShrink.Text = "-";
            this.ButtShrink.UseVisualStyleBackColor = true;
            this.ButtShrink.Click += new System.EventHandler(this.ButtShrink_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.ButtShrink);
            this.Controls.Add(this.ButtLoad);
            this.Controls.Add(this.ButtSave);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Button ButtSave;
        private System.Windows.Forms.Button ButtLoad;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button ButtShrink;
    }
}

