<%@ Page Title="" Language="C#" MasterPageFile="~/Vorlage.Master" AutoEventWireup="true" CodeBehind="Klassenauswahl.aspx.cs" Inherits="Eikones.Klassenauswahl" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1"></asp:ListView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:eikonesConnectionString %>" ProviderName="<%$ ConnectionStrings:eikonesConnectionString.ProviderName %>" SelectCommand="SELECT K_ID FROM tklassen"></asp:SqlDataSource>
    <asp:Button ID="btAuswahl" runat="server" Text="Weiter" OnClick="btAuswahl_Click"/>
</asp:Content>
