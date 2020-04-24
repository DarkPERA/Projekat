using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Klase
{
    class Indeks
    {
        private int broj;
        private string smer;
        private int godina_upisa;
        private int godina_studija;
        private string fakultet;
        private Student Student;

        public int BROJ
        {
            get { return broj; }
            set { broj = value; }
        }
        public int GODINA_UPISA
        {
            get { return godina_upisa; }
            set { godina_upisa = value;}
        }
        public int GODINA_STUDIJA
        {
            get { return godina_studija; }
            set { godina_studija = value; }
        }
        public string FAKULTET
        {
            get { return fakultet; }
            set { fakultet = value; }
        }
        public string SMER
        {
            get { return smer; }
            set { smer = value; }
        }
        public Student STUDENT
        {
           get { return Student; }
            set { value = Student; }
        }

        public Indeks(int broj, string smer, int godina_upisa, int godina_studija, string fakultet)
        {
            this.broj = broj;
            this.smer = smer;
            this.godina_studija = godina_studija;
            this.godina_upisa = godina_upisa;
            this.fakultet = fakultet;
        }
        public Indeks(int broj, string smer, int godina_upisa, int godina_studija, string fakultet, Student Student)
        {
            this.broj = broj;
            this.smer = smer;
            this.godina_studija = godina_studija;
            this.godina_upisa = godina_upisa;
            this.fakultet = fakultet;
            this.Student = Student;
        }

    }
}
