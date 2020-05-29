namespace Projekt_správa_vozového_parku
{
    partial class ADMIN___ShowAllReservations
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
            this.NameOfUser = new System.Windows.Forms.ListBox();
            this.CarBox = new System.Windows.Forms.ListBox();
            this.AllReservLabel = new System.Windows.Forms.Label();
            this.DateBox = new System.Windows.Forms.ListBox();
            this.NameOfUserPast = new System.Windows.Forms.ListBox();
            this.CarBoxPast = new System.Windows.Forms.ListBox();
            this.DateBoxPast = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameOfUser
            // 
            this.NameOfUser.FormattingEnabled = true;
            this.NameOfUser.Location = new System.Drawing.Point(66, 135);
            this.NameOfUser.Name = "NameOfUser";
            this.NameOfUser.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.NameOfUser.Size = new System.Drawing.Size(120, 108);
            this.NameOfUser.TabIndex = 18;
            // 
            // CarBox
            // 
            this.CarBox.FormattingEnabled = true;
            this.CarBox.Location = new System.Drawing.Point(381, 135);
            this.CarBox.Name = "CarBox";
            this.CarBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.CarBox.Size = new System.Drawing.Size(120, 108);
            this.CarBox.TabIndex = 17;
            // 
            // AllReservLabel
            // 
            this.AllReservLabel.AutoSize = true;
            this.AllReservLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.AllReservLabel.Location = new System.Drawing.Point(162, 9);
            this.AllReservLabel.Name = "AllReservLabel";
            this.AllReservLabel.Size = new System.Drawing.Size(250, 39);
            this.AllReservLabel.TabIndex = 16;
            this.AllReservLabel.Text = "All reservations";
            // 
            // DateBox
            // 
            this.DateBox.FormattingEnabled = true;
            this.DateBox.Location = new System.Drawing.Point(224, 135);
            this.DateBox.Name = "DateBox";
            this.DateBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.DateBox.Size = new System.Drawing.Size(120, 108);
            this.DateBox.TabIndex = 15;
            // 
            // NameOfUserPast
            // 
            this.NameOfUserPast.FormattingEnabled = true;
            this.NameOfUserPast.Location = new System.Drawing.Point(66, 301);
            this.NameOfUserPast.Name = "NameOfUserPast";
            this.NameOfUserPast.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.NameOfUserPast.Size = new System.Drawing.Size(120, 95);
            this.NameOfUserPast.TabIndex = 21;
            // 
            // CarBoxPast
            // 
            this.CarBoxPast.FormattingEnabled = true;
            this.CarBoxPast.Location = new System.Drawing.Point(381, 301);
            this.CarBoxPast.Name = "CarBoxPast";
            this.CarBoxPast.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.CarBoxPast.Size = new System.Drawing.Size(120, 95);
            this.CarBoxPast.TabIndex = 20;
            // 
            // DateBoxPast
            // 
            this.DateBoxPast.FormattingEnabled = true;
            this.DateBoxPast.Location = new System.Drawing.Point(224, 301);
            this.DateBoxPast.Name = "DateBoxPast";
            this.DateBoxPast.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.DateBoxPast.Size = new System.Drawing.Size(120, 95);
            this.DateBoxPast.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.label1.Location = new System.Drawing.Point(234, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 36);
            this.label1.TabIndex = 22;
            this.label1.Text = "Future";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.label2.Location = new System.Drawing.Point(247, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 36);
            this.label2.TabIndex = 23;
            this.label2.Text = "Past";
            // 
            // ADMIN___ShowAllReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 445);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameOfUserPast);
            this.Controls.Add(this.CarBoxPast);
            this.Controls.Add(this.DateBoxPast);
            this.Controls.Add(this.NameOfUser);
            this.Controls.Add(this.CarBox);
            this.Controls.Add(this.AllReservLabel);
            this.Controls.Add(this.DateBox);
            this.Name = "ADMIN___ShowAllReservations";
            this.Text = "ADMIN___ShowAllReservations";
            this.Load += new System.EventHandler(this.ADMIN___ShowAllReservations_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox NameOfUser;
        private System.Windows.Forms.ListBox CarBox;
        private System.Windows.Forms.Label AllReservLabel;
        private System.Windows.Forms.ListBox DateBox;
        private System.Windows.Forms.ListBox NameOfUserPast;
        private System.Windows.Forms.ListBox CarBoxPast;
        private System.Windows.Forms.ListBox DateBoxPast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}