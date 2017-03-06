<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Application.aspx.cs" Inherits="Application" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        name:
        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="REVtxtUserName" ControlToValidate="txtUserName" ValidationGroup="VRegister" runat="server" ErrorMessage="لطفا فقط حروف فارسی وارد نمایید" ValidationExpression="^[\u0600-\u06FF\uFB8A\u067E\u0686\u06AF]+$"></asp:RegularExpressionValidator>
        <br />
        family:<asp:TextBox ID="txtFamilyName" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RFVtxtFamilyName" ControlToValidate="txtFamilyName" ValidationGroup="VRegister" runat="server" ErrorMessage="لطفا فقط حروف فارسی وارد نمایید" ValidationExpression="^[\u0600-\u06FF\uFB8A\u067E\u0686\u06AF]+$"></asp:RegularExpressionValidator>

        <br />
        EmailActive:<asp:TextBox ID="txtUserEmailActive" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="BtnSend" runat="server" OnClick="BtnSend_Click" ValidationGroup="VRegister" Text="send" />
       <h1>this is my test </h1>
    </form>
</body>
</html>
