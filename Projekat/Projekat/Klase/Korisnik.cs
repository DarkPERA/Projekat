using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Klase
{
   abstract class Korisnik
    {
        protected string ime;
        protected string prezime;
        protected string username;
        protected string lozinka;
        protected bool obrisan;

        public string IME
        {
            get { return ime; }
            
        }
        public string PREZIME
        {
            get { return prezime; }
            
        }
        public string USERNAME
        {
            get { return username; }
            set { username = value; }
        }
        public string LOZINKA
        {
            set
            {
                if (value != lozinka)
                {
                    lozinka = value;

                }
            }
            get { return lozinka; }
        }
        public bool OBRISAN
        {
            get { return obrisan; }
            
            set { 
                obrisan = value;
            
            }
        }

        public Korisnik(string ime, string prezime, string username, string lozinka)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.username = username;
            this.lozinka = lozinka;
            obrisan = false;
        }

    }
}
