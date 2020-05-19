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
    public partial class NewReservation : Form
    {
        public NewReservation()
        {
            InitializeComponent();
        }

        private void NewReservation_Load(object sender, EventArgs e)
        {
            ItemsInSecond.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            string[] files = Directory.GetFiles("data\\administrator\\");  //get všech aut
            for (int i = 0; i < files.Length; i++)
            {
                files[i] = files[i].Remove(0, 19);
                files[i] = files[i].Replace(".txt", "");
            }
            for (int i = 0; i < files.Length - 1; i++) //-1 protože poslední je konfigurák pro admina
            {
                BoxUID.Items.Add(files[i]);  //add cars soubory
            }

        }

        private void BoxUID_DoubleClick(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles("data\\administrator\\"); //load all files
            string[] filesremoved = new string[files.Length];  //znovu inicializace pole filu, protože je chci zobrazit bez .txt
            for (int i = 0; i < files.Length; i++)
            {
                filesremoved[i] = files[i];  //nahrání všech jmen souborů do files co budou upraveny
            }

            for (int i = 0; i < filesremoved.Length; i++)
            {
                filesremoved[i] = filesremoved[i].Remove(0, 19);
                filesremoved[i] = filesremoved[i].Replace(".txt", "");  //smazání data\administrator a .txt ze stringu
            }
            for (int i = 0; i < filesremoved.Length; i++)
            {
                if (BoxUID.SelectedItem.ToString() == filesremoved[i])  //pokud selected item je stejný jako filesremoved
                {
                    ItemsInSecond.Items.Clear();
                    string[] InFile = File.ReadAllLines(files[i]);   //vezmeš daný soubor se stejným UID, který celý přečteš PO LINKÁCH - pole 
                    for (int a = 0; a < InFile.Length; a++)
                    {
                        ItemsInSecond.Items.Add(InFile[a]);     //nahraješ každý člen pole na zvláštní řádek v listu
                    }
                }
            }
        }

        private void SubmitReservation_Click(object sender, EventArgs e)
        {
            if (BoxUID.SelectedItem == null)
            {
                MessageBox.Show("Please double click car you want and choose day!");
                return;
            }

            string selectedCar = BoxUID.SelectedItem.ToString();  //selected item v boxu
            DateTime reservation = DatePicker.Value.Date;   //date který byl vybrán, ale bez času!
            string userName = Form1.NameOfUser;   //převzaté jméno

            string[] selectedCarWithoutTxt = selectedCar.Split('.');  //potřebuju název souboru bez .txt
            bool obsahuje = false;  //není termín již obsazen?

            if (File.Exists(@"data\\administrator\\carsreserved\\" + selectedCarWithoutTxt[0] + "reservation.txt") == false) //existuje soubor? Pokud ne, víme že jsou prázdné rezervace
            {
                obsahuje = false;             
            }
            else
            {
                var sr = new StreamReader("data\\administrator\\carsreserved\\" + selectedCarWithoutTxt[0] + "reservation.txt");  //readuju soubor s rezervací
                string contains = sr.ReadToEnd();
                if (contains.Contains(reservation.ToString())) //ověřuji, že v souboru nikde není stejný datum, jako který má v plánu uživatel zadat
                {
                    obsahuje = true;  //obsazeno = true
                }
                sr.Close();
            }

            if (obsahuje == true)  //je obsazeno true?
            {
                MessageBox.Show("I'm sorry, this car is already taken on your date.");
                return;
            }
            else
            {
                Directory.CreateDirectory("data\\administrator\\carsreserved");  //pro jistotu vytvářím adresář, když by se někdy smazal, at neni problem
                using (StreamWriter sw = File.AppendText("data\\administrator\\carsreserved\\" + selectedCarWithoutTxt[0] + "reservation.txt"))  //streamwriterem zapíšu vše potřebné
                {
                    sw.WriteLine(userName);
                    sw.WriteLine(reservation);
                    sw.WriteLine("");   //odděluji mezerou každou rezervaci
                    MessageBox.Show("Reservation was succesfull");
                }
            }
        }
    }
}
