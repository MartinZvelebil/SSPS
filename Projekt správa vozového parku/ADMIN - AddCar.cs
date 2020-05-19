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
    public partial class ADMIN___AddCar : Form
    {
        public ADMIN___AddCar()
        {
            InitializeComponent();
        }

        private void AddCarButton_Click(object sender, EventArgs e)
        {
            decimal uid = UIDValue.Value;
            string brand = BrandTextBox.Text;
            string model = ModelTextBox.Text;
            string type = TypeTextBox.Text;
            decimal litres = LitresNumericBox.Value;
            decimal cost = CostValueBox.Value;

            bool ok = true;
            if (brand == "" || model == "" || type == "" || brand == " " || model == " " || type == " ") // check jestli heslo a text jsou validní
            {
                MessageBox.Show("Please fill all text informations!");
                ok = false;
            }
            else if (litres == 0)
            {
                MessageBox.Show("Please fill average consumption!");
                ok = false;
            }
            else
            {
                string[] files = Directory.GetFiles("data\\administrator"); //načtu všechny jména která již existují
                for (int i = 0; i < files.Length; i++)
                {
                   // MessageBox.Show(files[i]);
                    if (files[i] == @"data\administrator\cars" + uid + ".txt")  //jestliže jméno již existuje donutím uživatele znovu vymyslet jiné
                    {
                        MessageBox.Show("This UID is already taken. Please choose other one for your car.");
                        ok = false;
                    }                   
                }                           
            }
            if (ok == true)
            {
                var sw = new StreamWriter("data\\administrator\\cars" + uid + ".txt");
                sw.WriteLine(uid);
                sw.WriteLine(brand);
                sw.WriteLine(model);
                sw.WriteLine(type);
                sw.WriteLine(litres);
                sw.WriteLine(cost);
                sw.Close();
                MessageBox.Show("Car was succesfully added!");
                this.Close();
            }           
        }
    }
}

