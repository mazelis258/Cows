<%@ Page MasterPageFile="header.Master" Language="C#" AutoEventWireup="true" CodeBehind="AddCow.aspx.cs" Inherits="_5_phase.AddCow" %>

<asp:Content ContentPlaceHolderID="CPH1" runat="server">
    <h3>cow's name</h3>
    <asp:TextBox ID="CowsName" runat="server" CausesValidation="True"></asp:TextBox>
     <h3>cow's number</h3>
    <asp:TextBox ID="CowsNumber" runat="server" CausesValidation="True"></asp:TextBox>
     <h3>cow's birth date</h3>
    <asp:TextBox ID="CowsBirth" runat="server" CausesValidation="True"></asp:TextBox>
     <h3>cow's death name</h3>
    <asp:TextBox ID="CowsDeath" runat="server" CausesValidation="True"></asp:TextBox><br />
    <asp:Button ID="ButtonADD" runat="server" Text="AddCows" OnClick="ButtonAdd_Click" />
</asp:content>
