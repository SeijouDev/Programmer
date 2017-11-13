<%@ Page Title="Nueva ruta" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ruta.aspx.cs" Inherits="Front.Ruta" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <section class="hero is-success is-fullheight">
        <div class="hero-body">
            <div class="container has-text-centered">
                <div class="column is-8 is-offset-2">
                    <h3 class="title has-text-grey">Nueva ruta</h3>
                    <div class="box">

                        <div class="field">
                            <div class="control">
                                <asp:Label runat="server">Nombre*</asp:Label>
                                <asp:TextBox  CssClass="input is-large" runat ="server" ID="Nombre" MaxLength="20" ValidationGroup="vg1" ></asp:TextBox>
                                <asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" ValidationGroup="vg1" ControlToValidate="Nombre" ErrorMessage="Por favor ingrese un nombre valido."  ForeColor="Red" />
                            </div>
                        </div>

                        <div class="field">
                            <div class="control">
                                <asp:Label runat="server">Direccion inicio*</asp:Label>
                                <asp:TextBox runat="server" ID="DireccionInicio" CssClass="input is-large" ValidationGroup="vg1" MaxLength="20" placeholder="Desliza el marker en el mapa"></asp:TextBox>
                                <asp:RequiredFieldValidator id="RequiredFieldValidator4" runat="server" ValidationGroup="vg1" ControlToValidate ="DireccionInicio"   ErrorMessage="Ingrese una dirección valida"   ForeColor="Red" /> 
                            </div>
                        </div>

                        <div class="field">
                            <div class="control">
                                <asp:Label runat="server">Direccion Destino*</asp:Label>
                                <asp:TextBox  runat="server" ID="DireccionDestino" CssClass="input is-large" ValidationGroup="vg1" placeholder="Desliza el marker en el mapa" MaxLength="20" ></asp:TextBox>
                                <asp:RequiredFieldValidator id="RequiredFieldValidator7" runat="server" ValidationGroup="vg1" ControlToValidate="DireccionDestino" ErrorMessage="Ingrese una dirección valida"  ForeColor="Red" /> 
                            </div>
                        </div>

                        <div class="field">
                            <div class="control">
                                <asp:Label runat="server" ValidationGroup="vg1" >Vehiculo*</asp:Label>
                                <asp:DropDownList ID="VehiculoDropdown" ValidationGroup="vg1" runat="server"  CssClass="select is-large">
                                    <asp:ListItem Enabled="true" Value="Default">--</asp:ListItem>
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ValidationGroup="vg1" InitialValue="Default" id="RequiredFieldValidator8" runat="server" ControlToValidate="VehiculoDropdown" ErrorMessage="Por favor seleccione un vehículo."  ForeColor="Red" />
                            </div>
                        </div>

                        <div class="field">
                            <div class="control">
                                <div id="map" style="width:850px; height:300px"></div>
                            </div>
                        </div>

                        <div class="field">
                             <asp:Label ValidationGroup="vg1" ID="Result" runat="server" Visible="false"/>
                        </div>

                        <div class="field">
                            <asp:Button ValidationGroup="vg1" runat="server" ID="submit_form" Text="Guardar" CssClass="button is-block is-info is-large" OnClick="submit_form_Click"/>
                        </div>

                        <div class="field">
                             <asp:Button runat="server" ID="btnBack" Text="Volver" CssClass="button is-block is-danger is-large" OnClick="back_click"/>
                        </div>

                    </div>
                </div>
          </div>
        </div>
    </section>

    <asp:HiddenField ID="hdlatIni" runat="server" ClientIDMode="Static" />
    <asp:HiddenField ID="hdlngIni" runat="server" ClientIDMode="Static" />
    <asp:HiddenField ID="hdlatFin" runat="server" ClientIDMode="Static" />
    <asp:HiddenField ID="hdlngFin" runat="server" ClientIDMode="Static" />   

    <script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyCKokH7uxbcyd1r6n0qrz1ILDv988Qhxpg &callback=initMap"  async defer></script>
    <script>
        function initMap() {
            var map = new google.maps.Map(document.getElementById('map'), {
                center: { lat: 4.6295007, lng: -74.0722461},
                zoom: 15
            });

            var myLatlng = new google.maps.LatLng(4.6295007, -74.0722461);
            var markerInicio = new google.maps.Marker({
                title: "Inicio de trayecto",
                position: myLatlng,
                map: map, 
                icon: "http://maps.google.com/mapfiles/ms/icons/green-dot.png",
                draggable: true
            });
            
            var markerFin = new google.maps.Marker({
                title: "Fin de trayecto",
                position: myLatlng,
                map: map,
                icon: "http://maps.google.com/mapfiles/ms/icons/red-dot.png" ,
                draggable: true
            });

            google.maps.event.addListener(markerInicio, 'dragend', function (evt) {
                
                var url = "http://nominatim.openstreetmap.org/reverse?format=json&lat=" + evt.latLng.lat() + "&lon=" + evt.latLng.lng() + "&zoom=18&addressdetails=1";

                $.ajax({
                    type: "GET",
                    url: url,
                    error: function (XMLHttpRequest, textStatus, errorThrown) {
                        alert("Request: " + XMLHttpRequest.toString() + "\n\nStatus: " + textStatus + "\n\nError: " + errorThrown);
                    },
                    complete: function (jqXHR, status) {
                        let j = JSON.parse(jqXHR.responseText);
                        document.getElementById("MainContent_DireccionInicio").value = j.display_name;
                        document.getElementById("hdlatIni").value = evt.latLng.lat();
                        document.getElementById("hdlngIni").value = evt.latLng.lng();
                    }
                    
                });

                
                console.log(url);
            });


            google.maps.event.addListener(markerFin, 'dragend', function (evt) {

                var url = "http://nominatim.openstreetmap.org/reverse?format=json&lat=" + evt.latLng.lat() + "&lon=" + evt.latLng.lng() + "&zoom=18&addressdetails=1";

                $.ajax({
                    type: "GET",
                    url: url,
                    error: function (XMLHttpRequest, textStatus, errorThrown) {
                        alert("Request: " + XMLHttpRequest.toString() + "\n\nStatus: " + textStatus + "\n\nError: " + errorThrown);
                    },
                    complete: function (jqXHR, status) {
                        let j = JSON.parse(jqXHR.responseText);
                        document.getElementById("MainContent_DireccionDestino").value = j.display_name;   

                        document.getElementById("hdlatFin").value = evt.latLng.lat();
                        document.getElementById("hdlngFin").value = evt.latLng.lng();
                    }
                });

            });         
        }
    </script>

    <br />
   


   

</asp:Content>