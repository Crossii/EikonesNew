<%@ Page Title="" Language="C#" MasterPageFile="~/Vorlage.Master" AutoEventWireup="true" CodeBehind="Start.aspx.cs" Inherits="Eikones.Start" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>Wilkommen bei Einkones, dem Lehrer- Lernprogramm</p>
    <asp:Button ID="btStart" runat="server" Text="Start" OnClick="btStart_Click"/>
</asp:Content>
