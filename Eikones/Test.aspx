<%@ Page Title="" Language="C#" MasterPageFile="~/Vorlage.Master" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="Eikones.Test" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Image ID="imgSchueler" runat="server" />
    <br />
    <asp:TextBox ID="tbVorname" runat="server"></asp:TextBox>
    <asp:TextBox ID="tbNachname" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="btUeberpruefen" runat="server" Text="Überprüfen" OnClick="btUeberpruefen_Click" />
    <asp:Button ID="btNext" runat="server" Text="Weiter" OnClick="btNext_Click" />
    <asp:Button ID="btEnd" runat="server" Text="Beenden" OnClick="btEnd_Click"/>
    <br />
    <asp:Label ID="lbFeedback" runat="server" Text=""></asp:Label>
</asp:Content>
