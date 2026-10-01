using System;
using System.Collections.Generic;
using System.Text;

namespace SzallodaApp0
{
    public class Lakosztaly : Szoba
    {
        public int ExtraSzolgaltatasAr { get; set; }

        public Lakosztaly(int szobaszam, int alapar, int extraSzolgaltatasAr) : base(szobaszam, alapar)
        {
            ExtraSzolgaltatasAr = extraSzolgaltatasAr;

        }

    }
}
