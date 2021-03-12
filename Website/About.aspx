<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Website.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your contact page.</h3>
    <address>
        Holbæk<br />
        Humlebivej 12<br />
        <abbr title="Phone">Tlf:</abbr>
        +45 9999 9999
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:Rasmus@Gmail.dk">Rasmus@Gmail.dk</a><br />
    </address>
</asp:Content>

