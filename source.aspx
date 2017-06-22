<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage2.master" AutoEventWireup="true" CodeFile="source.aspx.cs" Inherits="Admin_Default" %>

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
            <td class="auto-style25">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style31"></td>
            <td class="auto-style32"></td>
        </tr>
        <tr>
            <td class="auto-style18">TRAIN NAME</td>
           <td class="auto-style19">
               <asp:DropDownList ID="drptrain" runat="server" Width="125px">
               </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style26"><span class="auto-style33">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; SOURCE</span><br class="auto-style33" />
            </td>
            <td class="auto-style20">
                &nbsp;
                <br />
&nbsp;<asp:DropDownList ID="drpsource" runat="server" Height="16px" Width="118px">
                </asp:DropDownList>
                </td>
        </tr>
        <tr>
            <td class="auto-style27">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
            <td class="auto-style21"></td>
        </tr>
        <tr>
            <td class="auto-style28">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; USERNAME </td>
            <td class="auto-style22">
                <asp:TextBox ID="txtuname" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style18">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; NO. OF TICKETS &nbsp;</td>
            <td class="auto-style24">
                <asp:TextBox ID="txttickets" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style29"></td>
            <td class="auto-style30"></td>
        </tr>
        <tr>
            <td class="auto-style25">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style25">&nbsp;</td>
            <td class="auto-style3">
                <asp:Button ID="btnsave" runat="server" OnClick="btnsave_Click" style="height: 29px" Text="SCAN YOUR FINGERPRINT" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblsource" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style25">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
    </table>
</asp:Content>

<%--<asp:Content ID="Content3" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style1 {
            width: 1147px;
        }
        .auto-style2 {
            width: 187px;
        }
        .auto-style3 {
            width: 313px;
        }
        .auto-style4 {
            width: 187px;
            text-align: right;
        }
        .auto-style5 {
            width: 187px;
            height: 23px;
        }
        .auto-style6 {
            width: 313px;
            height: 23px;
        }
        .auto-style7 {
            width: 187px;
            text-align: right;
            height: 23px;
        }
        .auto-style8 {
            height: 23px;
        }
    </style>
</asp:Content>--%>


<asp:Content ID="Content3" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style18 {
        width: 619px;
        height: 7px;
        text-align: right;
        color: #FFFF00;
    }
        .auto-style19 {
            width: 61px;
            height: 7px;
        }
        .auto-style20 {
            height: 44px;
        }
        .auto-style21 {
            height: 11px;
        }
        .auto-style22 {
            height: 54px;
        }
        .auto-style24 {
            width: 785px;
            text-align: left;
            height: 7px;
        }
        .auto-style25 {
            width: 619px;
        }
        .auto-style26 {
            height: 44px;
            width: 619px;
            text-align: right;
        }
        .auto-style27 {
            height: 11px;
            width: 619px;
            text-align: right;
        color: #FFFF00;
    }
        .auto-style28 {
            height: 54px;
            width: 619px;
            text-align: right;
        color: #FFFF00;
    }
        .auto-style29 {
            width: 619px;
            height: 5px;
        }
        .auto-style30 {
            width: 785px;
            text-align: left;
            height: 5px;
        }
        .auto-style31 {
            width: 619px;
            height: 23px;
        }
        .auto-style32 {
            height: 23px;
        }
    .auto-style33 {
        color: #FFFF00;
    }
    </style>
</asp:Content>



