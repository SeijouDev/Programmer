<%@ Page Title="Registro" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Prestadores.aspx.cs" Inherits="Front.Prestadores" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <section class="hero is-success is-fullheight">
    <div class="hero-body">
      <div class="container has-text-centered">
        <div class="column is-8 is-offset-2">
          <h3 class="title has-text-grey">Registrarse</h3>
          <div class="box">
              <figure class="avatar">
                  <img src="https://winaero.com/blog/wp-content/uploads/2015/05/windows-10-user-account-login-icon.png">
              </figure>
              <div class="field">
                <div class="control">
                    <asp:Label CssClass="checkbox" runat="server">Registrarme como: *</asp:Label>
                        <asp:RadioButtonList ID="role" runat="server">
                        <asp:ListItem Text="Prestador" Value="0" />
                        <asp:ListItem Text="Pasajero" Value="1" />
                    </asp:RadioButtonList>
                    <asp:RequiredFieldValidator id="RequiredFieldValidator11" runat="server" ControlToValidate="role"   ErrorMessage="Seleccione una opción."  ForeColor="Red" />
                </div>
              </div>

              <div class="field">
                <div class="control">
                     <asp:Label runat="server">Nombre*</asp:Label>
                    <asp:TextBox runat="server" ID="name" CssClass="input is-large" MaxLength="20" ></asp:TextBox>
                    <asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" ControlToValidate="name"   ErrorMessage="Por favor ingrese un nombre valido."  ForeColor="Red" />
                </div>
              </div>
              <div class="field">
                <div class="control">
                    <asp:Label runat="server">Apellido*</asp:Label>
                    <asp:TextBox runat="server" ID="lastname" CssClass="input is-large"  MaxLength="20"></asp:TextBox>
                    <asp:RequiredFieldValidator id="RequiredFieldValidator2" runat="server" ControlToValidate="lastname"   ErrorMessage="Por favor ingrese un apellido valido."  ForeColor="Red" />
                </div>
              </div>
              <div class="field">
                <div class="control">
                    <asp:Label runat="server">Cedula*</asp:Label>
                    <asp:TextBox runat="server" ID="Id" CssClass="input is-large"  MaxLength="20" TextMode="Number"></asp:TextBox>
                    <asp:RequiredFieldValidator id="RequiredFieldValidator3" runat="server" ControlToValidate="Id" ErrorMessage="Por favor ingrese una cedula valida."  ForeColor="Red" />
                </div>
              </div>
              <div class="field">
                <div class="control">
                    <asp:Label runat="server">Correo*</asp:Label>
                    <asp:TextBox runat="server" ID="Mail" CssClass="input is-large"  MaxLength="50" TextMode="Email" ></asp:TextBox>
                    <asp:RequiredFieldValidator id="RequiredFieldValidator4" runat="server" ControlToValidate="Mail" ErrorMessage="Por favor ingrese un correo valido."  ForeColor="Red" />
                </div>
              </div>
              <div class="field">
                <div class="control">
                    <asp:Label runat="server">Ciudad Residencia*</asp:Label>
                    <asp:TextBox runat="server" ID="City" CssClass="input is-large"  MaxLength="20"></asp:TextBox>
                    <asp:RequiredFieldValidator id="RequiredFieldValidator5" runat="server" ControlToValidate="City" ErrorMessage="Por favor ingrese una ciudad de residencia valida."  ForeColor="Red" />
                </div>
              </div>
              <div class="field">
                <div class="control">
                    <asp:Label runat="server">Fecha nacimiento*</asp:Label>
                    <asp:TextBox ID="Birthdate" runat="server" CssClass="input is-large" textMode="Date" placeholder="aaaa/mm/dd"></asp:TextBox>
                    <asp:RequiredFieldValidator id="RequiredFieldValidator6" runat="server" ControlToValidate="Birthdate" ErrorMessage="Por favor ingrese una fecha de nacimiento valida."  ForeColor="Red" />
                </div>
              </div>
              <div class="field">
                <div class="control">
                    <asp:Label runat="server">Teléfono*</asp:Label>
                    <asp:TextBox runat="server" ID="Phone" CssClass="input is-large"  MaxLength="15" TextMode="Number"></asp:TextBox>
                    <asp:RequiredFieldValidator id="RequiredFieldValidator7" runat="server" ControlToValidate="Phone" ErrorMessage="Por favor ingrese un teléfono valido"  ForeColor="Red" />
                </div>
              </div>
              <div class="field">
                <div class="control">
                    <asp:Label runat="server">Usuario*</asp:Label>
                    <asp:TextBox runat="server" ID="Username" CssClass="input is-large"  MaxLength="10"></asp:TextBox>
                    <asp:RequiredFieldValidator id="RequiredFieldValidator8" runat="server" ControlToValidate="Username" ErrorMessage="Por favor ingrese un nombre de usuario valido."  ForeColor="Red" />
                </div>
              </div>
              <div class="field">
                <div class="control">
                     <asp:Label runat="server">Clave*</asp:Label>
                    <asp:TextBox runat="server" ID="Password" CssClass="input is-large" TextMode="Password"  MaxLength="20" ></asp:TextBox>
                    <asp:RequiredFieldValidator id="RequiredFieldValidator9" runat="server" ControlToValidate="Password" ErrorMessage="Por favor ingrese una clave valida."  ForeColor="Red" />
                </div>
              </div>
              <div class="field">
                <div class="control">
                    <asp:Label runat="server">Confirmación clave*</asp:Label>
                    <asp:TextBox runat="server" ID="Password2" CssClass="input is-large" TextMode="Password"  MaxLength="20"></asp:TextBox>
                    <asp:RequiredFieldValidator id="RequiredFieldValidator10" runat="server" ControlToValidate="Password2" ErrorMessage="Por favor ingrese una cedula valida."  ForeColor="Red" />
                </div>
              </div>
              <div class="field">
                  <asp:Label ID="Message" runat="server" Visible="false"/>
                  <asp:Button runat="server" ID="submit_form" Text="Guardar" CssClass="button is-block is-info is-large" OnClick="submit_form_Click"/>
                  <asp:Label Visible="false" ID="login_result" runat="server" CssClass="alert_msg"></asp:Label>
              </div>
          </div>
        </div>
      </div>
    </div>
</section>

</asp:Content>



