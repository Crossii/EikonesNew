<%@ Page Title="" Language="C#" MasterPageFile="~/Vorlage.Master" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="Eikones.Test" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="btUeberpruefen" runat="server" Text="Überprüfen" OnClick="btUeberpruefen_Click" />
</asp:Content>
