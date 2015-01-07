<%@ Page MasterPageFile="header.Master" Language="C#" AutoEventWireup="true" CodeBehind="Cows.aspx.cs" Inherits="_5_phase.Cows" %>

<asp:Content ContentPlaceHolderID="CPH1" runat="server">

    
    <asp:GridView ID="GridView1"  AllowSorting="true" OnSorting="SortRecords" runat="server" AutoGenerateColumns="false">
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        
        <Columns>
            <asp:TemplateField>
                <ItemTemplate >
                    <asp:CheckBox ID="chkCtrl" runat="server"  />
                </ItemTemplate>
            </asp:TemplateField>
            
            <asp:BoundField SortExpression="nr" DataField="nr" HeaderText="cow's number" ItemStyle-Width="200" />
            <asp:BoundField SortExpression="vardas" DataField="vardas" HeaderText="cow's name" ItemStyle-Width="200" />
            <asp:BoundField SortExpression="gim_data" DataField="gim_data" HeaderText="cow's birth" ItemStyle-Width="200" />
            <asp:BoundField SortExpression="mir_data" DataField="mir_data" HeaderText="cow's death" ItemStyle-Width="200" />
        </Columns>
    </asp:GridView>
    <asp:Button ID="DeleteButton" runat="server" Text="Delete" OnClick="DeleteButtonClick"/>

</asp:Content>

