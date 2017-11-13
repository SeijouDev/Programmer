using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Front
{
    public partial class LobbyPrincipal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["Usuario"] == null)
                Response.Redirect("Default.aspx");
            
            
        }

        protected void btn_logout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Session.Clear();

            Response.Redirect("Default.aspx");
        }
    }
}