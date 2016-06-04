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
        schuldbEntities db = new schuldbEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btAuswahl_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("Klassenansicht.aspx");
        }
    }
}