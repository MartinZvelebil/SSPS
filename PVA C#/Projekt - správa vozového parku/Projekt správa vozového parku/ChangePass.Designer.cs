namespace Projekt_správa_vozového_parku
{
    partial class ChangePass
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
            this.NewPassText = new System.Windows.Forms.TextBox();
            this.OldPassText = new System.Windows.Forms.TextBox();
            this.NewPasswordLabel = new System.Windows.Forms.Label();
            this.OldPassLabel = new System.Windows.Forms.Label();
            this.Changepasswordbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewPassText
            // 
            this.NewPassText.Location = new System.Drawing.Point(184, 144);
            this.NewPassText.Name = "NewPassText";
            this.NewPassText.Size = new System.Drawing.Size(159, 20);
            this.NewPassText.TabIndex = 11;
            // 
            // OldPassText
            // 
            this.OldPassText.Location = new System.Drawing.Point(184, 115);
            this.OldPassText.Name = "OldPassText";
            this.OldPassText.Size = new System.Drawing.Size(159, 20);
            this.OldPassText.TabIndex = 10;
            // 
            // NewPasswordLabel
            // 
            this.NewPasswordLabel.AutoSize = true;
            this.NewPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.NewPasswordLabel.Location = new System.Drawing.Point(52, 144);
            this.NewPasswordLabel.Name = "NewPasswordLabel";
            this.NewPasswordLabel.Size = new System.Drawing.Size(126, 20);
            this.NewPasswordLabel.TabIndex = 9;
            this.NewPasswordLabel.Text = "New Password:";
            // 
            // OldPassLabel
            // 
            this.OldPassLabel.AutoSize = true;
            this.OldPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.OldPassLabel.Location = new System.Drawing.Point(61, 113);
            this.OldPassLabel.Name = "OldPassLabel";
            this.OldPassLabel.Size = new System.Drawing.Size(117, 20);
            this.OldPassLabel.TabIndex = 8;
            this.OldPassLabel.Text = "Old password:";
            // 
            // Changepasswordbutton
            // 
            this.Changepasswordbutton.Location = new System.Drawing.Point(165, 183);
            this.Changepasswordbutton.Name = "Changepasswordbutton";
            this.Changepasswordbutton.Size = new System.Drawing.Size(112, 28);
            this.Changepasswordbutton.TabIndex = 6;
            this.Changepasswordbutton.Text = "Change password";
            this.Changepasswordbutton.UseVisualStyleBackColor = true;
            this.Changepasswordbutton.Click += new System.EventHandler(this.Changepasswordbutton_Click);
            // 
            // ChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 314);
            this.Controls.Add(this.NewPassText);
            this.Controls.Add(this.OldPassText);
            this.Controls.Add(this.NewPasswordLabel);
            this.Controls.Add(this.OldPassLabel);
            this.Controls.Add(this.Changepasswordbutton);
            this.Name = "ChangePass";
            this.Text = "ChangePass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NewPassText;
        private System.Windows.Forms.TextBox OldPassText;
        private System.Windows.Forms.Label NewPasswordLabel;
        private System.Windows.Forms.Label OldPassLabel;
        private System.Windows.Forms.Button Changepasswordbutton;
    }
}