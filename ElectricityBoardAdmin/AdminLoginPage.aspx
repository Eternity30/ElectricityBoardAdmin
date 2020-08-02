<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLoginPage.aspx.cs" Inherits="ElectricityBoardAdmin.AdminLoginPage" Theme="Theme1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Pioneer Software</title>
</head>
<body>

    <h1>Pioneer Software</h1>
    
    <form id="form1" runat="server">
        
        <div class="login-box">
            <h2>LOGIN</h2>
            
            <div class="textbox">
                <i class="fas fa-user"></i>
            <asp:TextBox ID="Username" SkinID="t1" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Username" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
          </div>
            
            <div class="textbox">
                <i class="fas fa-lock"></i>
            <asp:TextBox ID="Password" SkinID="t2" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Password" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
           </div>
            <asp:Label ID="Labele" runat="server" ForeColor="Red" Text="Username or Password Incorrect" Visible="False"></asp:Label>
          
            <asp:Button ID="Login" class="btn" runat="server" Text="Login" OnClick="Login_Click" />

        </div>
    </form>
</body>
</html>
