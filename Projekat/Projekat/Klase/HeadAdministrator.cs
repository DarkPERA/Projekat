using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Klase
{
    class HeadAdministrator : IAdmin
    {

        private bool head;
        public bool HEAD
        {
            get { return head; }
        }
        public HeadAdministrator()
        {
            head = true;
        }

        public static Administrator KreirajAdmina(string username, string password, string ime, string prezime)
        {
            Administrator k = new Administrator(username,password);
            k.IME = ime;
            k.PREZIME = prezime;
            k.OBRISAN = false;
            return k;
        }

        public void Brisni_Prof(Nastavnik obj)
        {
            
           
                obj.OBRISAN = true;
           

        }

        public void Brisni_Stud(Student obj)
        {
            obj.OBRISAN = true;
        }
        public void Brisni_Admin(Administrator obj)
        {
            obj.OBRISAN = true;
        }
        public static class Podaci
        {
            private static List<Student> student = new List<Student>();
            private static List<Indeks> indeks = new List<Indeks>();
            private static List<Administrator> admin = new List<Administrator>();
            private static List<Nastavnik> profesor = new List<Nastavnik>();
            private static List<string> user_stud = new List<string>();
            private static List<string> user_prof = new List<string>();
            private static List<string> user_admin = new List<string>();

            public static List<Nastavnik> PROFESOR
            {
                get { return profesor; }
                set { profesor = value; }
            }
            public static List<Student> STUDENT
            {
                get {return student; }
                set {student = value; }
            }
            public static List<Indeks> INDEKS
            {
                get {return indeks; }
                set {indeks = value; }
            }
            public static List<Administrator> ADMIN
            {
                get {return admin; }
                set {admin = value; }
            }
            public static List<String> USERSTUD
            {
                get {return user_stud; }
                set {user_stud=value; }
            }
            public static List<String> USERPROF
            {
                get {return user_prof; }
                set {user_prof = value; }
            }
            public static List<String> USERADMIN
            {
                get {return user_admin; }
                set {user_admin=value; }
            }

           
        }
    }
}
