<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Practica_2_EjerProp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .Imagen {
            height: 211px;
            width: 332px;
            margin-left: 166px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Registro de electrodomésticos" 
            Width="479px" Height="36px" Font-Bold="True" Font-Name="Arial Black"
            Font-Size="X-Large" ></asp:Label>
        </div>
        <p class="Artefactos">
            <asp:Label ID="Label2" runat="server" Text="Artefacto"></asp:Label>&nbsp;
            <asp:DropDownList ID="Artefactos" runat="server" Autopostback="True" OnSelectedIndexChanged="SelectedIndexChanged"></asp:DropDownList>
        </p>
        <p class="CodigoNombre">
            <asp:Label ID="Label4" runat="server" Text="Codigo"></asp:Label>&nbsp;
            <asp:TextBox ID="Codigo" runat="server" Height="24px" Width="230px"></asp:TextBox>&nbsp;
            <asp:Label ID="Label6" runat="server" Text="Nombre"></asp:Label>&nbsp;
            <asp:TextBox ID="Nombre" runat="server" Height="24px" Width="230px"></asp:TextBox>
        </p>
        <p class="DescripcionMarca">
            <asp:Label ID="Label3" runat="server" Text="Descripción"></asp:Label>&nbsp;
            <asp:TextBox ID="Descripcion" runat="server" Height="24px" Width="230px"></asp:TextBox>&nbsp;
            <asp:Label ID="Label5" runat="server" Text="Marca"></asp:Label>&nbsp;
            <asp:TextBox ID="Marca" runat="server" Height="24px" Width="230px"></asp:TextBox>
        </p>
        <p class="Imagen">
            <asp:Image ID="Image1" runat="server"/>
        </p>
    </form>
</body>
</html>
