using System;
using System.Collections.Generic;
using System.Text;

namespace CbRadio
{
    class Bejegyzes
    {
        public int Ora;
        public int Perc;
        public int AdasDb;
        public string Nev;

        public Bejegyzes(string sor)
        {
            string[] adatok = sor.Split(';');

            Ora = int.Parse(adatok[0]);
            Perc = int.Parse(adatok[1]);
            AdasDb = int.Parse(adatok[2]);
            Nev = adatok[3];
        }
    }

}
