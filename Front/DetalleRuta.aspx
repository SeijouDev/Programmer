<%@ Page Title="Detalle ruta" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetalleRuta.aspx.cs" Inherits="Front.DetalleRuta" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

      <section class="hero is-success is-fullheight">
        <div class="hero-body">
          <div class="container has-text-centered">
            <div class="column is-8 is-offset-2">
                <div class="box">
                    <h1 class="title has-text-grey">Detalle de ruta</h1>

                    <div class="field">
                        <div class="control">
                            <asp:Label runat="server">Nombre</asp:Label>
                            <asp:TextBox  CssClass="input is-large" runat ="server" ID="Nombre"  ValidationGroup="vg1" Enabled="false"></asp:TextBox>
                        </div>
                    </div>

                    <div class="field">
                        <div class="control">
                            <asp:Label runat="server">Dirección Inicio</asp:Label>
                            <asp:TextBox  CssClass="input is-large" runat ="server" ID="DirIni"  ValidationGroup="vg1" Enabled="false"></asp:TextBox>
                        </div>
                    </div>

                    <div class="field">
                        <div class="control">
                            <asp:Label runat="server">Dirección Destino</asp:Label>
                            <asp:TextBox  CssClass="input is-large" runat ="server" ID="DirFin"  ValidationGroup="vg1" Enabled="false"></asp:TextBox>
                        </div>
                    </div>
                    
                    <div class="field">
                        <div class="control">
                            <asp:Label runat="server">Clase de vehículo</asp:Label>
                            <asp:TextBox  CssClass="input is-large" runat ="server" ID="Clase" ValidationGroup="vg1" Enabled="false"></asp:TextBox>
                        </div>
                    </div>

                    <div class="field">
                        <div class="control">
                            <asp:Label runat="server">Datos vehículo</asp:Label>
                            <asp:TextBox  CssClass="input is-large" runat ="server" ID="Vehiculo" ValidationGroup="vg1" Enabled="false"></asp:TextBox>
                        </div>
                    </div>

                      <div class="field">
                        <div class="control">
                            <asp:Label runat="server">Ciudad de registro</asp:Label>
                            <asp:TextBox  CssClass="input is-large" runat ="server" ID="Ciudad" ValidationGroup="vg1" Enabled="false"></asp:TextBox>
                        </div>
                    </div>             

                    <div class="field">
                        <div class="control">
                            <asp:Label runat="server">Tipo de combustible</asp:Label>
                            <asp:TextBox  CssClass="input is-large" runat ="server" ID="Combustible" ValidationGroup="vg1" Enabled="false"></asp:TextBox>
                        </div>
                    </div>

                    <div class="field">
                        <div class="control">
                            <asp:Label runat="server">Vacantes</asp:Label>
                            <asp:TextBox  CssClass="input is-large" runat ="server" ID="Vacantes" ValidationGroup="vg1" Enabled="false"></asp:TextBox>
                        </div>
                    </div>

                    <asp:Label Visible="false" ID="result" runat="server" CssClass="alert_msg"></asp:Label>

                    <div class="field">
                        <asp:Button ValidationGroup="vg1" runat="server" ID="submit_form" Text="Vincularme a esta ruta" CssClass="button is-block is-info is-large" OnClick="vincularRuta"/>
                    </div>

                    <div class="field">
                        <asp:Button runat="server" ID="btnBack" Text="Volver" CssClass="button is-block is-danger is-large" OnClick="back_click"/>
                    </div>
                </div>
            </div>
          </div>
        </div>
      </section>


</asp:Content>