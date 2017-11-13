
<%@ Page Title="CarSharing - Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Front._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
  <section class="hero is-success is-fullheight">
    <div class="hero-body">
      <div class="container has-text-centered">
        <div class="column is-4 is-offset-4">
          <h3 class="title has-text-grey">CarSharing</h3>
          <div class="box">
              <figure class="avatar">
                  <img src="https://cdn2.iconfinder.com/data/icons/rcons-car/512/car-128.png">
              </figure>
              <div class="field">
                <div class="control">
                	<asp:TextBox ID="Username" runat="server" CssClass="input is-large" Textmode="SingleLine"  Placeholder="Usuario" ValidationGroup="vg1" />
                	<asp:RequiredFieldValidator id="RequiredFieldValidator10" runat="server" ControlToValidate="Username" ValidationGroup="vg1"  ErrorMessage="Por favor ingrese el usuario"  ForeColor="Red" />
                </div>
              </div>

              <div class="field">
                <div class="control">
                	<asp:TextBox ID="Pass" runat="server" CssClass="input is-large" Textmode="Password"  ValidationGroup="vg1" Placeholder="Contraseña"/>
                	<asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" ControlToValidate="Pass" ValidationGroup="vg1"  ErrorMessage="Por favor ingrese la contraseña"  ForeColor="Red" />
                </div>
              </div>

              <asp:Button runat="server" CssClass="button is-block is-info is-large" Text="Ingresar" ValidationGroup="vg1" OnClick="Validate_login" ></asp:Button>

              <div class="field">
                  <div class="control" style="text-align: center; margin-top: 1rem">
                      <a style="text-decoration: underline; color: #1496ed" href="Prestadores.aspx">Registrarme</a>
                  </div>
              </div>
            
              <asp:Label Visible="false" ID="login_result" runat="server" CssClass="alert_msg"></asp:Label>
          </div>
        </div>
      </div>
    </div>
</section>
</asp:Content>
