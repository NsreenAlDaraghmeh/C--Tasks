<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="_30._11._2022.Calculator" %>


<%--<script>
Sub one()
    if text.text = "0"then
    text.text = "1"
    else
    text.text = text.text + "1"
    End if
End Sub


    Sub two()
    if text.text = "0"then
    text.text = "2"
    else
    text.text = text.text + "2"
    End if
End Sub


    Sub three()
    if text.text = "0"then
    text.text = "3"
    else
    text.text = text.text + "3"
    End if
End Sub


    Sub four()
    if text.text = "0"then
    text.text = "4"
    else
    text.text = text.text + "4"
    End if
End Sub


    Sub five()
    if text.text = "0"then
    text.text = "5"
    else
    text.text = text.text + "5"
    End if
End Sub


    Sub six()
    if text.text = "0"then
    text.text = "6"
    else
    text.text = text.text + "6"
    End if
End Sub


    Sub seven()
    if text.text = "0"then
    text.text = "7"
    else
    text.text = text.text + "7"
    End if
End Sub


    Sub eight()
    if text.text = "0"then
    text.text = "8"
    else
    text.text = text.text + "8"
    End if
End Sub


    Sub nine()
    if text.text = "0"then
    text.text = "9"
    else
    text.text = text.text + "9"
    End if
End Sub


    Sub zero()
    if text.text = "0"then
    text.text = "0"
    else
    text.text = text.text + "0"
    End if
End Sub

       Sub btn2()
    text.text = "0"
    TextBox1.text="0"



End Sub

       Sub btn4()
    text.text=text.text.Substring(0,text.text.Length -1 )
    if text.text=""then
    text.text = "0"
    End if

End Sub

       Sub btn7()
    if text.text.IndexOf(".") < 1 then
    text.text=text.text+"."
    End if


End Sub



    
       Sub btn1()
    TextBox2.text = 1
    TextBox1.text = val(text.text)
    text.text = "0"


End Sub

    
       Sub btn3()
    TextBox2.text = 2
    TextBox1.text = val(text.text)
    text.text = "0"


End Sub

    
       Sub btn5()
    TextBox2.text = 3
    TextBox1.text = val(text.text)
    text.text = "0"


End Sub

    
       Sub btn8()
    TextBox2.text = 4
    TextBox1.text = val(text.text)
    text.text = "0"


End Sub

           Sub btn6()
    if TextBox2.text = 1 then
    text.text = Double.Parse(TextBox1.text) + Double.Parse(text.text)
    else if TextBox2.text = 2 then
    text.text = Double.Parse(TextBox1.text) - Double.Parse(text.text)
    else if TextBox2.text = 3 then
    text.text = Double.Parse(TextBox1.text) * Double.Parse(text.text)
    else if TextBox2.text = 4 then
    text.text = Double.Parse(TextBox1.text) / Double.Parse(text.text)
    End if


End Sub

    

    
</script>--%><%--<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>WebCodes</title>
    <style>
        body{
            background-color:#808080;
        }
        #forms{
            margin:150px 490px ;
        }
        #text{
            width:336px;
            height:50px;
            text-align:right;
            padding-right:10px;
            outline:none;
            border:none;

        }
        #Button1 , #Button6 , #Button11{
            width:60px;
            height:40px;
            margin-top:7.5px;
            outline:none;
            border:none;
        }
        #Button2,#Button3,#Button7,#Button8,#Button12,#Button13,#Button4,#Button5,#Button9,#Button10,#Button14,#Button18,#Button17{
             width:60px;
            height:40px;
            margin-top:7.5px;
            margin-left:5px;
            border:none;
            outline:none;
        }
        #Button16{
            width:129px;
            height:40px;
            margin-top:7.5px;
            border:none;
            outline:none;
        }
        #Button15{
            width:60px;
            height:86px;
            position:absolute;
            margin-top:7.5px;
            margin-left:9px;
            border:none;
            outline:none;
        }
    </style>
    </head>
