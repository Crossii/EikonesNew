<%@ Page Title="" Language="C#" MasterPageFile="~/Vorlage.Master" AutoEventWireup="true" CodeBehind="Auswertung.aspx.cs" Inherits="Eikones.Auswertung" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="lbInfo" runat="server" Text="Label">
            <asp:Table runat="server">
                <asp:TableHeaderRow>
                    <asp:TableHeaderCell>insgesamte Fehler</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Namen die noch Probleme bereiten</asp:TableHeaderCell>
                </asp:TableHeaderRow>
                <asp:TableRow>
                    <asp:TableCell ID="tcFehler"></asp:TableCell>
                    <asp:TableCell ID="tcNamen"></asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </asp:Label>
    </div>
</asp:Content>
