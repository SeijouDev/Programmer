<%@ Page Title="Página principal" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="LobbyPrincipal.aspx.cs" Inherits="Front.LobbyPrincipal" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   

    <section class="hero is-info  is-fullheight">
      <div class="hero-body">
        <div class="container">
              
          <h2 class="title" style="padding: 10px; margin: 5px auto">
              <a style="text-decoration: none; padding: 5%;" href="ListaRuta.aspx">
                  Mis Rutas
              </a>
          </h2>
            
            <% if( Convert.ToInt32(Session["rol"]) == 1) { %>               
                    <h2 class="title" style="padding: 10px; margin: 5px auto">
                        <a style="text-decoration: none;" href="BuscarRutas.aspx">
                            Buscar Rutas
                        </a>
                    </h2>
             <% } %>
        
             <% if( Convert.ToInt32(Session["rol"]) == 0) { %>               
                    <h2 class="title" style="padding: 10px; margin: 5px auto">
                        <a style="text-decoration: none;" href="ListaVehiculo.aspx">
                            Mis Vehículos
                        </a>
                    </h2>
             <% } %>

        </div>
      </div>
    <//section>

</asp:Content>