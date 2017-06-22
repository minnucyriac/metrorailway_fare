<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMasterPage.master" AutoEventWireup="true" CodeFile="loginReal.aspx.cs" Inherits="User_Default" %>

<%--<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 303px;
        }
        .auto-style3 {
            color: #FF0000;
        }
    </style>
</asp:Content>--%>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2" style="width: 281px; text-align: right">&nbsp;LOGIN&nbsp;</td>
            <td style="width: 540px">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2" style="width: 281px">&nbsp;</td>
            <td style="width: 540px">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2" style="width: 281px">&nbsp;</td>
            <td style="width: 540px">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2" style="width: 281px; text-align: right">USERNAME<br />
            </td>
            <td style="width: 540px">
                <asp:TextBox ID="txtuname" runat="server" Width="286px"></asp:TextBox>
                <span style="color: #FF0000">*</span></td>
        </tr>
        <tr>
            <td class="auto-style2" style="width: 281px; text-align: right">PASSWORD<br />
            </td>
            <td style="width: 540px">
                <asp:TextBox ID="txtpassword" runat="server" TextMode="Password" Width="285px" OnTextChanged="txtpassword_TextChanged"></asp:TextBox>
                <span class="auto-style3" style="color: #FF0000">*</span><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtpassword" ErrorMessage="Enter Password" style="color: #FF0000"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="width: 281px">&nbsp;</td>
            <td style="width: 540px">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2" style="width: 281px">&nbsp;</td>
            <td style="width: 540px">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="LOGIN" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="width: 281px">&nbsp;</td>
            <td style="width: 540px">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2" style="width: 281px">
                &nbsp;</td>
            <td style="width: 540px">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2" style="width: 281px">&nbsp;</td>
            <td style="width: 540px">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2" style="width: 281px">&nbsp;</td>
            <td style="width: 540px">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2" style="width: 281px">&nbsp;</td>
            <td style="width: 540px">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2" style="width: 281px">&nbsp;</td>
            <td style="width: 540px">&nbsp;</td>
        </tr>
    </table>
</asp:Content>

