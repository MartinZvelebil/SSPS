namespace Projekt_správa_vozového_parku
{
    partial class ADMIN___DeleteUser
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
            this.WhatCarLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UserNameDelete = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WhatCarLabel
            // 
            this.WhatCarLabel.AutoSize = true;
            this.WhatCarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.WhatCarLabel.Location = new System.Drawing.Point(60, 9);
            this.WhatCarLabel.Name = "WhatCarLabel";
            this.WhatCarLabel.Size = new System.Drawing.Size(165, 36);
            this.WhatCarLabel.TabIndex = 1;
            this.WhatCarLabel.Text = "Delete user";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name of user:";
            // 
            // UserNameDelete
            // 
            this.UserNameDelete.Location = new System.Drawing.Point(91, 82);
            this.UserNameDelete.Name = "UserNameDelete";
            this.UserNameDelete.Size = new System.Drawing.Size(165, 20);
            this.UserNameDelete.TabIndex = 3;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.DeleteButton.Location = new System.Drawing.Point(82, 132);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(111, 39);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Delete! ";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ADMIN___DeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 183);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UserNameDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WhatCarLabel);
            this.Name = "ADMIN___DeleteUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMIN___DeleteUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WhatCarLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserNameDelete;
        private System.Windows.Forms.Button DeleteButton;
    }
}