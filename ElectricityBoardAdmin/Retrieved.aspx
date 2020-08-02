<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Retrieved.aspx.cs" Inherits="ElectricityBoardAdmin.Retrieved" Theme="Theme2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="box">
        <div class="content">
            <h1>RETRIEVE</h1>
    <%--<asp:Label ID="Label1" runat="server" ForeColor="White" Text="Enter Last 'N' Number of Bills To Generate"></asp:Label>--%>
    <asp:TextBox ID="Retrieve_n" CssClass="field" runat="server" placeholder="Enter Number of Bills To Generate" TextMode="Number"></asp:TextBox>

            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Retrieve_n" ForeColor="Red">Number Of Bills Is Required</asp:RequiredFieldValidator>
           
            <br />
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="Retrieve_n" CultureInvariantValues="True" ErrorMessage="RangeValidator" ForeColor="Red" MaximumValue="1000" MinimumValue="0" Type="Integer">Value Cannot Be Negative</asp:RangeValidator>
            <br />
            <asp:Label ID="Label1" runat="server" ForeColor="Red" Visible="False"></asp:Label>
           
     <br />

    <asp:Button ID="Submit" CssClass="btn" runat="server" Text="Submit" OnClick="Submit_Click" />
             
            </div>
        </div>
    <br />
    <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical">
        <AlternatingRowStyle BackColor="#CCCCCC" />
        <FooterStyle BackColor="#CCCCCC" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#808080" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#383838" />
    </asp:GridView>
             
    <br />
</asp:Content>
