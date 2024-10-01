<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Vista.aspx.cs" Inherits="PP2024_V10.Vista" %>

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
            Inicio</h2>
        <p>
        
        <asp:GridView ID="GridView1" runat="server" CssClass="table table-sm table-hover" 
                Style="width:100%" AutoGenerateColumns="False" DataKeyNames="ID"
            DataSourceID="SqlDataSource1" onrowcommand="GridView1_RowCommand">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True"
                    SortExpression="ID" />
                <asp:BoundField DataField="NOMBRE" HeaderText="NOMBRE" SortExpression="NOMBRE" />
                <asp:BoundField DataField="EMAIL" HeaderText="EMAIL" SortExpression="EMAIL" />
                <asp:BoundField DataField="NOTA" HeaderText="NOTA" SortExpression="NOTA" />
                <asp:TemplateField HeaderText="Editar">
                    <ItemTemplate> 
                        <asp:ImageButton runat="server" ID="btnEditar" CssClass="btn btn-danger" CommandName="Editar" CommandArgument='<%# Container.DataItemIndex.ToString() %>' ImageUrl="~/Estilos/images/editar.png"></asp:ImageButton>
                        <asp:Button  ID="btnModificar" runat="server" CssClass="btn btn-success" CommandName="Editar" Text="Editar" CommandArgument='<%# Container.DataItemIndex.ToString() %>'/>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CadenaConexionPP2024 %>"
            SelectCommand="SELECT * FROM [ALUMNOS]"></asp:SqlDataSource>
            </p>
    </div>
</asp:Content>
