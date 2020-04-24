using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projekat.Klase;
using Projekat.Klase.Forme;
using System.IO;

namespace Projekat
{
    static class Program
    {
        public static Administrator admin;
        public static HeadAdministrator headadmin;
        public static bool? Ulogovani;
        public static List<string> privremena = new List<string>();
        



        public static void ispis_u_listu()
        {
            File.WriteAllLines(@"D:\Projekat\Studenti\liste.txt", HeadAdministrator.Podaci.USERSTUD);
            File.WriteAllLines(@"D:\Projekat\Admini\liste.txt", HeadAdministrator.Podaci.USERADMIN);
            File.WriteAllLines(@"D:\Projekat\Profesori\liste.txt", HeadAdministrator.Podaci.USERPROF);
        }


        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (Directory.Exists(@"D:\Projekat") == false)
            {
                System.IO.Directory.CreateDirectory(@"D:\Projekat");
                System.IO.Directory.CreateDirectory(@"D:\Projekat\Studenti");
                System.IO.Directory.CreateDirectory(@"D:\Projekat\Profesori");
                System.IO.Directory.CreateDirectory(@"D:\Projekat\Admini");
            }

            if (File.Exists(@"D:\Projekat\Studenti\liste.txt"))
            {
                try
                {
                    HeadAdministrator.Podaci.USERSTUD = File.ReadAllLines(@"D:\Projekat\Studenti\liste.txt").ToList();
                    if (String.IsNullOrWhiteSpace(HeadAdministrator.Podaci.USERSTUD[0]) == false)
                    {
                        foreach (string user in HeadAdministrator.Podaci.USERSTUD)
                        {
                            privremena = File.ReadAllLines(@"D:\Projekat\Studenti\" + user + ".txt").ToList();
                            Student stud = new Student(privremena[0], privremena[1], privremena[2], privremena[3], privremena[4], privremena[5]);
                            Indeks indx = new Indeks(Convert.ToInt32(privremena[6]), privremena[7], Convert.ToInt32(privremena[8]), Convert.ToInt32(privremena[9]), privremena[10], stud);
                            stud.INDEKS = indx;
                            HeadAdministrator.Podaci.STUDENT.Add(stud);
                            HeadAdministrator.Podaci.INDEKS.Add(indx);
                            privremena.Clear();
                        }
                    }
                }
                catch
                {
                    string[] Jovan = { "Jovan", "Jovan", "Jovan","jova123","jovan@janko.com","0601010","000","Test Smer","2019","1","Netflix&Chill" };

                    File.WriteAllText(@"D:\Projekat\Studenti\liste.txt", "Jovan");
                    File.WriteAllLines(@"D:\Projekat\Studenti\Janko.txt", Jovan);
                }
            }
            if (File.Exists(@"D:\Projekat\Profesori\liste.txt"))
            {
                try
                {
                    HeadAdministrator.Podaci.USERPROF = File.ReadAllLines(@"D:\Projekat\Profesori\liste.txt").ToList();
                    if (String.IsNullOrWhiteSpace(HeadAdministrator.Podaci.USERPROF[0]) == false)
                    {
                        foreach (string user in HeadAdministrator.Podaci.USERPROF)
                        {
                            privremena = File.ReadAllLines(@"D:\Projekat\Profesori\" + user + ".txt").ToList();
                            HeadAdministrator.Podaci.PROFESOR.Add(new Nastavnik(privremena[0], privremena[1], privremena[2], privremena[3], privremena[4], privremena[5]));
                            privremena.Clear();
                        }
                    }
                }
                catch
                {
                    string[] Marko =  { "Marko", "Marko", "Marko", "marko123", "marko@janko.com", "Asistent" };
                    File.WriteAllText(@"D:\Projekat\Profesori\liste.txt", "Marko");
                    File.WriteAllLines(@"D:\Projekat\Profesori\Marko.txt",Marko);
                }
            }
            if (File.Exists(@"D:\Projekat\Admini\liste.txt"))
            {
                try
                {
                    HeadAdministrator.Podaci.USERADMIN = File.ReadAllLines(@"D:\Projekat\Admini\liste.txt").ToList();
                    if (String.IsNullOrWhiteSpace(HeadAdministrator.Podaci.USERADMIN[0]) == false)
                    {
                        foreach (string user in HeadAdministrator.Podaci.USERADMIN)
                        {
                            privremena = File.ReadAllLines(@"D:\Projekat\Admini\" + user + ".txt").ToList();
                            HeadAdministrator.Podaci.ADMIN.Add(HeadAdministrator.KreirajAdmina(privremena[0], privremena[1], privremena[2], privremena[3]));
                            privremena.Clear();
                        }
                    }
                }
                catch
                {
                    string[] Janko = { "Jancic", "janko123", "Janko", "Jancic"};
                    File.WriteAllText(@"D:\Projekat\Admini\liste.txt", "Janko");
                    File.WriteAllLines(@"D:\Projekat\Admini\Janko.txt", Janko);
                }
            }
            Program.privremena.Clear();
            Program.privremena.AddRange(HeadAdministrator.Podaci.USERADMIN);
            Program.privremena.AddRange(HeadAdministrator.Podaci.USERPROF);
            Program.privremena.AddRange(HeadAdministrator.Podaci.USERSTUD);
            Application.Run(new Form1());

           
        }
    }
}