<body>
    <form id="forms" runat="server">

        <asp:TextBox ID="TextBox1" runat="server" Visible="false" ></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" Visible="false" ></asp:TextBox><br />
        <asp:TextBox ID="Text" runat="server" ReadOnly="True"></asp:TextBox><br />
        <asp:Button ID="Button1" runat="server" OnClick="one" Text="1" />
        <asp:Button ID="Button2" runat="server" OnClick="two" Text="2" />
        <asp:Button ID="Button3" runat="server" OnClick="three" Text="3" />
        <asp:Button ID="Button4" runat="server" OnClick="btn1" Text="+" />
        <asp:Button ID="Button5" runat="server" OnClick="btn2" Text="c" /><br />
        <asp:Button ID="Button6" runat="server" OnClick="four" Text="4" />
        <asp:Button ID="Button7" runat="server" OnClick="five" Text="5" />
        <asp:Button ID="Button8" runat="server" OnClick="six" Text="6" />
        <asp:Button ID="Button9" runat="server" OnClick="btn3" Text="-" />
        <asp:Button ID="Button10" runat="server" OnClick="btn4" Text="<" /><br />
        <asp:Button ID="Button11" runat="server" OnClick="seven" Text="7" />
        <asp:Button ID="Button12" runat="server" OnClick="eight" Text="8" />
        <asp:Button ID="Button13" runat="server" OnClick="nine" Text="9" />
        <asp:Button ID="Button14" runat="server" OnClick="btn5" Text="*" />
        <asp:Button ID="Button15" runat="server" OnClick="btn6" Text="=" /><br />
        <asp:Button ID="Button16" runat="server" OnClick="zero" Text="0" />
        <asp:Button ID="Button17" runat="server" OnClick="btn7" Text="." />
        <asp:Button ID="Button18" runat="server" OnClick="btn8" Text="/" />


    </form>


    </body>
</html>--%>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>WebCodes</title>
    <style>
        body{
            background-color:#808080;
        }
        #forms{
            margin:150px 490px ;
        }
        #text{
            width:336px;
            height:50px;
            text-align:right;
            padding-right:10px;
            outline:none;
            border:none;

        }
        #Button1 , #Button6 , #Button11{
            width:60px;
            height:40px;
            margin-top:7.5px;
            outline:none;
            border:none;
        }
        #Button2,#Button3,#Button7,#Button8,#Button12,#Button13,#Button4,#Button5,#Button9,#Button10,#Button14,#Button18,#Button17{
             width:60px;
            height:40px;
            margin-top:7.5px;
            margin-left:5px;
            border:none;
            outline:none;
        }
        #Button16{
            width:129px;
            height:40px;
            margin-top:7.5px;
            border:none;
            outline:none;
        }
        #Button15{
            width:60px;
            height:86px;
            position:absolute;
            margin-top:7.5px;
            margin-left:9px;
            border:none;
            outline:none;
        }
        .auto-style1 {
            width: 285px;
        }
        #forms0{
            margin:150px 490px ;
        }
        #forms0{
            margin:150px 490px ;
        }
        </style>
    </head>
<body>
    <form id="forms" runat="server" class="auto-style1">


         <asp:Label ID="Label1" runat="server" Text="Number1" ></asp:Label>


         :&nbsp;&nbsp;&nbsp;
         <asp:TextBox ID="TextNum1" runat="server" Height="30px" OnTextChanged="TextNum1_TextChanged"></asp:TextBox>
         <br />


         <asp:Label ID="Label2" runat="server" Text="Number2"></asp:Label>


         :&nbsp;&nbsp;&nbsp;
         <asp:TextBox ID="TextNum2" runat="server" Height="30px" OnTextChanged="TextNum2_TextChanged"></asp:TextBox>
         <br />


         <asp:Label ID="Label3" runat="server" Text="Result "></asp:Label>


         :&nbsp;&nbsp;&nbsp;
         <asp:TextBox ID="Textresult" runat="server" Height="30px" OnTextChanged="Textresult_TextChanged"></asp:TextBox>
         <br />
         <asp:Button ID="btnSum" runat="server" Height="30px" OnClick="btnSum_Click" Text="+" Width="50px" />
         <asp:Button ID="btnminus" runat="server" Height="30px" OnClick="btnminus_Click" Text="-" Width="50px" />
         <asp:Button ID="btnmulti" runat="server" Height="30px" OnClick="btnmulti_Click" Text="*" Width="50px" />
         <asp:Button ID="btndevid" runat="server" Height="30px" OnClick="btndevid_Click" Text="/" Width="50px" />
         <asp:Button ID="btnClear" runat="server" Height="30px" OnClick="btnClear_Click" Text="Clear" Width="50px" />
         <br />


         </form>


    </body>
</html>