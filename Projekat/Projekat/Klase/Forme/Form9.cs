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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        static int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ime.Text = HeadAdministrator.Podaci.PROFESOR[i].IME;
                prezime.Text = HeadAdministrator.Podaci.PROFESOR[i].PREZIME;
                email.Text = HeadAdministrator.Podaci.PROFESOR[i].EMAIL;
                zvanje.Text = HeadAdministrator.Podaci.PROFESOR[i].ZVANJE;
            }
            catch
            {
                prezime.Text = "Ne postoji";
                ime.Text = "Ne postoji";
                zvanje.Text = "Ne postoji";
                email.Text = "Ne postoji";
            }
            if (i == HeadAdministrator.Podaci.PROFESOR.Count)
                i = HeadAdministrator.Podaci.PROFESOR.Count - 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i--;
            if (i < 0)
                i = 0;
            try
            {
                ime.Text = HeadAdministrator.Podaci.PROFESOR[i].IME;
                prezime.Text = HeadAdministrator.Podaci.PROFESOR[i].PREZIME;
                email.Text = HeadAdministrator.Podaci.PROFESOR[i].EMAIL;
                zvanje.Text = HeadAdministrator.Podaci.PROFESOR[i].ZVANJE;
            }
            catch
            {
                prezime.Text = "Ne postoji";
                ime.Text = "Ne postoji";
                zvanje.Text = "Ne postoji";
                email.Text = "Ne postoji";
            }
        }

        private void bris_Click(object sender, EventArgs e)
        {
            try
            {
                if (HeadAdministrator.Podaci.PROFESOR[i].OBRISAN == true)
                {
                    MessageBox.Show("Clan je vec obrisan");
                }
                else
                {
                    switch (Program.Ulogovani)
                    {
                        case true:
                            Program.headadmin.Brisni_Prof(HeadAdministrator.Podaci.PROFESOR[i]);
                            break;
                        case false:
                            Program.admin.Brisni_Prof(HeadAdministrator.Podaci.PROFESOR[i]);
                            break;
                    }
                    File.Delete(@"D:\Projekat\Profesori\" + HeadAdministrator.Podaci.PROFESOR[i].USERNAME + ".txt");
                    HeadAdministrator.Podaci.USERPROF.RemoveAt(HeadAdministrator.Podaci.USERPROF.BinarySearch(HeadAdministrator.Podaci.PROFESOR[i].USERNAME));
                    MessageBox.Show("Obrisan!");
                }
            }
            catch
            {
                MessageBox.Show("Birate nepostojeceg korisnika");
            }
        }

        private void Form9_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Da li zaista zelite da izadjete?", "Exit", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {

                Program.ispis_u_listu();
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.Show();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }
    }
}
