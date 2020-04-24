using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Klase
{
    enum Zvanje
    {
        saradnik,
        asistent,
        docent,
        vandredni_profesor,
        redovan_profesor
    }
    class Nastavnik :Korisnik
    {
        private string email;
        private Zvanje zvanje;  

        public string EMAIL
        {
            get {return email; }
          
        }
        public string ZVANJE
        {
            get { return Convert.ToString(zvanje); }
        }
        

        public Nastavnik(string ime, string prezime, string username, string lozinka, string email, string zvanije) : base(ime,prezime,username,lozinka)
        {
            int m = 0;
            switch (zvanije)
            {
                case "Saradnik":
                    m = 0;
                    break;
                case "Asistent":
                    m = 1;
                    break;
                case "Docent":
                    m = 2;
                    break;
                case "Vanredni Profesor":
                    m = 3;
                    break;
                case "Redovan Profesor":
                    m = 4;
                    break;
            }

            this.email = email;
            this.zvanje = (Zvanje)m;
        }
    }
}
