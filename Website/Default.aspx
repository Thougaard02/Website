<%@ Page Title="Kino" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Website._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <div class="jumbotron" id="image">
        <h1>Giv en Biograftur for 2</h1>
        <p class="lead">Og støt din lokale biograf</p>
        <p><a href="#" class="btn btn-primary btn-lg">Læs mere her</a></p>
    </div>

    <asp:PlaceHolder ID="MovieTitle" runat="server"></asp:PlaceHolder>
</asp:Content>
