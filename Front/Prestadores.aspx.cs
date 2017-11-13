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
    public partial class Prestadores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_form_Click(object sender, EventArgs e)
        {

            var msg = string.Empty;

            //Valida que los campos de contraseña sean iguales
            if (Password.Text == Password2.Text)
            {
                //Valida se haya seleccionado un rol (Prestador ó Pasajero)
                if (!string.IsNullOrEmpty(role.SelectedValue))
                {
                    //Valida si el valor del rol corresponde a prestador o pasajero
                    if (Convert.ToInt32(role.SelectedValue) == 0)
                    {
                        //Crea objeto de tipo prestador
                        var p = new Prestador(name.Text, lastname.Text, Id.Text, Mail.Text, City.Text, Birthdate.Text, Phone.Text, Username.Text, Password.Text);

                        //Valida que el usuario cumpla con las reglas del negocio
                        if (Controlador.ValidarNuevoUsuario(p))
                        {
                            //Valida que el nombre de usuario no exista el la base de datos
                            if (Controlador.ValidarNombreUsuario(p.Usuario))
                                msg = (Controlador.CrearPrestador(p) == "1") ? "Registro exitoso!" : "Error en el regsitro.";
                            else
                                msg = "El nombre de usuario ya existe!";
                        }
                        else
                            msg = "EL usuario debe ser mayor de edad.";

                    }
                    else if (Convert.ToInt32(role.SelectedValue) == 1)
                    {
                        //Crea objeto de tipo pasajero
                        var p = new Pasajero(name.Text, lastname.Text, Id.Text, Mail.Text, City.Text, Birthdate.Text, Phone.Text, Username.Text, Password.Text);

                        //Valida que el usuario cumpla con las reglas del negocio
                        if (Controlador.ValidarNuevoUsuario(p))
                        {
                            //Valida que el nombre de usuario no exista el la base de datos
                            if (Controlador.ValidarNombreUsuario(p.Usuario))
                                msg = (Controlador.CrearPasajero(p) == "1") ? "Registro exitoso!" : "Error en el registro.";
                            else
                                msg = "El nombre de usuario ya existe!";
                        }
                        else
                            msg = "EL usuario debe ser mayor de edad.";
                    }
                    else
                        msg = "Parametro invalido!";

                }
            }
            else
                msg = "Las claves deben ser iguales";

            

            //Muestra un mensaje con el resultado del regsitro
            Message.Text = msg;
            Message.Visible = true;

        }
    }
}