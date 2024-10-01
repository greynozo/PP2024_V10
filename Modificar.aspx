<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Modificar.aspx.cs" Inherits="PP2024_V10.Modificar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="content" class="p-4 p-md-5">
        <nav class="navbar navbar-expand-lg navbar-light bg-light">
          <div class="container-fluid">

            <button type="button" id="sidebarCollapse" class="btn btn-primary">
              <i class="fa fa-bars"></i>
              <span class="sr-only">Toggle Menu</span>
            </button>
            <button class="btn btn-dark d-inline-block d-lg-none ml-auto" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                <i class="fa fa-bars"></i>
            </button>

            <div class="collapse navbar-collapse" id="navbarSupportedContent">
              <ul class="nav navbar-nav ml-auto">
                <li class="nav-item active">
                    <a class="nav-link" href="#">Home</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="#">About</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="#">Portfolio</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="#">Contact</a>
                </li>
              </ul>
            </div>
          </div>
        </nav>
        <h2 class="mb-4">
            Default</h2>
        <table>
            <tr>
                <td>
                    <asp:Label Text="Nombre" ID="lblNombre" runat="server" />
                </td>
                <td>
                    <asp:TextBox CssClass="form-control" ID="txtNombre" runat="server" />
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label Text="Email" ID="lblMail" runat="server" />
                </td>
                <td>
                    <asp:TextBox CssClass="form-control" ID="txtEmail" runat="server" />
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label Text="Nota" ID="lblNota" runat="server" />
                </td>
                <td>
                    <asp:TextBox TextMode="Number" CssClass="form-control" ID="txtNota" runat="server" />
                </td>
                <td>
                  
                </td>
            </tr>
            
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblTexto" Font-Bold="true" ForeColor="Red" Text="" runat="server" />
                </td>
            </tr>
        </table>
        <br />
        <asp:Label Visible ="false" ID="lblMensaje" ForeColor="Red" runat="server"></asp:Label>
        <asp:Button Text="Guardar" CssClass="btn btn-success" ID="btnGuardar" 
            runat="server" onclick="btnGuardar_Click"/>
    </div>
</asp:Content>
