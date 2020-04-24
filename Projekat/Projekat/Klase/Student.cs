using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Klase
{
    class Student : Korisnik
    {
        private string email;
        private string brtelefona;
        private Indeks indeks;

        public Indeks INDEKS
        {
          get { return indeks; }
          set { indeks = value; }
        }
        
        public string EMAIL
        {
            get { return email; }
            set { email = value; }
        }
        public string BRTELEFONA
        {
            get { return brtelefona; }
            set { brtelefona = value; }
        }

        public Student(string ime, string prezime, string username, string lozinka, string email, string brtelefona) : base(ime, prezime, username, lozinka)
        {
            this.email = email;
            this.brtelefona = brtelefona;
        }

        public Student(string ime, string prezime, string username, string lozinka, string email, string brtelefona, Indeks indeks) : base(ime, prezime, username, lozinka)
        {
            this.email = email;
            this.brtelefona = brtelefona;
            this.indeks = indeks;
        }
    }
}
