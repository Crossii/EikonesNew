using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Eikones
{
    public partial class Klassenansicht : System.Web.UI.Page
    {
        schuldbEntities db = new schuldbEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            tklassen klasse = Session["Klasse"] as tklassen;
            List<tschueler> schueler = klasse.tschuelers.ToList();
            int col = 0;
            foreach(tschueler s in schueler)
            {
                TableRow actRow;
                if (col == 0)
                {
                    actRow = new TableRow();
                    tbSchueler.Rows.Add(actRow);
                }
                TableCell c = new TableCell();
                c.
            }
        }

        protected void btAnsicht_Click(object sender, EventArgs e)
        {
            Response.Redirect("Test.aspx");
        }
    }
}