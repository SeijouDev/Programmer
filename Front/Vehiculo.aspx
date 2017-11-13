<%@ Page Language="C#" MasterPageFile="~/Site.Master" Title="Nuevo vehículo" AutoEventWireup="true" CodeBehind="Vehiculo.aspx.cs" Inherits="Front.Vehiculo" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
  <section class="hero is-success is-fullheight">
    <div class="hero-body">
      <div class="container has-text-centered">
        <div class="column is-8 is-offset-2">
          <h3 class="title has-text-grey">Nuevo vehículo</h3>
             <div class="box">

               <div class="field">
                <div class="control">
                     <asp:Label runat="server">Marca*</asp:Label>
                     <asp:TextBox CssClass="input is-large" runat="server" ID="Marcatx"  ValidationGroup="vg1" MaxLength="20" ></asp:TextBox>
                     <asp:RequiredFieldValidator id="RequiredFieldValidator10" runat="server" ValidationGroup="vg1" ControlToValidate="Marcatx" ErrorMessage="Por favor ingrese una marca valida."  ForeColor="Red" />
                </div>
              </div>
              <div class="field">
                  <div class="control">
                       <asp:Label runat="server">Linea*</asp:Label>
                       <asp:TextBox CssClass="input is-large" runat="server" ID="Lineatx"  ValidationGroup="vg1" MaxLength="20" ></asp:TextBox>
                       <asp:RequiredFieldValidator id="RequiredFieldValidator2"  ValidationGroup="vg1" runat="server" ControlToValidate="Lineatx" ErrorMessage="Por favor ingrese una linea valida."  ForeColor="Red" />
                  </div>
              </div>
              <div class="field">
                  <div class="control">
                        <asp:Label runat="server">Placa*</asp:Label>
                        <asp:TextBox CssClass="input is-large" runat="server" ID="Placatx"  ValidationGroup="vg1" MaxLength="10" ></asp:TextBox>
                        <asp:RequiredFieldValidator id="RequiredFieldValidator3"  ValidationGroup="vg1" runat="server" ControlToValidate="Placatx" ErrorMessage="Por favor ingrese una placa valida."  ForeColor="Red" />
                  </div>
              </div>

             <div class="field">
                  <div class="control">
                        <asp:Label runat="server">Color*</asp:Label>
                        <asp:TextBox runat="server" ID="Colortx" CssClass="input is-large"   ValidationGroup="vg1" MaxLength="20" ></asp:TextBox>
                        <asp:RequiredFieldValidator id="RequiredFieldValidator4"  ValidationGroup="vg1" runat="server" ControlToValidate="Colortx" ErrorMessage="Por favor ingrese un color valido."  ForeColor="Red" />
                  </div>
              </div>

            <div class="field">
                <div class="control">
                 <asp:Label runat="server">Ciudad placa*</asp:Label>
                 <asp:TextBox runat="server" ID="CiudadPtx" CssClass="input is-large"  ValidationGroup="vg1" MaxLength="20" ></asp:TextBox>
                 <asp:RequiredFieldValidator id="RequiredFieldValidator5" runat="server"  ValidationGroup="vg1" ControlToValidate="CiudadPtx" ErrorMessage="Por favor ingrese una ciudad valida."  ForeColor="Red" />
                </div>
            </div>
                 
            <div class="field">
                <div class="control">
                    <asp:Label runat="server">Modelo*</asp:Label>
                    <asp:TextBox runat="server" placeholder="aaaa" ID="Modelotx"  ValidationGroup="vg1" CssClass="input is-large" MaxLength="4" TextMode="Number" ></asp:TextBox>
                    <asp:RequiredFieldValidator id="RequiredFieldValidator6" runat="server"  ValidationGroup="vg1" ControlToValidate="Modelotx" ErrorMessage="Por favor ingrese un modelo valido."  ForeColor="Red" />
                </div>
            </div>

           <div class="field">
                <div class="control">
                    <asp:Label  ValidationGroup="vg1" runat="server">Tipo combustible*</asp:Label>
                    <asp:DropDownList CssClass="select is-large" ValidationGroup="vg1" ID="TipoCombustibletx" runat="server">
                        <asp:ListItem Enabled="true" Value="Default">--</asp:ListItem>
                        <asp:ListItem Enabled="true" Value="Gasolina">Gasolina</asp:ListItem>
                        <asp:ListItem Enabled="true" Value="Gas">Gas</asp:ListItem>
                        <asp:ListItem Enabled="true" Value="Gaso-Gas">Gasolina - Gas</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator  ValidationGroup="vg1" InitialValue="Default" id="RequiredFieldValidator7" runat="server" ControlToValidate="TipoCombustibletx" ErrorMessage="Por favor seleccione el tipo de combustible."  ForeColor="Red" />
                </div>
            </div>

            <div class="field">
                <div class="control">
                    <asp:Label   ValidationGroup="vg1" runat="server">Tipo vehículo*</asp:Label>
                    <asp:DropDownList CssClass="select is-large"  ValidationGroup="vg1" ID="TipoVehiculotx" runat="server">
                    <asp:ListItem Enabled="true" Value="Default">--</asp:ListItem>
                    <asp:ListItem Enabled="true" Value="Automovil">Automóvil</asp:ListItem>
                    <asp:ListItem Enabled="true" Value="Camioneta">Camioneta</asp:ListItem>
                    <asp:ListItem Enabled="true" Value="Moto">Moto</asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator  ValidationGroup="vg1" InitialValue="Default" id="RequiredFieldValidator8" runat="server" ControlToValidate="TipoVehiculotx" ErrorMessage="Por favor seleccione el tipo de combustible."  ForeColor="Red" />

                </div>
            </div>

            <div class="field">
               <div class="control">
                   <asp:Label   ValidationGroup="vg1" runat="server">Vacantes*</asp:Label>
                   <asp:TextBox  ValidationGroup="vg1" runat="server" ID="Vacantestx" CssClass="input is-large" MaxLength="1" TextMode="Number" ></asp:TextBox>
                   <asp:RequiredFieldValidator   ValidationGroup="vg1" id="RequiredFieldValidator9" runat="server" ControlToValidate="Vacantestx" ErrorMessage="Por favor ingrese un número valido de vacantes"  ForeColor="Red" />
                </div>
            </div>

            <div class="field">
               <div class="control">
                   <asp:Label ID="Result"  ValidationGroup="vg1" runat="server" Visible="false"/>
                </div>
             </div>

              <div class="field">
                   <asp:Button runat="server"  ValidationGroup="vg1" ID="submit_form" Text="Guardar" CssClass="button is-block is-info is-large" OnClick="submit_form_Click"/>
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