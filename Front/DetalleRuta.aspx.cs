using BussinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Front
{
    public partial class DetalleRuta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["Usuario"] == null)
                Response.Redirect("Default.aspx");

            var ruta = Controlador.BuscarRutaPorNombre(Request.QueryString["route"], Convert.ToInt32(Request.QueryString["pr"]));

            if(ruta.Count == 1)
            {
                var r = ruta[0];
                var v = Controlador.BuscarVehiculoPorId(r.FkVehiculo)[0];

                Nombre.Text = r.Nombre;
                DirIni.Text = r.DireccionPuntoInicio;
                DirFin.Text = r.DireccionPuntoFinal;
                Vehiculo.Text = $"{v.Marca} {v.Linea} {v.Color} ({v.Modelo}) - {v.Placa}";
                Ciudad.Text = v.CiudadPlaca;
                Combustible.Text = v.TipoCombustible;
                Clase.Text = v.ClaseVehiculo;
                Vacantes.Text = v.Vacantes.ToString();                
            }
            else
                Response.Redirect("BuscarRutas.aspx");
        }

        protected void vincularRuta(object sender, EventArgs e)
        {
            var resp = Controlador.VincularPasajeroRuta(Convert.ToInt32(Session["pk"]), Request.QueryString["route"], Convert.ToInt32(Request.QueryString["pr"]));

            result.Text = (resp == "1") ? "Registro exitoso!" : "Error en el registro.";
            result.Visible = true;
        }

        protected void back_click(object sender, EventArgs e)
        {
            Response.Redirect("BuscarRutas.aspx");
        }
    }
}