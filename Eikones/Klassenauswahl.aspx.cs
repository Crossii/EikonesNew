using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Eikones
{
    public partial class Klassenauswahl : System.Web.UI.Page
    {
        eikonesEntities db = new eikonesEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btAuswahl_Click(object sender, EventArgs e)
        {
            string kid = ddKlassen.SelectedValue.ToString();
            tklassen klasse = (from k in db.tklassens.ToList()
                               where k.K_ID.Equals(kid)
                               select k).First();
            Session["Klasse"] = klasse;
            Response.Redirect("Klassenansicht.aspx");
            
        }

        
    }
}