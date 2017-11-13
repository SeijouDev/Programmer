using BussinessLogic;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Front
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {                    
        }

        protected void Register_link_click(object sender, EventArgs e)
        {
            Response.Redirect("Prestadores.aspx");
        }

        protected void Validate_login (object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(Username.Text) && !string.IsNullOrEmpty(Pass.Text))
            {
                var result = false;

                var pasajero = Controlador.LoginPasajero(Username.Text, Pass.Text);

                if (pasajero != null)
                {
                    Session["Usuario"] = pasajero.Usuario;
                    Session["Nombre"] = pasajero.Nombre;
                    Session["Apellido"] = pasajero.Apellido;
                    Session["Cedula"] = pasajero.Cedula;
                    Session["Correo"] = pasajero.Correo;
                    Session["FechaNacimiento"] = pasajero.FechaNacimiento;
                    Session["CiudadRes"] = pasajero.CiudadResidencia;
                    Session["Telefono"] = pasajero.Telefono;
                    Session["CiudadRes"] = pasajero.CiudadResidencia;
                    Session["rol"] = 1;
                    Session["pk"] = Controlador.ObtenerPkUsuario(pasajero.Cedula, 1);

                    result = !result;
                }                
                    
                else
                {
                    var prestador = Controlador.LoginPrestador(Username.Text, Pass.Text);

                    if (prestador != null)
                    {
                        Session["Usuario"] = prestador.Usuario;
                        Session["Nombre"] = prestador.Nombre;
                        Session["Apellido"] = prestador.Apellido;
                        Session["Cedula"] = prestador.Cedula;
                        Session["Correo"] = prestador.Correo;
                        Session["FechaNacimiento"] = prestador.FechaNacimiento;
                        Session["CiudadRes"] = prestador.CiudadResidencia;
                        Session["Telefono"] = prestador.Telefono;
                        Session["CiudadRes"] = prestador.CiudadResidencia;
                        Session["rol"] = 0;
                        Session["pk"] = Controlador.ObtenerPkUsuario(prestador.Cedula, 0);

                        result = !result;
                    }
                }

                if (result)
                    Response.Redirect("LobbyPrincipal.aspx");                
                else
                {
                    login_result.Text = "Usuario o contraseña incorrectos!";
                    login_result.Visible = true;
                }
            }
            else
            {
                login_result.Text = "Complete todos los campos";
                login_result.Visible = true;
            }
        }

    }
}