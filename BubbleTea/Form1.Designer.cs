namespace BubbleTea
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SolveAmountButton = new System.Windows.Forms.Button();
            this.TotalBox = new System.Windows.Forms.TextBox();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.SizeGroup = new System.Windows.Forms.GroupBox();
            this.BigSizePrice = new System.Windows.Forms.Label();
            this.MediumSizePrice = new System.Windows.Forms.Label();
            this.SmallSizePrice = new System.Windows.Forms.Label();
            this.SmallSize = new System.Windows.Forms.RadioButton();
            this.MediumSize = new System.Windows.Forms.RadioButton();
            this.BigSize = new System.Windows.Forms.RadioButton();
            this.TeaTypeGroup = new System.Windows.Forms.GroupBox();
            this.GreenType = new System.Windows.Forms.RadioButton();
            this.BlackType = new System.Windows.Forms.RadioButton();
            this.MilkGroup = new System.Windows.Forms.GroupBox();
            this.CowMilk = new System.Windows.Forms.RadioButton();
            this.SoyMilk = new System.Windows.Forms.RadioButton();
            this.CoconutMilk = new System.Windows.Forms.RadioButton();
            this.AlmondMilk = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SizeGroup.SuspendLayout();
            this.TeaTypeGroup.SuspendLayout();
            this.MilkGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // SolveAmountButton
            // 
            this.SolveAmountButton.Location = new System.Drawing.Point(12, 458);
            this.SolveAmountButton.Name = "SolveAmountButton";
            this.SolveAmountButton.Size = new System.Drawing.Size(100, 42);
            this.SolveAmountButton.TabIndex = 0;
            this.SolveAmountButton.Text = "SolveAmount";
            this.SolveAmountButton.UseVisualStyleBackColor = true;
            // 
            // TotalBox
            // 
            this.TotalBox.Location = new System.Drawing.Point(197, 468);
            this.TotalBox.Name = "TotalBox";
            this.TotalBox.Size = new System.Drawing.Size(100, 20);
            this.TotalBox.TabIndex = 1;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(133, 471);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(31, 13);
            this.TotalLabel.TabIndex = 2;
            this.TotalLabel.Text = "Total";
            // 
            // SizeGroup
            // 
            this.SizeGroup.Controls.Add(this.BigSizePrice);
            this.SizeGroup.Controls.Add(this.MediumSizePrice);
            this.SizeGroup.Controls.Add(this.SmallSizePrice);
            this.SizeGroup.Controls.Add(this.SmallSize);
            this.SizeGroup.Controls.Add(this.MediumSize);
            this.SizeGroup.Controls.Add(this.BigSize);
            this.SizeGroup.Location = new System.Drawing.Point(12, 12);
            this.SizeGroup.Name = "SizeGroup";
            this.SizeGroup.Size = new System.Drawing.Size(161, 97);
            this.SizeGroup.TabIndex = 3;
            this.SizeGroup.TabStop = false;
            this.SizeGroup.Text = "Size";
            // 
            // BigSizePrice
            // 
            this.BigSizePrice.AutoSize = true;
            this.BigSizePrice.Location = new System.Drawing.Point(87, 69);
            this.BigSizePrice.Name = "BigSizePrice";
            this.BigSizePrice.Size = new System.Drawing.Size(35, 13);
            this.BigSizePrice.TabIndex = 5;
            this.BigSizePrice.Text = "label3";
            this.BigSizePrice.Click += new System.EventHandler(this.label3_Click);
            // 
            // MediumSizePrice
            // 
            this.MediumSizePrice.AutoSize = true;
            this.MediumSizePrice.Location = new System.Drawing.Point(87, 46);
            this.MediumSizePrice.Name = "MediumSizePrice";
            this.MediumSizePrice.Size = new System.Drawing.Size(35, 13);
            this.MediumSizePrice.TabIndex = 4;
            this.MediumSizePrice.Text = "label2";
            // 
            // SmallSizePrice
            // 
            this.SmallSizePrice.AutoSize = true;
            this.SmallSizePrice.Location = new System.Drawing.Point(87, 23);
            this.SmallSizePrice.Name = "SmallSizePrice";
            this.SmallSizePrice.Size = new System.Drawing.Size(35, 13);
            this.SmallSizePrice.TabIndex = 3;
            this.SmallSizePrice.Text = "label1";
            // 
            // SmallSize
            // 
            this.SmallSize.AutoSize = true;
            this.SmallSize.Location = new System.Drawing.Point(15, 19);
            this.SmallSize.Name = "SmallSize";
            this.SmallSize.Size = new System.Drawing.Size(50, 17);
            this.SmallSize.TabIndex = 2;
            this.SmallSize.TabStop = true;
            this.SmallSize.Text = "Small";
            this.SmallSize.UseVisualStyleBackColor = true;
            // 
            // MediumSize
            // 
            this.MediumSize.AutoSize = true;
            this.MediumSize.Location = new System.Drawing.Point(15, 42);
            this.MediumSize.Name = "MediumSize";
            this.MediumSize.Size = new System.Drawing.Size(62, 17);
            this.MediumSize.TabIndex = 1;
            this.MediumSize.TabStop = true;
            this.MediumSize.Text = "Medium";
            this.MediumSize.UseVisualStyleBackColor = true;
            // 
            // BigSize
            // 
            this.BigSize.AutoSize = true;
            this.BigSize.Location = new System.Drawing.Point(15, 65);
            this.BigSize.Name = "BigSize";
            this.BigSize.Size = new System.Drawing.Size(40, 17);
            this.BigSize.TabIndex = 0;
            this.BigSize.TabStop = true;
            this.BigSize.Text = "Big";
            this.BigSize.UseVisualStyleBackColor = true;
            // 
            // TeaTypeGroup
            // 
            this.TeaTypeGroup.Controls.Add(this.GreenType);
            this.TeaTypeGroup.Controls.Add(this.BlackType);
            this.TeaTypeGroup.Location = new System.Drawing.Point(179, 12);
            this.TeaTypeGroup.Name = "TeaTypeGroup";
            this.TeaTypeGroup.Size = new System.Drawing.Size(75, 97);
            this.TeaTypeGroup.TabIndex = 4;
            this.TeaTypeGroup.TabStop = false;
            this.TeaTypeGroup.Text = "Tea type";
            // 
            // GreenType
            // 
            this.GreenType.AutoSize = true;
            this.GreenType.Location = new System.Drawing.Point(6, 42);
            this.GreenType.Name = "GreenType";
            this.GreenType.Size = new System.Drawing.Size(54, 17);
            this.GreenType.TabIndex = 1;
            this.GreenType.TabStop = true;
            this.GreenType.Text = "Green";
            this.GreenType.UseVisualStyleBackColor = true;
            // 
            // BlackType
            // 
            this.BlackType.AutoSize = true;
            this.BlackType.Location = new System.Drawing.Point(6, 19);
            this.BlackType.Name = "BlackType";
            this.BlackType.Size = new System.Drawing.Size(52, 17);
            this.BlackType.TabIndex = 0;
            this.BlackType.TabStop = true;
            this.BlackType.Text = "Black";
            this.BlackType.UseVisualStyleBackColor = true;
            // 
            // MilkGroup
            // 
            this.MilkGroup.Controls.Add(this.label3);
            this.MilkGroup.Controls.Add(this.label2);
            this.MilkGroup.Controls.Add(this.label1);
            this.MilkGroup.Controls.Add(this.AlmondMilk);
            this.MilkGroup.Controls.Add(this.CoconutMilk);
            this.MilkGroup.Controls.Add(this.SoyMilk);
            this.MilkGroup.Controls.Add(this.CowMilk);
            this.MilkGroup.Location = new System.Drawing.Point(12, 115);
            this.MilkGroup.Name = "MilkGroup";
            this.MilkGroup.Size = new System.Drawing.Size(161, 151);
            this.MilkGroup.TabIndex = 5;
            this.MilkGroup.TabStop = false;
            this.MilkGroup.Text = "Milk";
            // 
            // CowMilk
            // 
            this.CowMilk.AutoSize = true;
            this.CowMilk.Location = new System.Drawing.Point(6, 19);
            this.CowMilk.Name = "CowMilk";
            this.CowMilk.Size = new System.Drawing.Size(46, 17);
            this.CowMilk.TabIndex = 0;
            this.CowMilk.TabStop = true;
            this.CowMilk.Text = "Cow";
            this.CowMilk.UseVisualStyleBackColor = true;
            // 
            // SoyMilk
            // 
            this.SoyMilk.AutoSize = true;
            this.SoyMilk.Location = new System.Drawing.Point(6, 61);
            this.SoyMilk.Name = "SoyMilk";
            this.SoyMilk.Size = new System.Drawing.Size(43, 17);
            this.SoyMilk.TabIndex = 1;
            this.SoyMilk.TabStop = true;
            this.SoyMilk.Text = "Soy";
            this.SoyMilk.UseVisualStyleBackColor = true;
            // 
            // CoconutMilk
            // 
            this.CoconutMilk.AutoSize = true;
            this.CoconutMilk.Location = new System.Drawing.Point(6, 84);
            this.CoconutMilk.Name = "CoconutMilk";
            this.CoconutMilk.Size = new System.Drawing.Size(65, 17);
            this.CoconutMilk.TabIndex = 2;
            this.CoconutMilk.TabStop = true;
            this.CoconutMilk.Text = "Coconut";
            this.CoconutMilk.UseVisualStyleBackColor = true;
            // 
            // AlmondMilk
            // 
            this.AlmondMilk.AutoSize = true;
            this.AlmondMilk.Location = new System.Drawing.Point(6, 107);
            this.AlmondMilk.Name = "AlmondMilk";
            this.AlmondMilk.Size = new System.Drawing.Size(60, 17);
            this.AlmondMilk.TabIndex = 3;
            this.AlmondMilk.TabStop = true;
            this.AlmondMilk.Text = "Almond";
            this.AlmondMilk.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "+25";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "+25";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "+25";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 519);
            this.Controls.Add(this.MilkGroup);
            this.Controls.Add(this.TeaTypeGroup);
            this.Controls.Add(this.SizeGroup);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.TotalBox);
            this.Controls.Add(this.SolveAmountButton);
            this.Name = "Form1";
            this.Text = "BubbleTea";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeGroup.ResumeLayout(false);
            this.SizeGroup.PerformLayout();
            this.TeaTypeGroup.ResumeLayout(false);
            this.TeaTypeGroup.PerformLayout();
            this.MilkGroup.ResumeLayout(false);
            this.MilkGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SolveAmountButton;
        private System.Windows.Forms.TextBox TotalBox;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.GroupBox SizeGroup;
        private System.Windows.Forms.RadioButton SmallSize;
        private System.Windows.Forms.RadioButton MediumSize;
        private System.Windows.Forms.RadioButton BigSize;
        private System.Windows.Forms.Label BigSizePrice;
        private System.Windows.Forms.Label MediumSizePrice;
        private System.Windows.Forms.Label SmallSizePrice;
        private System.Windows.Forms.GroupBox TeaTypeGroup;
        private System.Windows.Forms.RadioButton GreenType;
        private System.Windows.Forms.RadioButton BlackType;
        private System.Windows.Forms.GroupBox MilkGroup;
        private System.Windows.Forms.RadioButton CowMilk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton AlmondMilk;
        private System.Windows.Forms.RadioButton CoconutMilk;
        private System.Windows.Forms.RadioButton SoyMilk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

