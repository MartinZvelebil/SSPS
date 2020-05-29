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
    public partial class ADMIN___ShowAllCars : Form
    {
        public ADMIN___ShowAllCars()
        {
            InitializeComponent();
        }

        private void ADMIN___ShowAllCars_Load(object sender, EventArgs e)
        {
            ItemsInSecond.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            string[] files = Directory.GetFiles("data\\administrator\\");
            for (int i = 0; i < files.Length; i++)
            {
                files[i] = files[i].Remove(0, 19);
            }
            for (int i = 0; i < files.Length - 1; i++) //-1 protože poslední je konfigurák pro admina
            {
                BoxUID.Items.Add(files[i]);
            }
            BoxUID.SelectedIndex = 0;
        }

        private void BoxUID_Click(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles("data\\administrator\\"); //load all files
            string[] filesremoved = new string[files.Length];
            for (int i = 0; i < files.Length; i++)
            {
                filesremoved[i] = files[i];
            }

            for (int i = 0; i < filesremoved.Length; i++)
            {
                filesremoved[i] = filesremoved[i].Remove(0, 19);
            }
            for (int i = 0; i < filesremoved.Length; i++)
            {
                if (BoxUID.SelectedItem.ToString() == filesremoved[i])
                {
                    ItemsInSecond.Items.Clear();
                    string[] InFile = File.ReadAllLines(files[i]);
                    for (int a = 0; a < InFile.Length; a++)
                    {
                        ItemsInSecond.Items.Add(InFile[a]);
                    }
                }
            }
        }
    }
}
