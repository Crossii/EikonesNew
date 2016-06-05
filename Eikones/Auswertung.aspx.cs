using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Eikones
{
    public partial class Auswertung : System.Web.UI.Page
    {
        eikonesEntities s = new eikonesEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            tklassen klasse = Session["Klasse"] as tklassen;
            List<Testabfrage> abfragen = Session["abfragen"] as List<Testabfrage>;
            List<string> namen = new List<string>();
            int fehler = 0;
            int count = 0;  //zählt bei der foreach für die beichstrichsetzung 

            foreach (Testabfrage a in abfragen)
            {
                fehler += a.Fehler;

                if (fehler >= 3)
                    namen.Add(a.Schueler.S_Vorname + " " + a.Schueler.S_Nachname);
            }

            tcFehler.Text = fehler.ToString();

            foreach (string n in namen)
            {
                if (count > 0)
                    tcNamen.Text += ", ";
                tcNamen.Text += n;

                if (count % 3 == 0)
                    tcNamen.Text += "\n";
                count++;
            }
        }
    }
}