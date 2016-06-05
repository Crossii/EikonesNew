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
            String[] Fehler = Session["Fehler"] as String[];
        }
    }
}