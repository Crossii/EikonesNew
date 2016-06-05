﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Eikones
{
    public partial class Klassenauswahl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btAuswahl_Click(object sender, EventArgs e)
        {
            Session["Klasse"] = (from k in db.tklassens.ToList()
                                 where k.K_ID == ddKlassen.SelectedValue
                                 select k) as tklassen;
            Response.Redirect("Klassenansicht.aspx");
            
        }

        
    }
}