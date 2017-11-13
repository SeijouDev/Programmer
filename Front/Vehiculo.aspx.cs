using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Entities;
using BussinessLogic;

namespace Front
{
    public partial class Vehiculo : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] == null)
                Response.Redirect("Default.aspx");

        }

        protected void submit_form_Click(object sender, EventArgs e)
        {
            var msg = string.Empty;

            var v = new Entities.Vehiculo {
                Marca = Marcatx.Text,
                Linea = Lineatx.Text,
                Placa = Placatx.Text,
                Color = Colortx.Text,
                CiudadPlaca = CiudadPtx.Text,
                Modelo = Convert.ToInt32(Modelotx.Text),
                TipoCombustible = TipoCombustibletx.SelectedItem.Text,
                ClaseVehiculo = TipoVehiculotx.SelectedItem.Text,
                Vacantes = Convert.ToInt32(Vacantestx.Text),
                Foto = "",
                fkPrestador = Convert.ToInt32(Session["pk"])
            };

            msg = (Controlador.CrearVehiculo(v) == "1") ? "Registro exitoso!" : "Error en el regsitro.";

            //Muestra un mensaje con el resultado del regsitro
            Result.Text = msg;
            Result.Visible = true;
        }

        protected void back_click(object sender, EventArgs e)
        {
            Response.Redirect("ListaVehiculo.aspx");
        }
    }  
}