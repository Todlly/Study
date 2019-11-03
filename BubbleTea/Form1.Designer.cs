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
            this.ExtraMilk3 = new System.Windows.Forms.Label();
            this.ExtraMilk1 = new System.Windows.Forms.Label();
            this.ExtraMilk2 = new System.Windows.Forms.Label();
            this.AlmondMilk = new System.Windows.Forms.RadioButton();
            this.CoconutMilk = new System.Windows.Forms.RadioButton();
            this.SoyMilk = new System.Windows.Forms.RadioButton();
            this.CowMilk = new System.Windows.Forms.RadioButton();
            this.TemperatureGroup = new System.Windows.Forms.GroupBox();
            this.HotTemp = new System.Windows.Forms.RadioButton();
            this.WarmTemp = new System.Windows.Forms.RadioButton();
            this.ColdTemp = new System.Windows.Forms.RadioButton();
            this.FlavorsGroup = new System.Windows.Forms.GroupBox();
            this.MintFlavor = new System.Windows.Forms.RadioButton();
            this.BlueberryFlavor = new System.Windows.Forms.RadioButton();
            this.ChocolateFlavor = new System.Windows.Forms.RadioButton();
            this.BananaFlavor = new System.Windows.Forms.RadioButton();
            this.CoconutFlavor = new System.Windows.Forms.RadioButton();
            this.StrawberryFlavor = new System.Windows.Forms.RadioButton();
            this.TeaPictureBox = new System.Windows.Forms.PictureBox();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.SizeGroup.SuspendLayout();
            this.TeaTypeGroup.SuspendLayout();
            this.MilkGroup.SuspendLayout();
            this.TemperatureGroup.SuspendLayout();
            this.FlavorsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SolveAmountButton
            // 
            this.SolveAmountButton.Location = new System.Drawing.Point(18, 293);
            this.SolveAmountButton.Name = "SolveAmountButton";
            this.SolveAmountButton.Size = new System.Drawing.Size(100, 42);
            this.SolveAmountButton.TabIndex = 0;
            this.SolveAmountButton.Text = "SolveAmount";
            this.SolveAmountButton.UseVisualStyleBackColor = true;
            this.SolveAmountButton.Click += new System.EventHandler(this.SolveAmountButton_Click);
            // 
            // TotalBox
            // 
            this.TotalBox.Location = new System.Drawing.Point(203, 303);
            this.TotalBox.Name = "TotalBox";
            this.TotalBox.ReadOnly = true;
            this.TotalBox.Size = new System.Drawing.Size(100, 20);
            this.TotalBox.TabIndex = 1;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(139, 306);
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
            this.BigSizePrice.Location = new System.Drawing.Point(104, 67);
            this.BigSizePrice.Name = "BigSizePrice";
            this.BigSizePrice.Size = new System.Drawing.Size(35, 13);
            this.BigSizePrice.TabIndex = 5;
            this.BigSizePrice.Text = "label3";
            // 
            // MediumSizePrice
            // 
            this.MediumSizePrice.AutoSize = true;
            this.MediumSizePrice.Location = new System.Drawing.Point(104, 44);
            this.MediumSizePrice.Name = "MediumSizePrice";
            this.MediumSizePrice.Size = new System.Drawing.Size(35, 13);
            this.MediumSizePrice.TabIndex = 4;
            this.MediumSizePrice.Text = "label2";
            // 
            // SmallSizePrice
            // 
            this.SmallSizePrice.AutoSize = true;
            this.SmallSizePrice.Location = new System.Drawing.Point(104, 21);
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
            this.SmallSize.CheckedChanged += new System.EventHandler(this.SmallSize_CheckedChanged);
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
            this.MediumSize.CheckedChanged += new System.EventHandler(this.MediumSize_CheckedChanged);
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
            this.BigSize.CheckedChanged += new System.EventHandler(this.BigSize_CheckedChanged);
            // 
            // TeaTypeGroup
            // 
            this.TeaTypeGroup.Controls.Add(this.GreenType);
            this.TeaTypeGroup.Controls.Add(this.BlackType);
            this.TeaTypeGroup.Location = new System.Drawing.Point(179, 12);
            this.TeaTypeGroup.Name = "TeaTypeGroup";
            this.TeaTypeGroup.Size = new System.Drawing.Size(87, 97);
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
            this.GreenType.CheckedChanged += new System.EventHandler(this.GreenType_CheckedChanged);
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
            this.BlackType.CheckedChanged += new System.EventHandler(this.BlackType_CheckedChanged);
            // 
            // MilkGroup
            // 
            this.MilkGroup.Controls.Add(this.ExtraMilk3);
            this.MilkGroup.Controls.Add(this.ExtraMilk1);
            this.MilkGroup.Controls.Add(this.ExtraMilk2);
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
            // ExtraMilk3
            // 
            this.ExtraMilk3.AutoSize = true;
            this.ExtraMilk3.Location = new System.Drawing.Point(104, 109);
            this.ExtraMilk3.Name = "ExtraMilk3";
            this.ExtraMilk3.Size = new System.Drawing.Size(25, 13);
            this.ExtraMilk3.TabIndex = 8;
            this.ExtraMilk3.Text = "+25";
            // 
            // ExtraMilk1
            // 
            this.ExtraMilk1.AutoSize = true;
            this.ExtraMilk1.Location = new System.Drawing.Point(104, 63);
            this.ExtraMilk1.Name = "ExtraMilk1";
            this.ExtraMilk1.Size = new System.Drawing.Size(25, 13);
            this.ExtraMilk1.TabIndex = 7;
            this.ExtraMilk1.Text = "+25";
            // 
            // ExtraMilk2
            // 
            this.ExtraMilk2.AutoSize = true;
            this.ExtraMilk2.Location = new System.Drawing.Point(104, 86);
            this.ExtraMilk2.Name = "ExtraMilk2";
            this.ExtraMilk2.Size = new System.Drawing.Size(25, 13);
            this.ExtraMilk2.TabIndex = 6;
            this.ExtraMilk2.Text = "+25";
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
            this.AlmondMilk.CheckedChanged += new System.EventHandler(this.AlmondMilk_CheckedChanged);
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
            this.CoconutMilk.CheckedChanged += new System.EventHandler(this.CoconutMilk_CheckedChanged);
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
            this.SoyMilk.CheckedChanged += new System.EventHandler(this.SoyMilk_CheckedChanged);
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
            this.CowMilk.CheckedChanged += new System.EventHandler(this.CowMilk_CheckedChanged);
            // 
            // TemperatureGroup
            // 
            this.TemperatureGroup.Controls.Add(this.HotTemp);
            this.TemperatureGroup.Controls.Add(this.WarmTemp);
            this.TemperatureGroup.Controls.Add(this.ColdTemp);
            this.TemperatureGroup.Location = new System.Drawing.Point(179, 115);
            this.TemperatureGroup.Name = "TemperatureGroup";
            this.TemperatureGroup.Size = new System.Drawing.Size(87, 151);
            this.TemperatureGroup.TabIndex = 6;
            this.TemperatureGroup.TabStop = false;
            this.TemperatureGroup.Text = "Temperature";
            // 
            // HotTemp
            // 
            this.HotTemp.AutoSize = true;
            this.HotTemp.Location = new System.Drawing.Point(6, 66);
            this.HotTemp.Name = "HotTemp";
            this.HotTemp.Size = new System.Drawing.Size(42, 17);
            this.HotTemp.TabIndex = 2;
            this.HotTemp.TabStop = true;
            this.HotTemp.Text = "Hot";
            this.HotTemp.UseVisualStyleBackColor = true;
            this.HotTemp.CheckedChanged += new System.EventHandler(this.HotTemp_CheckedChanged);
            // 
            // WarmTemp
            // 
            this.WarmTemp.AutoSize = true;
            this.WarmTemp.Location = new System.Drawing.Point(6, 43);
            this.WarmTemp.Name = "WarmTemp";
            this.WarmTemp.Size = new System.Drawing.Size(53, 17);
            this.WarmTemp.TabIndex = 1;
            this.WarmTemp.TabStop = true;
            this.WarmTemp.Text = "Warm";
            this.WarmTemp.UseVisualStyleBackColor = true;
            this.WarmTemp.CheckedChanged += new System.EventHandler(this.WarmTemp_CheckedChanged);
            // 
            // ColdTemp
            // 
            this.ColdTemp.AutoSize = true;
            this.ColdTemp.Location = new System.Drawing.Point(7, 20);
            this.ColdTemp.Name = "ColdTemp";
            this.ColdTemp.Size = new System.Drawing.Size(46, 17);
            this.ColdTemp.TabIndex = 0;
            this.ColdTemp.TabStop = true;
            this.ColdTemp.Text = "Cold";
            this.ColdTemp.UseVisualStyleBackColor = true;
            this.ColdTemp.CheckedChanged += new System.EventHandler(this.ColdTemp_CheckedChanged);
            // 
            // FlavorsGroup
            // 
            this.FlavorsGroup.Controls.Add(this.MintFlavor);
            this.FlavorsGroup.Controls.Add(this.BlueberryFlavor);
            this.FlavorsGroup.Controls.Add(this.ChocolateFlavor);
            this.FlavorsGroup.Controls.Add(this.BananaFlavor);
            this.FlavorsGroup.Controls.Add(this.CoconutFlavor);
            this.FlavorsGroup.Controls.Add(this.StrawberryFlavor);
            this.FlavorsGroup.Location = new System.Drawing.Point(272, 12);
            this.FlavorsGroup.Name = "FlavorsGroup";
            this.FlavorsGroup.Size = new System.Drawing.Size(200, 254);
            this.FlavorsGroup.TabIndex = 7;
            this.FlavorsGroup.TabStop = false;
            this.FlavorsGroup.Text = "Flavors";
            // 
            // MintFlavor
            // 
            this.MintFlavor.AutoSize = true;
            this.MintFlavor.Location = new System.Drawing.Point(6, 134);
            this.MintFlavor.Name = "MintFlavor";
            this.MintFlavor.Size = new System.Drawing.Size(45, 17);
            this.MintFlavor.TabIndex = 5;
            this.MintFlavor.TabStop = true;
            this.MintFlavor.Text = "Mint";
            this.MintFlavor.UseVisualStyleBackColor = true;
            this.MintFlavor.CheckedChanged += new System.EventHandler(this.MintFlavor_CheckedChanged);
            // 
            // BlueberryFlavor
            // 
            this.BlueberryFlavor.AutoSize = true;
            this.BlueberryFlavor.Location = new System.Drawing.Point(6, 111);
            this.BlueberryFlavor.Name = "BlueberryFlavor";
            this.BlueberryFlavor.Size = new System.Drawing.Size(69, 17);
            this.BlueberryFlavor.TabIndex = 4;
            this.BlueberryFlavor.TabStop = true;
            this.BlueberryFlavor.Text = "Blueberry";
            this.BlueberryFlavor.UseVisualStyleBackColor = true;
            this.BlueberryFlavor.CheckedChanged += new System.EventHandler(this.BlueberryFlavor_CheckedChanged);
            // 
            // ChocolateFlavor
            // 
            this.ChocolateFlavor.AutoSize = true;
            this.ChocolateFlavor.Location = new System.Drawing.Point(6, 88);
            this.ChocolateFlavor.Name = "ChocolateFlavor";
            this.ChocolateFlavor.Size = new System.Drawing.Size(73, 17);
            this.ChocolateFlavor.TabIndex = 3;
            this.ChocolateFlavor.TabStop = true;
            this.ChocolateFlavor.Text = "Chocolate";
            this.ChocolateFlavor.UseVisualStyleBackColor = true;
            this.ChocolateFlavor.CheckedChanged += new System.EventHandler(this.ChocolateFlavor_CheckedChanged);
            // 
            // BananaFlavor
            // 
            this.BananaFlavor.AutoSize = true;
            this.BananaFlavor.Location = new System.Drawing.Point(6, 65);
            this.BananaFlavor.Name = "BananaFlavor";
            this.BananaFlavor.Size = new System.Drawing.Size(62, 17);
            this.BananaFlavor.TabIndex = 2;
            this.BananaFlavor.TabStop = true;
            this.BananaFlavor.Text = "Banana";
            this.BananaFlavor.UseVisualStyleBackColor = true;
            this.BananaFlavor.CheckedChanged += new System.EventHandler(this.BananaFlavor_CheckedChanged);
            // 
            // CoconutFlavor
            // 
            this.CoconutFlavor.AutoSize = true;
            this.CoconutFlavor.Location = new System.Drawing.Point(6, 44);
            this.CoconutFlavor.Name = "CoconutFlavor";
            this.CoconutFlavor.Size = new System.Drawing.Size(65, 17);
            this.CoconutFlavor.TabIndex = 1;
            this.CoconutFlavor.TabStop = true;
            this.CoconutFlavor.Text = "Coconut";
            this.CoconutFlavor.UseVisualStyleBackColor = true;
            this.CoconutFlavor.CheckedChanged += new System.EventHandler(this.CoconutFlavor_CheckedChanged);
            // 
            // StrawberryFlavor
            // 
            this.StrawberryFlavor.AutoSize = true;
            this.StrawberryFlavor.Location = new System.Drawing.Point(6, 21);
            this.StrawberryFlavor.Name = "StrawberryFlavor";
            this.StrawberryFlavor.Size = new System.Drawing.Size(75, 17);
            this.StrawberryFlavor.TabIndex = 0;
            this.StrawberryFlavor.TabStop = true;
            this.StrawberryFlavor.Text = "Strawberry";
            this.StrawberryFlavor.UseVisualStyleBackColor = true;
            this.StrawberryFlavor.CheckedChanged += new System.EventHandler(this.StrawberryFlavor_CheckedChanged);
            // 
            // TeaPictureBox
            // 
            this.TeaPictureBox.Location = new System.Drawing.Point(498, 19);
            this.TeaPictureBox.Name = "TeaPictureBox";
            this.TeaPictureBox.Size = new System.Drawing.Size(123, 195);
            this.TeaPictureBox.TabIndex = 8;
            this.TeaPictureBox.TabStop = false;
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Location = new System.Drawing.Point(545, 241);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(27, 13);
            this.SizeLabel.TabIndex = 9;
            this.SizeLabel.Text = "Size";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 351);
            this.Controls.Add(this.SizeLabel);
            this.Controls.Add(this.TeaPictureBox);
            this.Controls.Add(this.FlavorsGroup);
            this.Controls.Add(this.TemperatureGroup);
            this.Controls.Add(this.MilkGroup);
            this.Controls.Add(this.TeaTypeGroup);
            this.Controls.Add(this.SizeGroup);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.TotalBox);
            this.Controls.Add(this.SolveAmountButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "BubbleTea";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeGroup.ResumeLayout(false);
            this.SizeGroup.PerformLayout();
            this.TeaTypeGroup.ResumeLayout(false);
            this.TeaTypeGroup.PerformLayout();
            this.MilkGroup.ResumeLayout(false);
            this.MilkGroup.PerformLayout();
            this.TemperatureGroup.ResumeLayout(false);
            this.TemperatureGroup.PerformLayout();
            this.FlavorsGroup.ResumeLayout(false);
            this.FlavorsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeaPictureBox)).EndInit();
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
        private System.Windows.Forms.Label ExtraMilk2;
        private System.Windows.Forms.RadioButton AlmondMilk;
        private System.Windows.Forms.RadioButton CoconutMilk;
        private System.Windows.Forms.RadioButton SoyMilk;
        private System.Windows.Forms.Label ExtraMilk3;
        private System.Windows.Forms.Label ExtraMilk1;
        private System.Windows.Forms.GroupBox TemperatureGroup;
        private System.Windows.Forms.RadioButton HotTemp;
        private System.Windows.Forms.RadioButton WarmTemp;
        private System.Windows.Forms.RadioButton ColdTemp;
        private System.Windows.Forms.GroupBox FlavorsGroup;
        private System.Windows.Forms.RadioButton MintFlavor;
        private System.Windows.Forms.RadioButton BlueberryFlavor;
        private System.Windows.Forms.RadioButton ChocolateFlavor;
        private System.Windows.Forms.RadioButton BananaFlavor;
        private System.Windows.Forms.RadioButton CoconutFlavor;
        private System.Windows.Forms.RadioButton StrawberryFlavor;
        private System.Windows.Forms.PictureBox TeaPictureBox;
        private System.Windows.Forms.Label SizeLabel;
    }
}

