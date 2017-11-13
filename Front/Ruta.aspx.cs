using BussinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Front
{
    public partial class Ruta : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["Usuario"] == null)
                Response.Redirect("Default.aspx");

            VehiculoDropdown.DataSource = Controlador.ObtenerVehiculosPorPrestador(Convert.ToInt32(Session["pk"]));
            VehiculoDropdown.DataTextField = "Placa";
            VehiculoDropdown.DataValueField = "Pk";
            VehiculoDropdown.DataBind();

            hdlngFin.Visible = true;
        }

        protected void submit_form_Click(object sender, EventArgs e)
        {

            string msg = "";            

            var r = new Entities.Ruta(
                Nombre.Text,
                DireccionInicio.Text, 
                Convert.ToDouble(hdlatIni.Value.Replace('.',',')), 
                Convert.ToDouble(hdlngIni.Value.Replace('.', ',')),
                DireccionDestino.Text,
                Convert.ToDouble(hdlatFin.Value.Replace('.', ',')),
                Convert.ToDouble(hdlngFin.Value.Replace('.', ',')),
                Convert.ToInt32(Session["pk"]));

            r.FkVehiculo = Convert.ToInt32(VehiculoDropdown.SelectedValue);

            if (Controlador.ValidarNombreRuta(r.Nombre , Convert.ToInt32(Session["pk"])))            
                msg = (Controlador.CrearRuta(r) == "1") ? "Registro exitoso!" : "Error en el registro.";
            else
                msg = "El nombre de la ruta ya existe";

            Result.Text = msg;
            Result.Visible = true;
            
        }

        protected void back_click(object sender, EventArgs e)
        {
            Response.Redirect("ListaRuta.aspx");
        }
    }
}