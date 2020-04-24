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

namespace Projekat.Klase.Forme
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        static int i = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            i--;
            if (i < 0)
                i = 0;
            try
            {
                ime.Text = HeadAdministrator.Podaci.ADMIN[i].IME;
                prezime.Text = HeadAdministrator.Podaci.ADMIN[i].PREZIME;
            }
            catch
            {
                ime.Text = "Ne postoji";
                prezime.Text = "Ne postoji";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                ime.Text = HeadAdministrator.Podaci.ADMIN[i].IME;
                prezime.Text = HeadAdministrator.Podaci.ADMIN[i].PREZIME;
            }
            catch
            {
                ime.Text = "Ne postoji";
                prezime.Text = "Ne postoji";
            }
            i++;
            if (i == HeadAdministrator.Podaci.ADMIN.Count)
                i = HeadAdministrator.Podaci.ADMIN.Count - 1;
        }

        private void bris_Click(object sender, EventArgs e)
        {
            try
            {
                if (HeadAdministrator.Podaci.ADMIN[i].OBRISAN == true)
                {
                    MessageBox.Show("Clan je vec obrisan");
                }
                else
                {


                    Program.headadmin.Brisni_Admin(HeadAdministrator.Podaci.ADMIN[i]);
                    File.Delete(@"D:\Projekat\Admini\" + HeadAdministrator.Podaci.ADMIN[i].USERNAME + ".txt");
                    HeadAdministrator.Podaci.USERADMIN.RemoveAt(HeadAdministrator.Podaci.USERADMIN.BinarySearch(HeadAdministrator.Podaci.ADMIN[i].USERNAME));
                    MessageBox.Show("Obrisan!");

                }
            }
            catch
            {
                MessageBox.Show("Birate nepostojeceg korisnika");
            }
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.Show();
        }
    }
}
