using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SHA256_name;
using System.IO;

namespace Projekt_správa_vozového_parku
{
    public partial class Form1 : Form
    {
        public static string NameOfUser;  // definuji, abych jméno mohl použít všude
        public Form1()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e) // show form registrace
        {
            RegForm registrationForm = new RegForm();
            registrationForm.Show();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (TextboxUsername.Text == "" || TextboxUsername.Text == " " || TextboxPassword.Text.Length < 6) // check jestli heslo a text jsou validní
            {
                MessageBox.Show("Username or Password is in wrong format!");
            }
            else
            {
                string dir = TextboxUsername.Text; // vezmu username, hledám jestli bude existovat adresář 
                if (!Directory.Exists("data\\" + dir))
                {
                    MessageBox.Show("Username was not found");
                }
                else
                {
                    var sr = new StreamReader("data\\" + dir + "\\data.ls"); // jestliže existuje, přečtu data z něj

                    string HashUserFile = sr.ReadLine();
                    string HashPassFile = sr.ReadLine();
                    sr.Close();

                    if (HashUserFile == SHA256_name.HashUser.GetStringSha256Hash(TextboxUsername.Text) && HashPassFile == SHA256_name.HashUser.GetStringSha256Hash(TextboxPassword.Text))
                    {                                                                       //zjišťuju jestli hashe v souboru a v loginu souhlasí
                        MessageBox.Show("Succesfull login");
                        using (StreamWriter sw = File.AppendText("data\\" + dir + "\\data.ls")) //na konec souboru zapíšu date loginu
                        {
                            sw.WriteLine(DateTime.Now);
                        }
                        NameOfUser = TextboxUsername.Text;    //definuji jaké je jmeno uživatele pro další formy
                        if (NameOfUser == "administrator")
                        {
                            AdminSpace AdminSpaceForm = new AdminSpace();  //pokud jsem admin, dostanu adminlogin
                            AdminSpaceForm.Show();
                        }
                        else   //user login
                        {
                            string pathtoforcepass = "data\\" + dir + "\\forcepass";
                            if (File.Exists(pathtoforcepass))  //forcepass od admina
                            {
                                MessageBox.Show("I´m sorry, you have to change your password. After you change your password login again with new one.");
                                ChangePass changepass = new ChangePass();
                                changepass.Show();    // new pass open                    
                            }
                            else
                            {
                                UserSpace UserSpaceForm = new UserSpace();
                                UserSpaceForm.Show();                  // Userspace open
                            }
                        }
                        TextboxUsername.Clear();                //vyčistím uvodní login
                        TextboxPassword.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Error - user or password is wrong!");
                    }
                }
            }
        }
    }
}
