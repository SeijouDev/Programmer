<%@ Page  Title="Buscar rutas" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BuscarRutas.aspx.cs" Inherits="Front.BuscarRutas" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <section class="hero is-success is-fullheight">
        <div class="hero-body">
            <div class="container has-text-centered">
                <div class="column is-8 is-offset-2">
                    <h3 class="title has-text-grey">Buscar rutas</h3>
                    <div class="box">

                        <div class="field">
                            <div class="control">
                                <asp:TextBox  CssClass="input is-large" runat ="server" ID="Searchbox" MaxLength="20" ValidationGroup="vg1" placeholder="Ingresa una dirección de inicio o destino para realizar la busqueda" ></asp:TextBox>
                                <asp:Button ValidationGroup="vg1" runat="server" ID="submit_form" Text="Buscar" CssClass="button is-block is-info is-large" OnClick="Search"/>
                            </div>
                        </div>

                        <div class="field">
                            <div class="control">
                                <asp:gridview id="ListaRutasGv" autogeneratecolumns="false"  runat="server" CssClass="table" OnRowCommand="Gridview_RowCommand">
                                    <Columns>
                                        <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                                        <asp:BoundField HeaderText="Dirección Inicio" DataField="DireccionPuntoInicio" />
                                        <asp:BoundField HeaderText="Dirección Destino" DataField="DireccionPuntoFinal" />

                                        <asp:TemplateField HeaderText="Acciones">
                                            <ItemTemplate>
                                                <asp:LinkButton ID="lnkSelect" runat="server" CommandArgument='<%#Eval("Nombre")+":"+ Eval("fkPrestador")%>' Text = "Seleccionar"></asp:LinkButton>
                                            </ItemTemplate>                
                                        </asp:TemplateField>
                                    </Columns>
                                </asp:gridview>
                            </div>
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