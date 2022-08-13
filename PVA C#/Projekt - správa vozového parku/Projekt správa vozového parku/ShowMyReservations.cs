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
    public partial class ShowMyReservations : Form
    {
        public ShowMyReservations()
        {
            InitializeComponent();
        }

        private void DateBox_DoubleClick(object sender, EventArgs e)
        {

        }

        private void ShowMyReservations_Load(object sender, EventArgs e)
        {

            string[] files = Directory.GetFiles("data\\administrator\\carsreserved\\"); //load all files
            string username = Form1.NameOfUser;

            string[] filesremoved = new string[files.Length];  //znovu inicializace pole filu, protože je chci zobrazit bez .txt
            for (int i = 0; i < files.Length; i++)
            {
                filesremoved[i] = files[i];  //nahrání všech jmen souborů do files co budou upraveny
            }

            for (int i = 0; i < filesremoved.Length; i++)
            {
                filesremoved[i] = filesremoved[i].Remove(0, 32).Replace("reservation.txt", ""); //smazání data\administrator a .txt ze stringu  
            }




            for (int i = 0; i < files.Length; i++)
            {
                string[] InFile = File.ReadAllLines(files[i]);
                for (int a = 0; a < InFile.Length; a++)
                {
                    if (InFile[a] == username)
                    {
                        bool jetamdatum = false;
                        int datumcount = 1;
                        while (jetamdatum == false)
                        {
                            if (DateTime.TryParse(InFile[a + datumcount], out DateTime result))
                            {
                                DateBox.Items.Add(InFile[a + datumcount].Replace("0:00:00", ""));
                                CarBox.Items.Add(filesremoved[i]);
                                datumcount++;
                            }
                            else
                            {
                                jetamdatum = true;
                            }
                        }
                    }
                }
            }
            CarBox.SelectedIndex = 0;
            MessageBox.Show("Warning: If you delete one day of your more day reservation, whole reservation will delete!");
           
        }

        private void DeleteSelectedReservation_Click(object sender, EventArgs e)
        {

            if (CarBox.SelectedItem == null)
            {
                MessageBox.Show("Choose car to remove please!");
                return;
            }
            var selectedDate = DateBox.Items[CarBox.SelectedIndex].ToString();
            string selectedCar = CarBox.SelectedItem.ToString();

            string[] filesReserved = Directory.GetFiles("data\\administrator\\carsreserved\\"); //load all files of RESERVED


            for (int i = 0; i < filesReserved.Length; i++)
            {
                if (filesReserved[i].Contains(selectedCar))
                {
                    string[] AllLines = File.ReadAllLines(filesReserved[i]);
                    for (int a = 0; a < AllLines.Length; a++)
                    {
                        bool jetamjmeno = false;
                        int datumcount = 1;
                        if (AllLines[a].Contains(selectedDate))  //najdeme v souboru datum!
                        {
                            while (jetamjmeno == false)  //find name
                            {
                                if (DateTime.TryParse(AllLines[a - datumcount], out DateTime result))  //pokud je to datetime, hledáme dál nahoru jmeno
                                {
                                    datumcount++;
                                    continue;
                                }
                                else  //je to jmeno
                                {
                                    jetamjmeno = true;
                                    if (AllLines[a - datumcount] != "") //vymazat jmeno
                                    {
                                        while (AllLines[a - datumcount] != "") //postupujeme dál dolu a hledáme, kde končí daná rezervace ("")
                                        {
                                            AllLines[a - datumcount] = "";
                                            datumcount--;
                                        }
                                    }
                                }
                            }
                        }
                    }


                    using (StreamWriter sw = new StreamWriter(filesReserved[i]))
                    {
                        for (int a = 0; a < AllLines.Length; a++)
                        {
                            sw.WriteLine(AllLines[a]);
                        }
                    }
                }
            }
            ShowMyReservations.ActiveForm.Dispose();
            ShowMyReservations sd = new ShowMyReservations();
            sd.Show();
        }

        private void CarBox_Click(object sender, EventArgs e)
        {
            label7.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            string[] files = Directory.GetFiles("data\\administrator\\carsreserved\\"); //load all files of RESERVED
            string[] filesUnreserved = Directory.GetFiles("data\\administrator\\");  // fily o autech, jejich vlastnosti

            string[] filesremoved = new string[filesUnreserved.Length];
            for (int i = 0; i < filesUnreserved.Length; i++)
            {
                filesremoved[i] = filesUnreserved[i];
            }

            for (int i = 0; i < filesremoved.Length; i++)
            {
                filesremoved[i] = filesremoved[i].Remove(0, 19).Replace(".txt", "");
            }
            //skoro stejné jako v showAllCars
            for (int i = 0; i < filesremoved.Length; i++)
            {
                if (CarBox.SelectedItem.ToString() == filesremoved[i])
                {
                    WhatIsThatCarBox.Items.Clear();
                    string[] InFile = File.ReadAllLines(filesUnreserved[i]);

                    for (int a = 0; a < InFile.Length; a++)
                    {
                        WhatIsThatCarBox.Items.Add(InFile[a]);
                    }
                }
            }
        }
    }
}
