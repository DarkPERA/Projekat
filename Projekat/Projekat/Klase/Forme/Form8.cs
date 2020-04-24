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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        static int i=0;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ime.Text = HeadAdministrator.Podaci.STUDENT[i].IME;
                prezime.Text = HeadAdministrator.Podaci.STUDENT[i].PREZIME;
                email.Text = HeadAdministrator.Podaci.STUDENT[i].EMAIL;
                brtel.Text = HeadAdministrator.Podaci.STUDENT[i].BRTELEFONA;
                id.Text = (HeadAdministrator.Podaci.STUDENT[i].INDEKS.BROJ).ToString();
                smer.Text = HeadAdministrator.Podaci.STUDENT[i].INDEKS.SMER;
                gu.Text = (HeadAdministrator.Podaci.STUDENT[i].INDEKS.GODINA_UPISA).ToString();
                gs.Text = (HeadAdministrator.Podaci.STUDENT[i].INDEKS.GODINA_STUDIJA).ToString();
                faks.Text = HeadAdministrator.Podaci.STUDENT[i].INDEKS.FAKULTET;
            }
            catch
            {
                ime.Text = "Ne postoji";
                prezime.Text = "Ne postoji";
                email.Text = "Ne postoji";
                brtel.Text = "Ne postoji";
                id.Text = "0";
                smer.Text = "Ne postoji";
                gu.Text = "0";
                gs.Text = "0";
                faks.Text = "Ne postoji";
            }
            i++;
            if (i > (HeadAdministrator.Podaci.STUDENT.Count - 1))
                i = HeadAdministrator.Podaci.STUDENT.Count - 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i--;
            if (i < 0)
                i = 0;
            try
            {
                ime.Text = HeadAdministrator.Podaci.STUDENT[i].IME;
                prezime.Text = HeadAdministrator.Podaci.STUDENT[i].PREZIME;
                email.Text = HeadAdministrator.Podaci.STUDENT[i].EMAIL;
                brtel.Text = HeadAdministrator.Podaci.STUDENT[i].BRTELEFONA;
                id.Text = (HeadAdministrator.Podaci.STUDENT[i].INDEKS.BROJ).ToString();
                smer.Text = HeadAdministrator.Podaci.STUDENT[i].INDEKS.SMER;
                gu.Text = (HeadAdministrator.Podaci.STUDENT[i].INDEKS.GODINA_UPISA).ToString();
                gs.Text = (HeadAdministrator.Podaci.STUDENT[i].INDEKS.GODINA_STUDIJA).ToString();
                faks.Text = HeadAdministrator.Podaci.STUDENT[i].INDEKS.FAKULTET;
            }
            catch
            {
                ime.Text = "Ne postoji";
                prezime.Text = "Ne postoji";
                email.Text = "Ne postoji";
                brtel.Text = "Ne postoji";
                id.Text = "0";
                      smer.Text = "Ne postoji";
                gu.Text = "0";
                gs.Text = "0";
                        faks.Text = "Ne postoji";
            }
        }

        private void bris_Click(object sender, EventArgs e)
        {
            try
            {
                if (HeadAdministrator.Podaci.STUDENT[i].OBRISAN == true)
                {
                    MessageBox.Show("Clan je vec obrisan");
                }
                else
                {
                    switch (Program.Ulogovani)
                    {
                        case true:
                            Program.headadmin.Brisni_Stud(HeadAdministrator.Podaci.STUDENT[i]);
                            break;
                        case false:
                            Program.admin.Brisni_Stud(HeadAdministrator.Podaci.STUDENT[i]);
                            break;
                    }
                    File.Delete(@"D:\Projekat\Studenti\" + HeadAdministrator.Podaci.STUDENT[i].USERNAME + ".txt");
                    HeadAdministrator.Podaci.USERSTUD.RemoveAt(HeadAdministrator.Podaci.USERSTUD.BinarySearch(HeadAdministrator.Podaci.STUDENT[i].USERNAME));
                    MessageBox.Show("Obrisan!");
                }
            }
            catch
            {
                MessageBox.Show("Birate nepostojeceg korisnika");
            }
            
        }

        private void Form8_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
