<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMasterPage.master" AutoEventWireup="true" CodeFile="Userlogin.aspx.cs" Inherits="Admin_Default" %>

<%--<%--<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 331px;
        }
    </style>--%>
<%--</asp:Content>--%>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">WELCOME</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;&nbsp; SCAN&nbsp; YOUR&nbsp;&nbsp;&nbsp;FINGERPRINT</td>
           <td><img alt="" class="auto-style49" src="Images/fingerprint1.jpg" /></td>
        </tr>
        <tr>
            <td class="auto-style4">CHOOSE YOUR SOURCE<br />
            </td>
            <td class="auto-style3">
                &nbsp;
                <br />
&nbsp;&nbsp;
                <asp:DropDownList ID="drpsource" runat="server">
                    <asp:ListItem>PETTA</asp:ListItem>
                    <asp:ListItem>ALUVA</asp:ListItem>
                </asp:DropDownList>
                &nbsp;</td>
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
            width: 333px;
        }
        .auto-style3 {
            width: 313px;
        }
        .auto-style4 {
            width: 333px;
            text-align: right;
        }
    </style>
</asp:Content>


