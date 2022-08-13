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
using System.Security.Cryptography;
using SHA256_name;

namespace Projekt_správa_vozového_parku
{
    public partial class ChangePass : Form
    {
        public ChangePass()
        {
            InitializeComponent();
        }

        private void Changepasswordbutton_Click(object sender, EventArgs e)
        {
            string dir = Form1.NameOfUser;   //získávám uživatele jméno, kvůli adresáři kde má soubor

            string pathtoforcepass = "data\\" + dir + "\\forcepass";
            if (File.Exists(pathtoforcepass))  //forcepass od admina
            {
                File.Delete(pathtoforcepass); //delete if exists, bcs jsi právě změnil heslo                 
            }

            var sr = new StreamReader("data\\" + dir + "\\data.ls");  //getneme hashe které tam dříve byly - pass a username
            string HashUserFile = sr.ReadLine();           
            string HashPassFile = sr.ReadLine();
            sr.Close();
            var lastLine = File.ReadLines("data\\" + dir + "\\data.ls").Last(); //získám na poslední řádce poslední login

            if (NewPassText.Text.Length < 6)
            {
                MessageBox.Show("Your new password is too weak");
            }
            else if (NewPassText.Text==OldPassText.Text)
            {
                MessageBox.Show("Old password is the same as the new one.");
            }
            else if (HashPassFile != SHA256_name.HashUser.GetStringSha256Hash(OldPassText.Text)) //pokus jestli doopravdy zadává uživatel správné staré heslo
            {
                MessageBox.Show("Old password is wrong! Try again");               
            }
            else
            {                
                Directory.CreateDirectory("data\\" + dir);  //probably not potřeba
                var sw = new StreamWriter("data\\" + dir + "\\data.ls");          
                string hashNewPassword = SHA256_name.HashUser.GetStringSha256Hash(NewPassText.Text);  //zahashuju nové heslo
                sw.WriteLine(HashUserFile);
                sw.WriteLine(hashNewPassword);
                sw.WriteLine(lastLine); //zapíšu čas posledního loginu
                sw.Close();
                MessageBox.Show("Password change succesfull!");              
                this.Close();
            }
        }
    }
}

