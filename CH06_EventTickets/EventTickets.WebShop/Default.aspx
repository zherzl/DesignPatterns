<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EventTickets.WebShop._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>    
</head>
<body>
    <form id="form1" runat="server">
    <div>    
        <h2>Basket</h2>                
        I want&nbsp; <asp:TextBox ID="txtNoOfTickets" runat="server" Width="43px"></asp:TextBox>
        &nbsp;tickets to see&nbsp; 
        <asp:DropDownList ID="ddlEvents" runat="server">
            <asp:ListItem Value="BCE6A62C-B61C-4DD6-8908-02CFCAAD6883">Portsmouth vs Southampton</asp:ListItem>            
        </asp:DropDownList>
        &nbsp;
        <br />
        <br />
        <asp:Button ID="btnReserveTickets" runat="server" Text="Reserve & Checkout" 
            onclick="btnReserveTickets_Click" />                           
        <br />
        <small>"Reserve &amp; Checkout" Reserves the Tickets for you as part 
        of the Reservation Pattern.</small></div>
    </form>
</body>
</html>
