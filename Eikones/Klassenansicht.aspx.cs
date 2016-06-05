﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Eikones
{
    public partial class Klassenansicht : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            tklassen klasse = Session["3BHIF"] as tklassen;
            List<tschueler> schueler = klasse.tschuelers.ToList();
            int col = 0;
            int maxCol = 4;
            foreach (tschueler s in schueler)
            {
                TableRow PicRow, NameRow;
                //zeilenverwaltung
                if (col == maxCol)
                {
                    maxCol = 0;
                    PicRow = new TableRow();
                    NameRow = new TableRow();
                    tbSchueler.Rows.Add(PicRow);
                    tbSchueler.Rows.Add(NameRow);
                }
                //Zellen initialisieren
                TableCell pic = new TableCell();
                TableCell name = new TableCell();
                pic.CssClass = "PictureCell";
                name.CssClass = "StudentNameCell";

                if (File.Exists(@"..\Bilder\" + s.S_ID + ".png"))
                    pic.Text = @"<img src = '..\Bilder\" + s.S_ID + ".png'/>";
                else
                    pic.Text = "<img src = 'default.png'/>";

                name.Text = s.S_ID;

                col++;
            }
        }

        protected void btAnsicht_Click(object sender, EventArgs e)
        {
            Response.Redirect("Test.aspx");
        }
    }
}