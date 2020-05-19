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
    public partial class ADMIN___ShowAllUsers : Form
    {
        public ADMIN___ShowAllUsers()
        {
            InitializeComponent();
        }

        private void ADMIN___ShowAllUsers_Load(object sender, EventArgs e)
        {
            string[] files = Directory.GetDirectories("data\\"); //načtu všechny jména která již existují         
            
            numberLabel.Text = "(" + files.Length.ToString() + ")";  //počet všech uživatelů        
            
            for (int i = 0; i < files.Length; i++) //osamostatním pouze jméno od data\ pro jedno z polí
            {
                files[i] = files[i].Remove(0, 5);
            }
            for (int i = 0; i < files.Length; i++)
            {
                Box.Items.Add(files[i]);
            }
        }

        private void numberLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //vynucená změna hesla
        {
            string thisUser = Box.SelectedItem.ToString();            

            string pathWhereUsersAre = "data\\";
            string path = System.IO.Path.Combine(pathWhereUsersAre, thisUser);

            string filename = "forcepass";

            path = System.IO.Path.Combine(path, filename);

            if (Directory.Exists("data\\" + thisUser))
            {
                using (System.IO.FileStream fs = System.IO.File.Create(path))
                {
                    
                }
                MessageBox.Show("Password change was forced.");
            }
            
            
            
            
        }
    }
}
