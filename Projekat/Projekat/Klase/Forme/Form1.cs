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

namespace Projekat.Klase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Sifra.UseSystemPasswordChar = false;
            }
            else
                Sifra.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            if (Username.Text == "admin" && Sifra.Text == "admin")
            {
                Form3 f3 = new Form3();
                this.Hide();
                f3.Show();
                HeadAdministrator glavni = new HeadAdministrator();
                Program.Ulogovani = true;
                Program.headadmin = new HeadAdministrator();

            }
            else
            {

                if (File.Exists(@"D:\Projekat\Admini\" + Username.Text + ".txt"))
                {
                    List<string> admin = new List<string>();
                    admin = File.ReadAllLines(@"D:\Projekat\Admini\" + Username.Text + ".txt").ToList();
                    if (admin[1] == Sifra.Text)
                    {
                        MessageBox.Show($"Dobrodosli {admin[2]}");
                        Form3 f3 = new Form3();
                        f3.Show();
                        this.Hide();
                        Program.admin = new Administrator(Username.Text,Sifra.Text);
                        Program.Ulogovani = false;
                    }
                    else
                        MessageBox.Show("Pogresno uneta lozinka");
                }
                else
                     if (File.Exists(@"D:\Projekat\Profesori\" + Username.Text + ".txt"))
                     {
                    List<string> prof = new List<string>();
                    prof = File.ReadAllLines(@"D:\Projekat\Profesori\" + Username.Text + ".txt").ToList();
                          if (prof[3] == Sifra.Text)
                          {
                        MessageBox.Show($"Dobrodosli {prof[0]}");
                        Program.Ulogovani = null;
                    }
                    else
                        MessageBox.Show("Pogresno uneta lozinka");
                }
                else
                if (File.Exists(@"D:\Projekat\Studenti\" + Username.Text + ".txt"))
                {
                    List<string> stud = new List<string>();
                    stud = File.ReadAllLines(@"D:\Projekat\Studenti\" + Username.Text + ".txt").ToList();
                    if(stud[3] == Sifra.Text)
                    MessageBox.Show("Vi ste student i niko Vas ne voli");
                    else
                        MessageBox.Show("Pogresno uneta lozinka");


                }
                else
                    MessageBox.Show("Uneti podaci nisu ispravni");
            }



        }

        private void Username_TextChanged(object sender, EventArgs e)
        {
          
          
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           DialogResult dialog = MessageBox.Show("Da li zaista zelite da izadjete?","Exit",MessageBoxButtons.YesNo);

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
    }
}
