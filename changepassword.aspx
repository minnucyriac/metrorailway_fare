<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMasterPage.master" AutoEventWireup="true" CodeFile="changepassword.aspx.cs" Inherits="User_Default2" %>

<%--<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 392px;
        }
    </style>
</asp:Content>--%>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">CHANGE PASSWORD</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">CURRENT PASSWORD<br />
            </td>
            <td>
                <asp:TextBox ID="txtcpswd" runat="server" TextMode="Password"></asp:TextBox>
                <br />
            </td>
        </tr>
        <tr>
            <td class="auto-style2">NEW PASSWORD<br />
            </td>
            <td>
                <asp:TextBox ID="txtnpswd" runat="server" TextMode="Password"></asp:TextBox>
                <br />
            </td>
        </tr>
        <tr>
            <td class="auto-style2">CONFIRM PASSWORD<br />
            </td>
            <td>
                <asp:TextBox ID="txtcnpswd" runat="server" TextMode="Password"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtnpswd" ControlToValidate="txtcnpswd" ErrorMessage="Incorrect password"></asp:CompareValidator>
                <br />
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="SAVE" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

