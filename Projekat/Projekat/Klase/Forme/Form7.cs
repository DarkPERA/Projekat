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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ((File.Exists(@"D:\Projekat\Admini\" + textBox1.Text + ".txt") == false) && (Program.privremena.Contains(textBox1.Text) == false) )
            {


                if ((textBox5.Text == textBox2.Text) && (String.IsNullOrWhiteSpace(textBox5.Text) == false) && (String.IsNullOrWhiteSpace(textBox2.Text) == false))
                {
                    if ((String.IsNullOrWhiteSpace(textBox1.Text) == false) && (String.IsNullOrWhiteSpace(textBox3.Text) == false) && (String.IsNullOrWhiteSpace(textBox4.Text) == false))
                    {
                        Administrator Fejk = HeadAdministrator.KreirajAdmina(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
                        List<string> lista = new List<string>();
                        lista.Add(textBox1.Text);
                        lista.Add(textBox2.Text);
                        lista.Add(textBox3.Text);
                        lista.Add(textBox4.Text);
                        HeadAdministrator.Podaci.USERADMIN.Add(textBox1.Text);
                        HeadAdministrator.Podaci.ADMIN.Add(Fejk);
                        File.WriteAllLines(@"D:\Projekat\Admini\" + textBox1.Text + ".txt", lista);

                        MessageBox.Show("Admin kreiran");
                    }
                    else
                        MessageBox.Show("Molimo ispunite sva polja");
                }
                else
                    MessageBox.Show("Unete lozinke nisu jednake");
            }
            else
                MessageBox.Show($"Korisnik {textBox1.Text} vec postoji");
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
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
