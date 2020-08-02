<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CustomerDetails.aspx.cs" Inherits="ElectricityBoardAdmin.WebForm1" Theme="Theme2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label5" runat="server" ForeColor="Lime"></asp:Label>
    <div class="box">
        <div class="content">
        <h1>FORM <%Response.Write(Session["id"]);%></h1>
<%--<asp:Label ID="Label1" runat="server" Text="Consumer Number" ForeColor="White"></asp:Label>--%>
<asp:TextBox ID="customer_num" Class="field" placeholder="Consumer Number" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="customer_name" ForeColor="Red">Consumer Number Is Required</asp:RequiredFieldValidator>
    &nbsp;&nbsp;
            <br />
    <asp:Label ID="exception" runat="server" ForeColor="Red" Text="Label" Visible="False"></asp:Label>
<br />
<%--<asp:Label ID="Label2" runat="server" Text="Consumer Name" ForeColor="White"></asp:Label>--%>
<asp:TextBox ID="customer_name" Class="field" placeholder="Consumer Name" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="customer_num" ErrorMessage="*" ForeColor="Red">Consumer Name Is Required</asp:RequiredFieldValidator>
<br />
<%--<asp:Label ID="Label3" runat="server" Text="Units Consumed" ForeColor="White"></asp:Label>--%>
<asp:TextBox ID="units_consumed" Class="field" placeholder="Units Consumed" runat="server" TextMode="Number"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="units_consumed" ErrorMessage="*" ForeColor="Red">Units Consumed Is Required</asp:RequiredFieldValidator>
            <br />
    <asp:Label ID="Label4" runat="server" ForeColor="Red" Visible="False"></asp:Label>
            <br />
            <asp:Label ID="Label8" runat="server" ForeColor="Red" Text="Consumer Number Already Present" Visible="False"></asp:Label>
            <br />
<asp:Button ID="Submit" Class="btn" runat="server" Text="Submit" OnClick="Submit_Click"/>
<asp:Button ID="Reset" Class="btn" runat="server" OnClick="Reset_Click" Text="Cancel" CausesValidation="False"/>
    <br />
    <asp:Label ID="Label6" runat="server" ForeColor="Lime" Text="Saved Successfully" Visible="False"></asp:Label>
    <br />
        </div>
        </div>
</asp:Content>
