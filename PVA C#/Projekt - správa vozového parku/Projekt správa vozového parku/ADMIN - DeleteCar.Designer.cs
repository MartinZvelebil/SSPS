namespace Projekt_správa_vozového_parku
{
    partial class ADMIN___DeleteCar
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
            this.DeleteButton = new System.Windows.Forms.Button();
            this.CarDelete = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WhatCarLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.DeleteButton.Location = new System.Drawing.Point(86, 146);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(111, 39);
            this.DeleteButton.TabIndex = 8;
            this.DeleteButton.Text = "Delete! ";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // CarDelete
            // 
            this.CarDelete.Location = new System.Drawing.Point(79, 102);
            this.CarDelete.Name = "CarDelete";
            this.CarDelete.Size = new System.Drawing.Size(165, 20);
            this.CarDelete.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "UID of Car";
            // 
            // WhatCarLabel
            // 
            this.WhatCarLabel.AutoSize = true;
            this.WhatCarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.WhatCarLabel.Location = new System.Drawing.Point(80, 32);
            this.WhatCarLabel.Name = "WhatCarLabel";
            this.WhatCarLabel.Size = new System.Drawing.Size(148, 36);
            this.WhatCarLabel.TabIndex = 5;
            this.WhatCarLabel.Text = "Delete car";
            // 
            // ADMIN___DeleteCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 241);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.CarDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WhatCarLabel);
            this.Name = "ADMIN___DeleteCar";
            this.Text = "ADMIN___DeleteCar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TextBox CarDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label WhatCarLabel;
    }
}