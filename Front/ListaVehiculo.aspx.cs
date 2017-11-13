using BussinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Front
{
    public partial class ListaVehiculo : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] == null)
                Response.Redirect("Default.aspx");

            var vehiculos = Controlador.ObtenerVehiculosPorPrestador(Convert.ToInt32(Session["pk"]));

            ListaVehiculosGv.DataSource = vehiculos;
            ListaVehiculosGv.DataBind();
        }

        protected void back_click(object sender, EventArgs e)
        {
            Response.Redirect("LobbyPrincipal.aspx");
        }
    }
}