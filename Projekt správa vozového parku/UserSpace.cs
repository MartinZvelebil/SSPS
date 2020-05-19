using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Projekt_správa_vozového_parku
{
    public partial class UserSpace : Form
    {
        public UserSpace()
        {
            InitializeComponent();
        }

        private void Logout_button_Click(object sender, EventArgs e)
        {          
            this.Close();
        }

        private void ChangePasssButton_Click(object sender, EventArgs e) 
        {
            ChangePass Changepassform = new ChangePass();
            Changepassform.Show();
        }

        private void UserSpace_Load(object sender, EventArgs e)
        {
            WelcomeLabel.Text = "Welcome " + Form1.NameOfUser;                                 // Label pro vítání uživatele s jeho jménem
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewReservation reservationForm = new NewReservation();
            reservationForm.Show();
        }

        private void ShowUserReservation_Click(object sender, EventArgs e)
        {
            ShowMyReservations showres = new ShowMyReservations();
            showres.Show();
        }

        private void CancelReservButt_Click(object sender, EventArgs e)
        {
            ShowMyReservations showres = new ShowMyReservations();
            showres.Show();
        }
        
    }
}
