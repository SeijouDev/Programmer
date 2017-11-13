<%@  Page Title="Vehículos" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="ListaVehiculo.aspx.cs" Inherits="Front.ListaVehiculo" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <section class="hero is-success is-fullheight">
        <div class="hero-body">
          <div class="container has-text-centered">
            <div class="column is-8 is-offset-2">
                <h1 class="title has-text-grey">Mis vehículos</h1>
                <div class="field">
                        <div class="control">
                            <asp:gridview id="ListaVehiculosGv" autogeneratecolumns="false"  runat="server" CssClass="table">
                                <Columns>
                                <asp:BoundField HeaderText="Marca" DataField="Marca" />
                                <asp:BoundField HeaderText="Linea" DataField="Linea" />
                                <asp:BoundField HeaderText="Placa" DataField="Placa" />
                                <asp:BoundField HeaderText="Color" DataField="Color" />
                                <asp:BoundField HeaderText="Ciudad" DataField="CiudadPlaca" />
                                <asp:BoundField HeaderText="Modelo" DataField="Modelo" />
                                <asp:BoundField HeaderText="Combustible" DataField="TipoCombustible" />
                                <asp:BoundField HeaderText="Tipo" DataField="ClaseVehiculo" />
                                <asp:BoundField HeaderText="Vacantes" DataField="Vacantes" />
                                <asp:TemplateField HeaderText="Editar">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lnkRemove" runat="server"  CommandArgument = '<%# Eval("Placa")%>' Text = "Editar"></asp:LinkButton>
                                    </ItemTemplate>                
                                </asp:TemplateField>

                                <asp:TemplateField HeaderText="Eliminar">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lnkRemove" runat="server"  CommandArgument = '<%# Eval("Placa")%>' OnClientClick = "return confirm('¿ Realmente desea eliminar esta ruta ?')" Text = "Eliminar"></asp:LinkButton>
                                    </ItemTemplate>                
                                </asp:TemplateField>
                            </Columns>
                            </asp:gridview>
                        </div>
                    </div>

                <div class="field">
                    <div class="control">
                        <a class="button is-block is-info is-large" href="Vehiculo.aspx">Crear vehículo</a>
                    </div>
                </div>

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
