using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_správa_vozového_parku
{
    public partial class AdminSpace : Form
    {
        public AdminSpace()
        {
            InitializeComponent();
        }

        private void AddCarButton_Click(object sender, EventArgs e)
        {
            ADMIN___AddCar addcar = new ADMIN___AddCar();
            addcar.Show();
        }

        private void CreateUserButton_Click(object sender, EventArgs e)
        {
            RegForm registrationForm = new RegForm();
            registrationForm.Show();
        }

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            ADMIN___DeleteUser deluser = new ADMIN___DeleteUser();
            deluser.Show();
        }

        private void DeleteCarButton_Click(object sender, EventArgs e)
        {
            ADMIN___DeleteCar delcar = new ADMIN___DeleteCar();
            delcar.Show();
        }

        private void ShowAllUsersButt_Click(object sender, EventArgs e)
        {
            ADMIN___ShowAllUsers showuser = new ADMIN___ShowAllUsers();
            showuser.Show();
        }

        private void ShowAllCarsButt_Click(object sender, EventArgs e)
        {
            ADMIN___ShowAllCars showcars = new ADMIN___ShowAllCars();
            showcars.Show();
        }

        private void ShowAllReservations_Click(object sender, EventArgs e)
        {
            ADMIN___ShowAllReservations showreservations = new ADMIN___ShowAllReservations();
            showreservations.Show();
        }
    }
}
