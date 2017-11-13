<%@ Page Title="Rutas" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="ListaRuta.aspx.cs" Inherits="Front.ListaRuta" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 

        <section class="hero is-success is-fullheight">
            <div class="hero-body">
                <div class="container has-text-centered">
                    <div class="column is-8 is-offset-2">
                        <h1 class="title has-text-grey">Mis rutas</h1>
                        <div class="field">
                            <div class="control">
                                 <asp:gridview id="ListaRutasGv" autogeneratecolumns="false"  runat="server" CssClass="table">
                                    <Columns>
                                         <asp:TemplateField HeaderText = "Nombre">
                                            <ItemTemplate>                       
                                                <asp:Label ID="NombreRuta" runat="server"  Text='<%# Eval("Nombre")%>'></asp:Label>           
                                            </ItemTemplate>
                                        </asp:TemplateField>

                                        <asp:TemplateField HeaderText = "Dirección de inicio">
                                            <ItemTemplate>                       
                                                <asp:Label ID="DireccionInicio" runat="server"  Text='<%# Eval("DireccionPuntoInicio")%>'></asp:Label>           
                                            </ItemTemplate>
                                        </asp:TemplateField>

                                        <asp:TemplateField HeaderText = "Dirección de destino">
                                            <ItemTemplate>                       
                                                <asp:Label ID="DireccionFin" runat="server"  Text='<%# Eval("DireccionPuntoFinal")%>'></asp:Label>           
                                            </ItemTemplate>
                                        </asp:TemplateField>                                        
                                    </Columns>
                                </asp:gridview>
                            </div>
                        </div>

                             
                                                     
                        <% if( Convert.ToInt32(Session["rol"]) == 0) { %>               
                               <div class="field">
                                    <div class="control">
                                        <a class="button is-block is-info is-large" href="Ruta.aspx">Crear rutas</a>
                                    </div>
                                </div>
                         <% } %>
                        
    
                        <div class="field">
                            <div class="control">
                                <asp:Button runat="server" ID="btnBack" Text="Volver" CssClass="button is-block is-danger is-large" OnClick="back_click"/>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
    

</asp:Content>