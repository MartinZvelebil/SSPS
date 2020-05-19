namespace Projekt_správa_vozového_parku
{
    partial class UserSpace
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
            this.Logout_button = new System.Windows.Forms.Button();
            this.ChangePasssButton = new System.Windows.Forms.Button();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.NewReservationButt = new System.Windows.Forms.Button();
            this.ShowUserReservation = new System.Windows.Forms.Button();
            this.CancelReservButt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Logout_button
            // 
            this.Logout_button.BackColor = System.Drawing.Color.Red;
            this.Logout_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Logout_button.Location = new System.Drawing.Point(12, 36);
            this.Logout_button.Name = "Logout_button";
            this.Logout_button.Size = new System.Drawing.Size(149, 34);
            this.Logout_button.TabIndex = 0;
            this.Logout_button.Text = "Log out";
            this.Logout_button.UseVisualStyleBackColor = false;
            this.Logout_button.Click += new System.EventHandler(this.Logout_button_Click);
            // 
            // ChangePasssButton
            // 
            this.ChangePasssButton.BackColor = System.Drawing.Color.Red;
            this.ChangePasssButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.ChangePasssButton.Location = new System.Drawing.Point(167, 36);
            this.ChangePasssButton.Name = "ChangePasssButton";
            this.ChangePasssButton.Size = new System.Drawing.Size(149, 34);
            this.ChangePasssButton.TabIndex = 1;
            this.ChangePasssButton.Text = "Change password";
            this.ChangePasssButton.UseVisualStyleBackColor = false;
            this.ChangePasssButton.Click += new System.EventHandler(this.ChangePasssButton_Click);
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.WelcomeLabel.Location = new System.Drawing.Point(12, 9);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(96, 24);
            this.WelcomeLabel.TabIndex = 2;
            this.WelcomeLabel.Text = "Welcome ";
            // 
            // NewReservationButt
            // 
            this.NewReservationButt.BackColor = System.Drawing.Color.OliveDrab;
            this.NewReservationButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.NewReservationButt.Location = new System.Drawing.Point(153, 188);
            this.NewReservationButt.Name = "NewReservationButt";
            this.NewReservationButt.Size = new System.Drawing.Size(163, 34);
            this.NewReservationButt.TabIndex = 3;
            this.NewReservationButt.Text = "New reservation";
            this.NewReservationButt.UseVisualStyleBackColor = false;
            this.NewReservationButt.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShowUserReservation
            // 
            this.ShowUserReservation.BackColor = System.Drawing.Color.Khaki;
            this.ShowUserReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.ShowUserReservation.Location = new System.Drawing.Point(116, 228);
            this.ShowUserReservation.Name = "ShowUserReservation";
            this.ShowUserReservation.Size = new System.Drawing.Size(200, 34);
            this.ShowUserReservation.TabIndex = 4;
            this.ShowUserReservation.Text = "Show my reservations";
            this.ShowUserReservation.UseVisualStyleBackColor = false;
            this.ShowUserReservation.Click += new System.EventHandler(this.ShowUserReservation_Click);
            // 
            // CancelReservButt
            // 
            this.CancelReservButt.BackColor = System.Drawing.Color.Khaki;
            this.CancelReservButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.CancelReservButt.Location = new System.Drawing.Point(12, 228);
            this.CancelReservButt.Name = "CancelReservButt";
            this.CancelReservButt.Size = new System.Drawing.Size(74, 34);
            this.CancelReservButt.TabIndex = 5;
            this.CancelReservButt.Text = "Cancel ";
            this.CancelReservButt.UseVisualStyleBackColor = false;
            this.CancelReservButt.Click += new System.EventHandler(this.CancelReservButt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(95, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "/";
            // 
            // UserSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(328, 274);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelReservButt);
            this.Controls.Add(this.ShowUserReservation);
            this.Controls.Add(this.NewReservationButt);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.ChangePasssButton);
            this.Controls.Add(this.Logout_button);
            this.Name = "UserSpace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserSpace";
            this.Load += new System.EventHandler(this.UserSpace_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Logout_button;
        private System.Windows.Forms.Button ChangePasssButton;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button NewReservationButt;
        private System.Windows.Forms.Button ShowUserReservation;
        private System.Windows.Forms.Button CancelReservButt;
        private System.Windows.Forms.Label label1;
    }
}