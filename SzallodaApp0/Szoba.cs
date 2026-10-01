using System;
using System.Collections.Generic;
using System.Text;

namespace SzallodaApp0
{
    public class Szoba
    {
        public int Szobaszam { get; set; }

        protected int alapar { get; set; }

        public int Alapar { get; set; }  

        public Szoba(int szobaszam,int alapar)
        {
            Szobaszam = szobaszam;
            Alapar = alapar;
        }
        public virtual int ArKiszamitas(int ejszakakSzama)
        {
            return ejszakakSzama * Alapar;


        }
        public override string ToString()
        {
            return $"Szoba {Szobaszam} | Alapár: {Alapar} Ft/éj";
        }

    }
}
