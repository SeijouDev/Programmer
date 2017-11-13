using BussinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Front
{
    public partial class ListaRuta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] == null)
                Response.Redirect("Default.aspx");


            var rutas = Controlador.ObtenerRutasPorUsuario(Convert.ToInt32(Session["pk"]) , Convert.ToInt32(Session["rol"]));

            ListaRutasGv.DataSource = rutas;
            ListaRutasGv.DataBind();
        }

        protected void back_click(object sender, EventArgs e)
        {
            Response.Redirect("LobbyPrincipal.aspx");
        }
     
    }
}