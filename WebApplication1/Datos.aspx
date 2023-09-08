<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Datos.aspx.cs" Inherits="WebApplication1.Datos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>acceso a ado .net</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-4bw+/aepP/YC94hEpVNVgiZdgIC5+VKNBQNGCHeKRQN+PtmoHDEXuppvnDJzQIu9" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class ="jumbotron" >
                <p>ADO me conecta a una db</p>

            </div>
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Probar" />
&nbsp;&nbsp;
        <asp:Label ID="lblConectar" runat="server"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="metodo escalar" />
&nbsp;&nbsp;
            <asp:Label ID="lblEscalar" runat="server"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Reader" />
        </p>
        <p>
            <asp:Label ID="lblReader" runat="server"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="TopProducts" runat="server" OnClick="TopProducts_Click" Text="top ten productos" />
        </p>
        <p>
            <asp:Label ID="lblTopProducts" runat="server"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            desde:<asp:TextBox ID="TextBoxDesde" runat="server"></asp:TextBox>
        </p>
        <p>
            hasta:
            <asp:TextBox ID="TextBoxHasta" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Button" />
        </p>
        <p>
            <asp:Label ID="lblVentas" runat="server"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="nombre"></asp:Label>
            <asp:TextBox ID="TextBoxNombre" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="apellido"></asp:Label>
            <asp:TextBox ID="TextBoxApellido" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Guardar" />
            <asp:Label ID="lblResult" runat="server"></asp:Label>
        </p>
        <p>
            
            &nbsp;</p>
        <hr />
            <asp:Label ID="LblDatos" runat="server"></asp:Label>
        <hr />
        <p>
            <asp:Label ID="Label3" runat="server" Text="Modificar:"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            codigo:
            <asp:TextBox ID="TextBoxCodigo" runat="server"></asp:TextBox>
        </p>
        <p>
            nombre:
            <asp:TextBox ID="TextBoxNombreModificar" runat="server"></asp:TextBox>
        </p>
        <p>
            apellido:
            <asp:TextBox ID="TextBoxApellidoModificar" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Modificar" />
        </p>
        <p>
            <asp:Label ID="LblModificar" runat="server"></asp:Label>
        </p>
        <p>
            Eliminar:</p>
        <p>
            &nbsp;</p>
        <p>
            Codigo:
            <asp:TextBox ID="TextBoxEliminar" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="eliminar" />
        </p>
        <p>
            <asp:Label ID="lblEliminar" runat="server"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
