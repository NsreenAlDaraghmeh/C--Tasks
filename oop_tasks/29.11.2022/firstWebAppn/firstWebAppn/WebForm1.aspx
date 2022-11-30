<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="firstWebAppn.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <br />
        
    <asp:Label runat="server" Text="Enter Full Name"></asp:Label>



        &nbsp;&nbsp;&nbsp;&nbsp;


        
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>




        <br />
        <br />

        <asp:Label ID="Label1" runat="server" Text="Your Number"></asp:Label>
        
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>





        
    &nbsp;&nbsp;&nbsp;<br />
        <br />
&nbsp;<asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click1" />

        <br />
        <br />

        <asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>

        <br />
        <br />

        <asp:Button ID="Button2" runat="server"  Text="Button" OnClick="Button2_Click" />



    </form>
    
    
</body>
</html>
