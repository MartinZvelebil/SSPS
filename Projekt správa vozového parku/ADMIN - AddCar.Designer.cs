namespace Projekt_správa_vozového_parku
{
    partial class ADMIN___AddCar
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
            this.AddCarLabel = new System.Windows.Forms.Label();
            this.brandlabel = new System.Windows.Forms.Label();
            this.modellabel = new System.Windows.Forms.Label();
            this.typelabel = new System.Windows.Forms.Label();
            this.litreslabel = new System.Windows.Forms.Label();
            this.Cost = new System.Windows.Forms.Label();
            this.BrandTextBox = new System.Windows.Forms.TextBox();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.TypeTextBox = new System.Windows.Forms.TextBox();
            this.LitresNumericBox = new System.Windows.Forms.NumericUpDown();
            this.AddCarButton = new System.Windows.Forms.Button();
            this.CostValueBox = new System.Windows.Forms.NumericUpDown();
            this.UidLabel = new System.Windows.Forms.Label();
            this.UIDValue = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.LitresNumericBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostValueBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIDValue)).BeginInit();
            this.SuspendLayout();
            // 
            // AddCarLabel
            // 
            this.AddCarLabel.AutoSize = true;
            this.AddCarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.AddCarLabel.Location = new System.Drawing.Point(136, 31);
            this.AddCarLabel.Name = "AddCarLabel";
            this.AddCarLabel.Size = new System.Drawing.Size(221, 36);
            this.AddCarLabel.TabIndex = 1;
            this.AddCarLabel.Text = "Add car for rent";
            // 
            // brandlabel
            // 
            this.brandlabel.AutoSize = true;
            this.brandlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.brandlabel.Location = new System.Drawing.Point(152, 112);
            this.brandlabel.Name = "brandlabel";
            this.brandlabel.Size = new System.Drawing.Size(51, 18);
            this.brandlabel.TabIndex = 2;
            this.brandlabel.Text = "Brand:";
            // 
            // modellabel
            // 
            this.modellabel.AutoSize = true;
            this.modellabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.modellabel.Location = new System.Drawing.Point(152, 139);
            this.modellabel.Name = "modellabel";
            this.modellabel.Size = new System.Drawing.Size(53, 18);
            this.modellabel.TabIndex = 3;
            this.modellabel.Text = "Model:";
            // 
            // typelabel
            // 
            this.typelabel.AutoSize = true;
            this.typelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.typelabel.Location = new System.Drawing.Point(159, 167);
            this.typelabel.Name = "typelabel";
            this.typelabel.Size = new System.Drawing.Size(44, 18);
            this.typelabel.TabIndex = 4;
            this.typelabel.Text = "Type:";
            // 
            // litreslabel
            // 
            this.litreslabel.AutoSize = true;
            this.litreslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.litreslabel.Location = new System.Drawing.Point(139, 194);
            this.litreslabel.Name = "litreslabel";
            this.litreslabel.Size = new System.Drawing.Size(64, 18);
            this.litreslabel.TabIndex = 5;
            this.litreslabel.Text = "l /100km";
            // 
            // Cost
            // 
            this.Cost.AutoSize = true;
            this.Cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Cost.Location = new System.Drawing.Point(159, 222);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(44, 18);
            this.Cost.TabIndex = 6;
            this.Cost.Text = "Cost:";
            // 
            // BrandTextBox
            // 
            this.BrandTextBox.Location = new System.Drawing.Point(209, 113);
            this.BrandTextBox.Name = "BrandTextBox";
            this.BrandTextBox.Size = new System.Drawing.Size(100, 20);
            this.BrandTextBox.TabIndex = 7;
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Location = new System.Drawing.Point(209, 140);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(100, 20);
            this.ModelTextBox.TabIndex = 8;
            // 
            // TypeTextBox
            // 
            this.TypeTextBox.Location = new System.Drawing.Point(209, 168);
            this.TypeTextBox.Name = "TypeTextBox";
            this.TypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.TypeTextBox.TabIndex = 9;
            // 
            // LitresNumericBox
            // 
            this.LitresNumericBox.DecimalPlaces = 1;
            this.LitresNumericBox.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.LitresNumericBox.Location = new System.Drawing.Point(209, 196);
            this.LitresNumericBox.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.LitresNumericBox.Name = "LitresNumericBox";
            this.LitresNumericBox.Size = new System.Drawing.Size(100, 20);
            this.LitresNumericBox.TabIndex = 10;
            // 
            // AddCarButton
            // 
            this.AddCarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.AddCarButton.Location = new System.Drawing.Point(162, 268);
            this.AddCarButton.Name = "AddCarButton";
            this.AddCarButton.Size = new System.Drawing.Size(151, 50);
            this.AddCarButton.TabIndex = 12;
            this.AddCarButton.Text = "Add CAR!";
            this.AddCarButton.UseVisualStyleBackColor = true;
            this.AddCarButton.Click += new System.EventHandler(this.AddCarButton_Click);
            // 
            // CostValueBox
            // 
            this.CostValueBox.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CostValueBox.Location = new System.Drawing.Point(209, 224);
            this.CostValueBox.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.CostValueBox.Name = "CostValueBox";
            this.CostValueBox.Size = new System.Drawing.Size(100, 20);
            this.CostValueBox.TabIndex = 13;
            // 
            // UidLabel
            // 
            this.UidLabel.AutoSize = true;
            this.UidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.UidLabel.Location = new System.Drawing.Point(166, 82);
            this.UidLabel.Name = "UidLabel";
            this.UidLabel.Size = new System.Drawing.Size(37, 18);
            this.UidLabel.TabIndex = 14;
            this.UidLabel.Text = "UID:";
            // 
            // UIDValue
            // 
            this.UIDValue.Location = new System.Drawing.Point(209, 82);
            this.UIDValue.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.UIDValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UIDValue.Name = "UIDValue";
            this.UIDValue.Size = new System.Drawing.Size(100, 20);
            this.UIDValue.TabIndex = 15;
            this.UIDValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ADMIN___AddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 394);
            this.Controls.Add(this.UIDValue);
            this.Controls.Add(this.UidLabel);
            this.Controls.Add(this.CostValueBox);
            this.Controls.Add(this.AddCarButton);
            this.Controls.Add(this.LitresNumericBox);
            this.Controls.Add(this.TypeTextBox);
            this.Controls.Add(this.ModelTextBox);
            this.Controls.Add(this.BrandTextBox);
            this.Controls.Add(this.Cost);
            this.Controls.Add(this.litreslabel);
            this.Controls.Add(this.typelabel);
            this.Controls.Add(this.modellabel);
            this.Controls.Add(this.brandlabel);
            this.Controls.Add(this.AddCarLabel);
            this.Name = "ADMIN___AddCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMIN___AddCar";
            ((System.ComponentModel.ISupportInitialize)(this.LitresNumericBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostValueBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIDValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddCarLabel;
        private System.Windows.Forms.Label brandlabel;
        private System.Windows.Forms.Label modellabel;
        private System.Windows.Forms.Label typelabel;
        private System.Windows.Forms.Label litreslabel;
        private System.Windows.Forms.Label Cost;
        private System.Windows.Forms.TextBox BrandTextBox;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.TextBox TypeTextBox;
        private System.Windows.Forms.NumericUpDown LitresNumericBox;
        private System.Windows.Forms.Button AddCarButton;
        private System.Windows.Forms.NumericUpDown CostValueBox;
        private System.Windows.Forms.Label UidLabel;
        private System.Windows.Forms.NumericUpDown UIDValue;
    }
}