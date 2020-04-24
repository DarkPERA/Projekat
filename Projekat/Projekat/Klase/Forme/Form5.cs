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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ((File.Exists(@"D:\Projekat\Profesori\" + textBox2.Text + ".txt") == false) && (Program.privremena.Contains(textBox2.Text) == false))
            {
                

                if ((textBox3.Text == textBox4.Text) && (String.IsNullOrWhiteSpace(textBox3.Text) == false) && (String.IsNullOrWhiteSpace(textBox4.Text) == false))
                {
                    if ((String.IsNullOrWhiteSpace(textBox1.Text) == false) && (String.IsNullOrWhiteSpace(textBox2.Text) == false) && (String.IsNullOrWhiteSpace(textBox7.Text) == false) && (String.IsNullOrWhiteSpace(comboBox1.Text) == false) && (String.IsNullOrWhiteSpace(textBox5.Text) == false))
                    {
                        Nastavnik nastavnik = new Nastavnik(textBox7.Text, textBox1.Text, textBox2.Text, textBox3.Text, textBox5.Text, comboBox1.Text);
                        List<string> lista = new List<string>();
                        lista.Add(textBox7.Text);
                        lista.Add(textBox1.Text);
                        lista.Add(textBox2.Text);
                        lista.Add(textBox3.Text);
                        lista.Add(textBox5.Text);
                        lista.Add(comboBox1.Text);
                        HeadAdministrator.Podaci.USERPROF.Add(textBox2.Text);
                        File.WriteAllLines(@"D:\Projekat\Profesori\" + textBox2.Text + ".txt", lista);
                        HeadAdministrator.Podaci.PROFESOR.Add(nastavnik);
                        MessageBox.Show("Profesor kreiran");
                    }
                    else
                        MessageBox.Show("Molimo ispunite sva polja");
                }
                else
                    MessageBox.Show("Unete lozinke nisu jednake");
            }
            else
                MessageBox.Show($"Korisnik {textBox2.Text} vec postoji");
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
