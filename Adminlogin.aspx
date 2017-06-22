<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Ad_MasterPage.master" AutoEventWireup="true" CodeFile="Adminlogin.aspx.cs" Inherits="Admin_Default" %>

<%--<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 331px;
        }
    </style>
</asp:Content>--%>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">ADMIN LOGIN</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">USERNAME<br />
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="txtuname" runat="server" Width="206px"></asp:TextBox>
                <span class="auto-style4">*<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtuname" ErrorMessage="Enter Username"></asp:RequiredFieldValidator>
                </span>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">PASSWORD<br />
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="txtpwsd" runat="server" Width="207px"></asp:TextBox>
                <span class="auto-style4">*<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtpwsd" ErrorMessage="Enter password"></asp:RequiredFieldValidator>
                </span>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">
                <asp:Button ID="btnsave" runat="server" OnClick="btnsave_Click" style="height: 29px" Text="SUBMIT" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
    </table>
</asp:Content>

<asp:Content ID="Content3" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style1 {
            width: 1147px;
        }
        .auto-style2 {
            width: 230px;
        }
        .auto-style3 {
            width: 566px;
        }
        .auto-style4 {
            color: #FF0000;
        }
    </style>
</asp:Content>


