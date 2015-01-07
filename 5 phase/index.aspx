<%@ Page MasterPageFile="header.Master" Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="_5_phase.WebForm1" %>


<asp:Content ContentPlaceHolderID="CPH1" runat="server">

    <h1>Home</h1>

    <article id="article1">
        <p>Hello</p>

        <p>Time now is:</p>
        <asp:ScriptManager ID="ScriptManager1" runat="server" />
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="Timer1_Tick"></asp:Timer>
                    <p><asp:Label ID="Label1" runat="server" Text="date"></asp:Label></p>
                 
            </ContentTemplate>
        </asp:UpdatePanel>
       


    </article>



</asp:Content>

