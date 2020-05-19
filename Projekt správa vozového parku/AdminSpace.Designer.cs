namespace Projekt_správa_vozového_parku
{
    partial class AdminSpace
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
            this.AddCarButton = new System.Windows.Forms.Button();
            this.AdminLabel = new System.Windows.Forms.Label();
            this.CreateUserButton = new System.Windows.Forms.Button();
            this.DeleteUserButton = new System.Windows.Forms.Button();
            this.DeleteCarButton = new System.Windows.Forms.Button();
            this.ShowAllUsersButt = new System.Windows.Forms.Button();
            this.ShowAllCarsButt = new System.Windows.Forms.Button();
            this.ShowAllReservations = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddCarButton
            // 
            this.AddCarButton.BackColor = System.Drawing.Color.OliveDrab;
            this.AddCarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.AddCarButton.Location = new System.Drawing.Point(293, 69);
            this.AddCarButton.Name = "AddCarButton";
            this.AddCarButton.Size = new System.Drawing.Size(164, 46);
            this.AddCarButton.TabIndex = 0;
            this.AddCarButton.Text = "Add car for rent";
            this.AddCarButton.UseVisualStyleBackColor = false;
            this.AddCarButton.Click += new System.EventHandler(this.AddCarButton_Click);
            // 
            // AdminLabel
            // 
            this.AdminLabel.AutoSize = true;
            this.AdminLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.AdminLabel.Location = new System.Drawing.Point(120, 18);
            this.AdminLabel.Name = "AdminLabel";
            this.AdminLabel.Size = new System.Drawing.Size(226, 36);
            this.AdminLabel.TabIndex = 1;
            this.AdminLabel.Text = "Welcome admin";
            // 
            // CreateUserButton
            // 
            this.CreateUserButton.BackColor = System.Drawing.Color.OliveDrab;
            this.CreateUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.CreateUserButton.Location = new System.Drawing.Point(12, 69);
            this.CreateUserButton.Name = "CreateUserButton";
            this.CreateUserButton.Size = new System.Drawing.Size(164, 46);
            this.CreateUserButton.TabIndex = 2;
            this.CreateUserButton.Text = "Create User";
            this.CreateUserButton.UseVisualStyleBackColor = false;
            this.CreateUserButton.Click += new System.EventHandler(this.CreateUserButton_Click);
            // 
            // DeleteUserButton
            // 
            this.DeleteUserButton.BackColor = System.Drawing.Color.DarkRed;
            this.DeleteUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.DeleteUserButton.Location = new System.Drawing.Point(12, 121);
            this.DeleteUserButton.Name = "DeleteUserButton";
            this.DeleteUserButton.Size = new System.Drawing.Size(164, 46);
            this.DeleteUserButton.TabIndex = 3;
            this.DeleteUserButton.Text = "Delete User";
            this.DeleteUserButton.UseVisualStyleBackColor = false;
            this.DeleteUserButton.Click += new System.EventHandler(this.DeleteUserButton_Click);
            // 
            // DeleteCarButton
            // 
            this.DeleteCarButton.BackColor = System.Drawing.Color.DarkRed;
            this.DeleteCarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.DeleteCarButton.Location = new System.Drawing.Point(293, 121);
            this.DeleteCarButton.Name = "DeleteCarButton";
            this.DeleteCarButton.Size = new System.Drawing.Size(164, 46);
            this.DeleteCarButton.TabIndex = 4;
            this.DeleteCarButton.Text = "Delete car for rent";
            this.DeleteCarButton.UseVisualStyleBackColor = false;
            this.DeleteCarButton.Click += new System.EventHandler(this.DeleteCarButton_Click);
            // 
            // ShowAllUsersButt
            // 
            this.ShowAllUsersButt.BackColor = System.Drawing.Color.Khaki;
            this.ShowAllUsersButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ShowAllUsersButt.Location = new System.Drawing.Point(68, 173);
            this.ShowAllUsersButt.Name = "ShowAllUsersButt";
            this.ShowAllUsersButt.Size = new System.Drawing.Size(331, 46);
            this.ShowAllUsersButt.TabIndex = 5;
            this.ShowAllUsersButt.Text = "Show All Users + Force password change";
            this.ShowAllUsersButt.UseVisualStyleBackColor = false;
            this.ShowAllUsersButt.Click += new System.EventHandler(this.ShowAllUsersButt_Click);
            // 
            // ShowAllCarsButt
            // 
            this.ShowAllCarsButt.BackColor = System.Drawing.Color.Khaki;
            this.ShowAllCarsButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ShowAllCarsButt.Location = new System.Drawing.Point(126, 277);
            this.ShowAllCarsButt.Name = "ShowAllCarsButt";
            this.ShowAllCarsButt.Size = new System.Drawing.Size(203, 46);
            this.ShowAllCarsButt.TabIndex = 6;
            this.ShowAllCarsButt.Text = "Show All Cars";
            this.ShowAllCarsButt.UseVisualStyleBackColor = false;
            this.ShowAllCarsButt.Click += new System.EventHandler(this.ShowAllCarsButt_Click);
            // 
            // ShowAllReservations
            // 
            this.ShowAllReservations.BackColor = System.Drawing.Color.Khaki;
            this.ShowAllReservations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ShowAllReservations.Location = new System.Drawing.Point(126, 225);
            this.ShowAllReservations.Name = "ShowAllReservations";
            this.ShowAllReservations.Size = new System.Drawing.Size(203, 46);
            this.ShowAllReservations.TabIndex = 7;
            this.ShowAllReservations.Text = "Show All Reservations";
            this.ShowAllReservations.UseVisualStyleBackColor = false;
            this.ShowAllReservations.Click += new System.EventHandler(this.ShowAllReservations_Click);
            // 
            // AdminSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(468, 344);
            this.Controls.Add(this.ShowAllReservations);
            this.Controls.Add(this.ShowAllCarsButt);
            this.Controls.Add(this.ShowAllUsersButt);
            this.Controls.Add(this.DeleteCarButton);
            this.Controls.Add(this.DeleteUserButton);
            this.Controls.Add(this.CreateUserButton);
            this.Controls.Add(this.AdminLabel);
            this.Controls.Add(this.AddCarButton);
            this.Name = "AdminSpace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminSpace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddCarButton;
        private System.Windows.Forms.Label AdminLabel;
        private System.Windows.Forms.Button CreateUserButton;
        private System.Windows.Forms.Button DeleteUserButton;
        private System.Windows.Forms.Button DeleteCarButton;
        private System.Windows.Forms.Button ShowAllUsersButt;
        private System.Windows.Forms.Button ShowAllCarsButt;
        private System.Windows.Forms.Button ShowAllReservations;
    }
}