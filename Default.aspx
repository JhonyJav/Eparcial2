<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Eparcial2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Ingreso de animales </h1>
        <p>&nbsp;</p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Animal</h2>
            <p>
                &nbsp;Nombre propio:
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;Especie:
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;Tipo de Alimentacion
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
&nbsp;Tiempo maximo de vida<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                <asp:Button ID="Button1animal" runat="server" OnClick="Button1animal_Click" Text="ingresar animal" Width="229px" />
            </p>
            <p>
                &nbsp;</p>
        </div>
        <div class="col-md-4">
            <h2>Aves</h2>
            <p>El ave vuela
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
&nbsp;Periodo de Incubacion:
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="Button1ave" runat="server" OnClick="Button1ave_Click" Text="Ingreso ave" Width="195px" />
            </p>
        </div>
        <div class="col-md-4">
            <h2>Serpiente</h2>
            <p>
                Es venonosa?
                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                Longitud maxima (en metros)<asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                <asp:Button ID="Button1serpiente" runat="server" OnClick="Button1serpiente_Click" Text="ingreso serpiente" Width="177px" />
            </p>
        </div>
    </div>

</asp:Content>
