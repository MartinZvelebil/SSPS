namespace Projekt_správa_vozového_parku
{
    partial class ShowMyReservations
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
            this.DateBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CarBox = new System.Windows.Forms.ListBox();
            this.WhatIsThatCarBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DeleteSelectedReservation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DateBox
            // 
            this.DateBox.FormattingEnabled = true;
            this.DateBox.Location = new System.Drawing.Point(26, 94);
            this.DateBox.Name = "DateBox";
            this.DateBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.DateBox.Size = new System.Drawing.Size(120, 277);
            this.DateBox.TabIndex = 0;
            this.DateBox.DoubleClick += new System.EventHandler(this.DateBox_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.label1.Location = new System.Drawing.Point(98, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reservation Management";
            // 
            // CarBox
            // 
            this.CarBox.FormattingEnabled = true;
            this.CarBox.Location = new System.Drawing.Point(209, 94);
            this.CarBox.Name = "CarBox";
            this.CarBox.Size = new System.Drawing.Size(120, 277);
            this.CarBox.TabIndex = 2;
            this.CarBox.Click += new System.EventHandler(this.CarBox_Click);
            // 
            // WhatIsThatCarBox
            // 
            this.WhatIsThatCarBox.FormattingEnabled = true;
            this.WhatIsThatCarBox.Location = new System.Drawing.Point(387, 94);
            this.WhatIsThatCarBox.Name = "WhatIsThatCarBox";
            this.WhatIsThatCarBox.Size = new System.Drawing.Size(120, 277);
            this.WhatIsThatCarBox.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(348, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Cost:";
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(330, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "l / 100km";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Type:";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Model:";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Brand:";
            this.label2.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(353, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "UID:";
            this.label7.Visible = false;
            // 
            // DeleteSelectedReservation
            // 
            this.DeleteSelectedReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.DeleteSelectedReservation.Location = new System.Drawing.Point(274, 392);
            this.DeleteSelectedReservation.Name = "DeleteSelectedReservation";
            this.DeleteSelectedReservation.Size = new System.Drawing.Size(246, 34);
            this.DeleteSelectedReservation.TabIndex = 15;
            this.DeleteSelectedReservation.Text = "Delete selected one";
            this.DeleteSelectedReservation.UseVisualStyleBackColor = true;
            this.DeleteSelectedReservation.Click += new System.EventHandler(this.DeleteSelectedReservation_Click);
            // 
            // ShowMyReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 438);
            this.Controls.Add(this.DeleteSelectedReservation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.WhatIsThatCarBox);
            this.Controls.Add(this.CarBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateBox);
            this.Name = "ShowMyReservations";
            this.Text = "ShowMyReservations";
            this.Load += new System.EventHandler(this.ShowMyReservations_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox DateBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox CarBox;
        private System.Windows.Forms.ListBox WhatIsThatCarBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button DeleteSelectedReservation;
    }
}