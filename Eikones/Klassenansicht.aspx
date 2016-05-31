
<%@ Page Title="" Language="C#" MasterPageFile="~/Vorlage.Master" AutoEventWireup="true" CodeBehind="Klassenansicht.aspx.cs" Inherits="Eikones.Klassenansicht" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>Prägen sie sich die Gesichter und die Namen gut ein. Sind sie damit fertig geht es weiter mit einem kleinen Test.</p>
    <asp:Table ID="tbSchueler" runat="server"></asp:Table>
    <asp:Button ID="btAnsicht" runat="server" Text="Weiter zum Test" OnClick ="btAnsicht_Click"/>
</asp:Content>
