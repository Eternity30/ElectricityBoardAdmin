<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="ElectricityBoardAdmin.WebForm3" Theme="Theme2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="box">

        <div class="content">

            <h1>WELCOME <%Response.Write(Session["name"]);%></h1>

            <asp:TextBox ID="TextBox1" CssClass=" field" placeholder="Enter The Number Of Bills" runat="server" TextMode="Number"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Number Of Bills Is Required</asp:RequiredFieldValidator>
&nbsp;<br />
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="RangeValidator" ForeColor="Red" MaximumValue="100" MinimumValue="1" Type="Integer">Value Should Be Greater Than 0</asp:RangeValidator>
            <asp:Button ID="Submit" CssClass="btn" runat="server" Text="Submit" OnClick="Submit_Click" />
            <br />
                  
        </div>
    </div>
</asp:Content>
