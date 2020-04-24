using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Klase
{
    class Administrator : IAdmin
    {
        private string username;
        private string password;
        private string ime;
        private string prezime;
        private bool obrisan;
        public string USERNAME
        {
            get { return username; }
            set { username = value; }
        }
        public string PASSWORD
        {
            
            set { password = value; }
        }
        public bool OBRISAN
        {
            get { return obrisan; }
            set { obrisan = value; }
        }
        public string IME
        {
            get { return ime; }
            set { ime = value; }
        }
        public string PREZIME
        {
            get { return prezime; }
            set { prezime = value; }
        }
        public Administrator(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public void Brisni_Prof(Nastavnik obj)
        {
            obj.OBRISAN = true;
        }

        public void Brisni_Stud(Student obj)
        {
            obj.OBRISAN = true;
        }
    }
}
