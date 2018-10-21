
<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Chap4.UI.WebForms._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <fieldset>
        <legend>Create New Account</legend>
     <p>       
        Customer Ref:
        <asp:TextBox ID="txtCustomerRef" runat="server" ></asp:TextBox>
        <asp:Button ID="btCreateAccount" runat="server" Text="Create Account" onclick="btCreateAccount_Click" />
    </p>
    </fieldset>
    <fieldset>
        <legend>Account Detail</legend>
        <p>
        <asp:DropDownList AutoPostBack="true"
              ID="ddlBankAccounts" runat="server"                      
              onselectedindexchanged="ddlBankAccounts_SelectedIndexChanged"></asp:DropDownList>
        </p>
        <p>
            Account No:
            <asp:Label ID="lblAccountNo" runat="server" />
        </p>
        <p>
            Customer Ref:
            <asp:Label ID="lblCustomerRef" runat="server" />
        </p>
        <p>
            Balance:
            <asp:Label ID="lblBalance" runat="server" />
        </p>
        <p>
            Amount £<asp:TextBox ID="txtAmount" runat="server" Width="60px"/>
            &nbsp;
            <asp:Button ID="btnWithdrawal" runat="server" Text="Withdrawal" onclick="btnWithdrawal_Click" />
            &nbsp;
            <asp:Button ID="btnDeposit" runat="server" Text="Deposit"
                onclick="btnDeposit_Click" />
        </p>
        <p>
            Transfer
            £<asp:TextBox ID="txtAmountToTransfer" runat="server"
                          Width="60px" />
        &nbsp;to
        <asp:DropDownList AutoPostBack="true" 
              ID="ddlBankAccountsToTransferTo" runat="server"/>
        &nbsp;
         <asp:Button ID="btnTransfer" runat="server" Text="Commit"
                onclick="btnTransfer_Click" />
        </p>
        <p>
            Transactions</p>
            <asp:Repeater ID="rptTransactions" runat="server">
                <HeaderTemplate>
                    <table>
                    <tr>
                        <td>deposit</td>
                        <td>withdrawal</td>
                        <td>reference</td>
                    </tr>
                </HeaderTemplate> 
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("Deposit")  %></td>
                        <td><%# Eval("Withdrawal")  %></td>
                        <td><%# Eval("Reference")  %></td>
                        <td><%# Eval("Date")  %></td>
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </table>
                </FooterTemplate>  
            </asp:Repeater>
    </fieldset>   
    </div>
        </div>
    </div>

</asp:Content>
