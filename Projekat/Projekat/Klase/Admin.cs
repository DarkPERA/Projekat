using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Klase
{
    interface IAdmin
    {
        void Brisni_Prof(Nastavnik obj);

        void Brisni_Stud(Student obj);
    }
}
