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
    public partial class ADMIN___DeleteUser : Form
    {
        public ADMIN___DeleteUser()
        {
            InitializeComponent();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string name = UserNameDelete.Text;
            string path = "data\\" + name;
            if (Directory.Exists(path))
            {
                Directory.Delete(path,true);
                MessageBox.Show("User is deleted!");
            }
            else
            {
                MessageBox.Show("User wasn't found.");
            }  
        }
    }
}
