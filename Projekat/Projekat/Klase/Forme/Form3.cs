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

namespace Projekat.Klase.Forme
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            

            Form5 f5 = new Form5();
            this.Hide();
            f5.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            this.Hide();
            f4.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Program.Ulogovani == true)
            {
                Form7 f7 = new Form7();
                this.Hide();
                f7.Show();
            }
            else
            {
                MessageBox.Show("Vi niste head admin");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 f9 = new Form9();
            f9.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f8 = new Form8();
            f8.Show();
            
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
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

        private void button9_Click(object sender, EventArgs e)
        {
            if (Program.Ulogovani == true)
            {
                Form10 f10 = new Form10();
                this.Hide();
                f10.Show();
            }
            else
                MessageBox.Show("Niste head admin i nemate pristup");

        }
    }
}
