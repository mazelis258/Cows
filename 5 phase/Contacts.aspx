<%@ Page MasterPageFile="header.Master" Language="C#" AutoEventWireup="true" CodeBehind="Contacts.aspx.cs" Inherits="_5_phase.Contacts" %>

<asp:Content ContentPlaceHolderID="CPH1" runat="server">
 

    <script src="https://maps.googleapis.com/maps/api/js?v=3.exp"></script>
    <script>
        function initialize() {
            var myLatlng = new google.maps.LatLng(55.313191, 24.851798);
            var mapOptions = {
                zoom: 16,
                center: myLatlng
            }
            var map = new google.maps.Map(document.getElementById('map-canvas'), mapOptions);

            var marker = new google.maps.Marker({
                position: myLatlng,
                map: map,
                title: 'Home'
            });
        }

        google.maps.event.addDomListener(window, 'load', initialize);

    </script>


    <h1>Contacts</h1>


    <ul>
        <li>Address: Šviesos gatvė, Šventupė 20355, Lietuvos Respublika</li>
        <li>Phone number: +37063648309</li>

    </ul>

    <div id='map-canvas' style="width: 400px; height: 300px"></div>

</asp:Content>
