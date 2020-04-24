using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projekat.Klase;
using Projekat.Klase.Forme;
using System.IO;


namespace Projekat.Klase.Forme
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((File.Exists(@"D:\Projekat\Studenti\" + use.Text + ".txt") == false) && (Program.privremena.Contains(use.Text) == false))
            {


                if ((pasrep.Text == pas.Text) && (String.IsNullOrWhiteSpace(pasrep.Text) == false) && (String.IsNullOrWhiteSpace(pas.Text) == false))
                {
                    if ((String.IsNullOrWhiteSpace(ime.Text) == false) && (String.IsNullOrWhiteSpace(prez.Text) == false) && (String.IsNullOrWhiteSpace(use.Text) == false) && (String.IsNullOrWhiteSpace(em.Text) == false) && (String.IsNullOrWhiteSpace(id.Text) == false) && (String.IsNullOrWhiteSpace(smer.Text) == false) && (String.IsNullOrWhiteSpace(gu.Text) == false) && (String.IsNullOrWhiteSpace(gs.Text) == false) && (String.IsNullOrWhiteSpace(faks.Text) == false) && (String.IsNullOrWhiteSpace(tel.Text) == false) && (long.TryParse(tel.Text, out long z) == true))
                    {

                        try
                        {
                            Student std = new Student(ime.Text, prez.Text, use.Text, pas.Text, em.Text, tel.Text);
                            Indeks idx = new Indeks(int.Parse(id.Text), smer.Text, int.Parse(gu.Text), int.Parse(gs.Text), faks.Text, std);
                            std.INDEKS = idx;
                            List<string> lista = new List<string>();
                            lista.Add(ime.Text);
                            lista.Add(prez.Text);
                            lista.Add(use.Text);
                            lista.Add(pas.Text);
                            lista.Add(em.Text);
                            lista.Add(tel.Text);
                            lista.Add(id.Text);
                            lista.Add(smer.Text);
                            lista.Add(gu.Text);
                            lista.Add(gs.Text);
                            lista.Add(faks.Text);
                            File.WriteAllLines(@"D:\Projekat\Studenti\" + use.Text + ".txt", lista);
                            HeadAdministrator.Podaci.USERSTUD.Add(use.Text);
                            HeadAdministrator.Podaci.STUDENT.Add(std);
                            HeadAdministrator.Podaci.INDEKS.Add(idx);
                            MessageBox.Show("Student kreiran");
                        }
                        catch
                        {
                            MessageBox.Show("Greska!\nPopunite sva polja adekvatnim sadrzajem");
                        }
                    }
                    else
                        MessageBox.Show("Molimo ispunite sva polja adekvatnim sadrzajem!");
                }
                else
                    MessageBox.Show("Unete lozinke nisu jednake");
            }
            else
                MessageBox.Show($"Korisnik {use.Text} vec postoji");
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.Show();
        }

        private void tel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
