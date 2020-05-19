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
    public partial class ADMIN___DeleteCar : Form
    {
        public ADMIN___DeleteCar()
        {
            InitializeComponent();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string uid = CarDelete.Text;
            string path = @"data\administrator\cars" + uid + ".txt";
            string pathreservation = @"data\administrator\carsreserved\cars" + uid + "reservation.txt";
            if (File.Exists(path))
            {
                File.Delete(path);
                MessageBox.Show("Car is deleted!");
                if (File.Exists(pathreservation))
                {
                    File.Delete(pathreservation);
                }
            }
            else
            {
                MessageBox.Show("Car with that UID wasn't found.");
            }
        }
    }
}
