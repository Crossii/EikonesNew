<%@ Page Title="" Language="C#" MasterPageFile="~/Vorlage.Master" AutoEventWireup="true" CodeBehind="Klassenauswahl.aspx.cs" Inherits="Eikones.Klassenauswahl" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ListView ID="ListView1" runat="server" DataKeyNames="K_ID" DataSourceID="SqlDataSource1" GroupItemCount="3">
        <AlternatingItemTemplate>
            <td runat="server" style="background-color: #FAFAD2;color: #284775;">K_ID:
                <asp:Label ID="K_IDLabel" runat="server" Text='<%# Eval("K_ID") %>' />
                <br /></td>
        </AlternatingItemTemplate>
        <EditItemTemplate>
            <td runat="server" style="background-color: #FFCC66;color: #000080;">K_ID:
                <asp:Label ID="K_IDLabel1" runat="server" Text='<%# Eval("K_ID") %>' />
                <br />
                <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Aktualisieren" />
                <br />
                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Abbrechen" />
                <br /></td>
        </EditItemTemplate>
        <EmptyDataTemplate>
            <table runat="server" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
                <tr>
                    <td>Es wurden keine Daten zurückgegeben.</td>
                </tr>
            </table>
        </EmptyDataTemplate>
        <EmptyItemTemplate>
<td runat="server" />
        </EmptyItemTemplate>
        <GroupTemplate>
            <tr id="itemPlaceholderContainer" runat="server">
                <td id="itemPlaceholder" runat="server"></td>
            </tr>
        </GroupTemplate>
        <InsertItemTemplate>
            <td runat="server" style="">K_ID:
                <asp:TextBox ID="K_IDTextBox" runat="server" Text='<%# Bind("K_ID") %>' />
                <br />
                <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Einfügen" />
                <br />
                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Löschen" />
                <br /></td>
        </InsertItemTemplate>
        <ItemTemplate>
            <td runat="server" style="background-color: #FFFBD6;color: #333333;">K_ID:
                <asp:Label ID="K_IDLabel" runat="server" Text='<%# Eval("K_ID") %>' />
                <br /></td>
        </ItemTemplate>
        <LayoutTemplate>
            <table runat="server">
                <tr runat="server">
                    <td runat="server">
                        <table id="groupPlaceholderContainer" runat="server" border="1" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                            <tr id="groupPlaceholder" runat="server">
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr runat="server">
                    <td runat="server" style="text-align: center;background-color: #FFCC66;font-family: Verdana, Arial, Helvetica, sans-serif;color: #333333;"></td>
                </tr>
            </table>
        </LayoutTemplate>
        <SelectedItemTemplate>
            <td runat="server" style="background-color: #FFCC66;font-weight: bold;color: #000080;">K_ID:
                <asp:Label ID="K_IDLabel" runat="server" Text='<%# Eval("K_ID") %>' />
                <br /></td>
        </SelectedItemTemplate>
    </asp:ListView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:eikonesConnectionString %>" ProviderName="<%$ ConnectionStrings:eikonesConnectionString.ProviderName %>" SelectCommand="SELECT K_ID FROM tklassen"></asp:SqlDataSource>
    <asp:Button ID="btAuswahl" runat="server" Text="Weiter" OnClick="btAuswahl_Click"/>
</asp:Content>
