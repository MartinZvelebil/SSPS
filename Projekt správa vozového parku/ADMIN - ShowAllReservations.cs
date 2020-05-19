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
    public partial class ADMIN___ShowAllReservations : Form
    {
        public ADMIN___ShowAllReservations()
        {
            InitializeComponent();
        }

        private void ADMIN___ShowAllReservations_Load(object sender, EventArgs e)
        {

            string[] files = Directory.GetFiles("data\\administrator\\carsreserved\\"); //load all files
            string[] users = Directory.GetDirectories("data\\");

            for (int i = 0; i < users.Length; i++)
            {
                users[i] = users[i].Remove(0, 5); //smazání data\\ z jmen lidí 
            }


            string[] filesremoved = new string[files.Length];  //znovu inicializace pole filu, protože je chci zobrazit bez .txt
            for (int i = 0; i < files.Length; i++)
            {
                filesremoved[i] = files[i];  //nahrání všech jmen souborů do files co budou upraveny
            }

            for (int i = 0; i < filesremoved.Length; i++)
            {
                filesremoved[i] = filesremoved[i].Remove(0, 32).Replace("reservation.txt", ""); //smazání data\administrator a .txt ze stringu  
            }

            DateTime now = DateTime.Now.Date;

            for (int i = 0; i < files.Length; i++)
            {
                string[] InFile = File.ReadAllLines(files[i]);
                for (int a = 0; a < InFile.Length; a++)
                {
                    for (int b = 0; b < users.Length; b++)
                    {
                        if (InFile[a] == users[b])
                        {

                            if (DateTime.Compare(DateTime.Parse(InFile[a + 1].Replace("0:00:00", "").Replace(". ", "-")), now) < 0) //starší než dnešní datum
                            {
                                NameOfUserPast.Items.Add(users[b]);

                                DateBoxPast.Items.Add(InFile[a + 1].Replace("0:00:00", ""));

                                CarBoxPast.Items.Add(filesremoved[i]);
                            }
                            else  //je aktuální a platná rezervace
                            {
                                NameOfUser.Items.Add(users[b]);

                                DateBox.Items.Add(InFile[a + 1].Replace("0:00:00", ""));

                                CarBox.Items.Add(filesremoved[i]);
                            }
                        }
                    }
                }
            }
        }
    }
}
