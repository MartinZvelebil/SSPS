namespace Projekt_správa_vozového_parku
{
    partial class ADMIN___ShowAllUsers
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
            this.AdminLabel = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.Box = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AdminLabel
            // 
            this.AdminLabel.AutoSize = true;
            this.AdminLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.AdminLabel.Location = new System.Drawing.Point(92, 25);
            this.AdminLabel.Name = "AdminLabel";
            this.AdminLabel.Size = new System.Drawing.Size(131, 36);
            this.AdminLabel.TabIndex = 2;
            this.AdminLabel.Text = "All users";
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.numberLabel.Location = new System.Drawing.Point(251, 25);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(115, 36);
            this.numberLabel.TabIndex = 3;
            this.numberLabel.Text = "number";
            this.numberLabel.Click += new System.EventHandler(this.numberLabel_Click);
            // 
            // Box
            // 
            this.Box.FormattingEnabled = true;
            this.Box.Location = new System.Drawing.Point(108, 64);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(186, 303);
            this.Box.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Force password change";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ADMIN___ShowAllUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 427);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Box);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.AdminLabel);
            this.Name = "ADMIN___ShowAllUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMIN___ShowAllUsers";
            this.Load += new System.EventHandler(this.ADMIN___ShowAllUsers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AdminLabel;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.ListBox Box;
        private System.Windows.Forms.Button button1;
    }
}