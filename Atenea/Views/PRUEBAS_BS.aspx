<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PRUEBAS_BS.aspx.cs" Inherits="Atenea.Views.PRUEBAS_BS" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label  runat="Server"  Text =" Controlador de Idiomas"/>
    <asp:Button ID="btnAdd"     runat="Server" Text="ADD   " OnClick="addBTNidioma" />
    <asp:Button ID="btnDelete"  runat="Server" Text="DELETE" OnClick="deleteBTNidioma" />
    <asp:Button ID="btnModify"  runat="Server" Text="MODIFY" OnClick="modifyBTNidioma" />

    </div>
    <div>
    <asp:Label  runat="Server"  Text =" Controlador de Categorias"/>
    <asp:Button ID="Button1"    runat="Server"  Text="ADD   " OnClick="addBTNcat" />
    <asp:Button ID="Button2"    runat="Server"  Text="DELETE" OnClick="deleteBTNcat" />
    <asp:Button ID="Button3"    runat="Server"  Text="MODIFY" OnClick="modifyBTNcat" />
    </div>

    <div>
    <asp:Label  runat="Server"  Text =" Controlador de Palabras"/>
    <asp:Button ID="Button4"    runat="Server"  Text="ADD   " OnClick="addBTNplb" />
    <asp:Button ID="Button5"    runat="Server"  Text="DELETE" OnClick="deleteBTNplb" />
    <asp:Button ID="Button6"    runat="Server"  Text="MODIFY" OnClick="modifyBTNplb" />
    </div>

    </form>
</body>
</html>
