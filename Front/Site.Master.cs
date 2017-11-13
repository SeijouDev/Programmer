using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Front
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] != null)
            {
               panel_nav.CssClass = "visible";
               labelSaludo.Text += $"{Session["Nombre"]} {Session["Apellido"]}";
            }
        }

        protected void btn_logout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Session.Clear();
            Response.Redirect("Default.aspx");
        }
    }
}