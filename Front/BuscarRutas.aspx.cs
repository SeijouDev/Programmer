using BussinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Front
{
    public partial class BuscarRutas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] == null)
                Response.Redirect("Default.aspx");
        }

        protected void Search(object sender, EventArgs e)
        {
            var rutas = Controlador.BuscarRutas(Searchbox.Text);

            ListaRutasGv.DataSource = rutas;
            ListaRutasGv.DataBind();
        }

        protected void Gridview_RowCommand(object sender, GridViewCommandEventArgs e) 
        {
            var rutaNombre = e.CommandArgument.ToString().Split(':')[0];
            var prestador = e.CommandArgument.ToString().Split(':')[1];

            Response.Redirect($"DetalleRuta.aspx?route={rutaNombre}&pr={prestador}");
            
        }

        protected void back_click(object sender, EventArgs e)
        {
            Response.Redirect("LobbyPrincipal.aspx");
        }
    }
}