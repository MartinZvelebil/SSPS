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
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void RegForm_Load(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string[] files = Directory.GetDirectories("data\\"); //načtu všechny jména která již existují
            for (int i = 0; i < files.Length; i++)
            {
                if (files[i] == @"data\" + TextboxUsername.Text)  //jestliže jméno již existuje donutím uživatele znovu vymyslet jiné
                {
                    MessageBox.Show("Username is already TAKEN!");
                    Application.Exit();
                }
            }
            {
                if (TextboxUsername.Text == "" || TextboxUsername.Text == " " || TextboxPassword.Text.Length < 6)
                {
                    MessageBox.Show("Username or Password is in wrong format!");
                }
                else
                {
                    string dir = TextboxUsername.Text;
                    Directory.CreateDirectory("data\\" + dir);
                    var sw = new StreamWriter("data\\" + dir + "\\data.ls");
                    string hashUsername = SHA256_name.HashUser.GetStringSha256Hash(TextboxUsername.Text);
                    string hashPassword = SHA256_name.HashUser.GetStringSha256Hash(TextboxPassword.Text);
                    sw.WriteLine(hashUsername);
                    sw.WriteLine(hashPassword);
                    sw.Close();
                    MessageBox.Show("Account was successfully created.", TextboxUsername.Text);
                    this.Close();
                }
            }
        }
    }
}
