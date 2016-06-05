using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Eikones
{
    public partial class Test : System.Web.UI.Page
    {
        Testabfrage aktTest; //aktueller schueler
        List<Testabfrage> abfragen = new List<Testabfrage>();
        List<Testabfrage> abfragenungeloescht;
        Random r = new Random();
        protected void Page_Load(object sender, EventArgs e)
        {
            abfragenungeloescht = abfragen;
            int abfragenProSchueler = 5;
            tklassen klasse = Session["Klasse"] as tklassen;
            foreach (tschueler s in klasse.tschuelers)
            {
                abfragen.Add(new Testabfrage(s, abfragenProSchueler));
            }
            aktTest = abfragen.ElementAt(r.Next(0, abfragen.Count));
            string url = string.Format(@"..\..\Bilder\{0}.png", aktTest.Schueler.S_ID);
            
            if (File.Exists(url))
                imgSchueler.ImageUrl = url;
            else
                imgSchueler.ImageUrl = @"..\..\Bilder\default.png";
        }

        protected void btUeberpruefen_Click(object sender, EventArgs e)
        {
            int ergebnis = aktTest.abfrage(tbVorname.Text, tbNachname.Text);
            if (aktTest.Ausstehend == 0)
                abfragen.Remove(aktTest);
                switch (ergebnis)
                {
                    case 0:
                        lbFeedback.ForeColor = System.Drawing.Color.Green;
                        lbFeedback.Text = "Korrekt!";
                        break;
                    case 1:
                        lbFeedback.ForeColor = System.Drawing.Color.Yellow;
                        lbFeedback.Text = "Nachname falsch";
                        break;
                    case 2:
                        lbFeedback.ForeColor = System.Drawing.Color.Yellow;
                        lbFeedback.Text = "Vorname falsch!";
                        break;
                    case 3:
                        lbFeedback.ForeColor = System.Drawing.Color.Red;
                        lbFeedback.Text = "Vor und Nachname flasch!";
                        break;
                }
            if (ergebnis < 0)
                lbFeedback.Text = lbFeedback.Text + " Der richtige Name lautet " + aktTest.Schueler.S_Vorname;

            btUeberpruefen.Enabled = false;
        }

        protected void btNext_Click(object sender, EventArgs e)
        {
            if (abfragen.Count == 0)
                Response.Redirect("Auswertung.aspx");
            btUeberpruefen.Enabled = true;
            aktTest = abfragen.ElementAt(r.Next(0, abfragen.Count));
            if (File.Exists(@"..\Bilder\" + aktTest.Schueler.S_ID + ".png"))
                imgSchueler.ImageUrl = @"..\Bilder\" + aktTest.Schueler.S_ID + ".png";
            else
                imgSchueler.ImageUrl = @"..\Bilder\default.png";
        }

        protected void btEnd_Click(object sender, EventArgs e)
        {
            Session["abfragen"] = abfragenungeloescht;
            Response.Redirect("Auswertung.aspx");
        }
    }
}