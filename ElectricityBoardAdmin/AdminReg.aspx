<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AdminReg.aspx.cs" Inherits="ElectricityBoardAdmin.WebForm2" Theme="Theme2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="box">
    <div class="content">
        <h1>REGISTRATION</h1>
    <%--<asp:Label ID="Label1" runat="server" Text="Username" ForeColor="White"></asp:Label>--%>
            <asp:TextBox ID="Username" placeholder="USERNAME" CssClass="field" runat="server"></asp:TextBox>
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Username" ErrorMessage="Username Is Required" ForeColor="Red"></asp:RequiredFieldValidator>
    <%--<asp:Label ID="Label2" runat="server" Text="E-Mail" ForeColor="White"></asp:Label>--%>
            <asp:TextBox ID="email" placeholder="EMAIL" runat="server" CssClass="field"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="email" ErrorMessage="Email Is Required" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="email" ErrorMessage="E-Mail is Incorrect" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
    <%--<asp:Label ID="Label3" runat="server" Text="Password" ForeColor="White"></asp:Label>--%>
            <asp:TextBox ID="password" placeholder="PASSWORD" CssClass="field" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="password" ErrorMessage="Password Is Required" ForeColor="Red"></asp:RequiredFieldValidator>
    <%--<asp:Label ID="Label4" runat="server" Text="Retype Password" ForeColor="White"></asp:Label>--%>
            <asp:TextBox ID="re_password" placeholder="RETYPE PASSWORD" CssClass="field" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="re_password" ErrorMessage="Retype Password Is Required" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="password" ControlToValidate="re_password" ErrorMessage="Password typed again does not match" ForeColor="Red"></asp:CompareValidator>
            <asp:Button ID="Submit" CssClass="btn" runat="server" Text="Submit" OnClick="Submit_Click" />
    </div>
    </div>

</asp:Content>
        