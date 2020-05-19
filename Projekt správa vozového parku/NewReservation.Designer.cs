namespace Projekt_správa_vozového_parku
{
    partial class NewReservation
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
            this.WhenLabel = new System.Windows.Forms.Label();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ItemsInSecond = new System.Windows.Forms.ListBox();
            this.BoxUID = new System.Windows.Forms.ListBox();
            this.SubmitReservation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WhatCarLabel
            // 
            this.WhatCarLabel.AutoSize = true;
            this.WhatCarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.WhatCarLabel.Location = new System.Drawing.Point(167, 40);
            this.WhatCarLabel.Name = "WhatCarLabel";
            this.WhatCarLabel.Size = new System.Drawing.Size(321, 36);
            this.WhatCarLabel.TabIndex = 0;
            this.WhatCarLabel.Text = "What car do you want?";
            // 
            // WhenLabel
            // 
            this.WhenLabel.AutoSize = true;
            this.WhenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.WhenLabel.Location = new System.Drawing.Point(167, 368);
            this.WhenLabel.Name = "WhenLabel";
            this.WhenLabel.Size = new System.Drawing.Size(304, 36);
            this.WhenLabel.TabIndex = 1;
            this.WhenLabel.Text = "When do you want it?";
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(215, 407);
            this.DatePicker.MinDate = new System.DateTime(2020, 5, 14, 0, 0, 0, 0);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(200, 20);
            this.DatePicker.TabIndex = 2;
            this.DatePicker.Value = new System.DateTime(2020, 5, 14, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(333, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Cost:";
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "l / 100km";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Type:";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Model:";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Brand:";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "UID:";
            this.label1.Visible = false;
            // 
            // ItemsInSecond
            // 
            this.ItemsInSecond.FormattingEnabled = true;
            this.ItemsInSecond.Location = new System.Drawing.Point(374, 91);
            this.ItemsInSecond.Name = "ItemsInSecond";
            this.ItemsInSecond.Size = new System.Drawing.Size(120, 251);
            this.ItemsInSecond.TabIndex = 10;
            this.ItemsInSecond.Visible = false;
            // 
            // BoxUID
            // 
            this.BoxUID.FormattingEnabled = true;
            this.BoxUID.Location = new System.Drawing.Point(134, 91);
            this.BoxUID.Name = "BoxUID";
            this.BoxUID.Size = new System.Drawing.Size(120, 251);
            this.BoxUID.TabIndex = 9;
            this.BoxUID.DoubleClick += new System.EventHandler(this.BoxUID_DoubleClick);
            // 
            // SubmitReservation
            // 
            this.SubmitReservation.Location = new System.Drawing.Point(251, 447);
            this.SubmitReservation.Name = "SubmitReservation";
            this.SubmitReservation.Size = new System.Drawing.Size(121, 33);
            this.SubmitReservation.TabIndex = 17;
            this.SubmitReservation.Text = "Send Reservation";
            this.SubmitReservation.UseVisualStyleBackColor = true;
            this.SubmitReservation.Click += new System.EventHandler(this.SubmitReservation_Click);
            // 
            // NewReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 507);
            this.Controls.Add(this.SubmitReservation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ItemsInSecond);
            this.Controls.Add(this.BoxUID);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.WhenLabel);
            this.Controls.Add(this.WhatCarLabel);
            this.Name = "NewReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewReservation";
            this.Load += new System.EventHandler(this.NewReservation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WhatCarLabel;
        private System.Windows.Forms.Label WhenLabel;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ItemsInSecond;
        private System.Windows.Forms.ListBox BoxUID;
        private System.Windows.Forms.Button SubmitReservation;
    }
}