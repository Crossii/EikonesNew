using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eikones
{
    public class Testabfrage
    {
        public tschueler Schueler { get; set; }
        public int Fehler { get; set; }
        public int Ausstehend { get; set; } // Anzahl die der Benutzer diesen Schueler noch richtig benennen muss

        public Testabfrage(tschueler schueler, int Ausstehend)
        {
            this.Schueler = schueler;
            this.Ausstehend = Ausstehend;
            Fehler = 0;
        }
        //0:alles richtig, 1:vorname richtig, 2:nachname richtig
        public int abfrage(String vorname, string nachname)
        {
            bool v = vorname.Equals(Schueler.S_Vorname);
            bool n = nachname.Equals(Schueler.S_Nachname);
            if (!(v || n))
            {
                Fehler++;
                return 3;
            }
            if (v && n)
            {
                Ausstehend--;
                return 0;
            }
            if (v)
            {
                Fehler++;
                return 1;
            }
            Fehler++;
            return 2;

        }
    }
}