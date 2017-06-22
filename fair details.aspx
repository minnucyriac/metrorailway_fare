<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin2Masterpage.master" AutoEventWireup="true" CodeFile="fair details.aspx.cs" Inherits="Project_Admin_Default2 " %>
   <%--<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 296px;
        }
        .auto-style2 {
            width: 749px;
        }
        .auto-style3 {
            width: 749px;
            height: 26px;
            text-align: justify;
        }
        .auto-style4 {
            height: 26px;
        }
        .auto-style6 {
            color: #003300;
        }
        .auto-style7 {
            width: 749px;
            text-align: right;
            height: 29px;
            color: #FF0066;
        }
        .auto-style8 {
            height: 29px;
        }
        .auto-style9 {
            color: #33CCFF;
        }
        .auto-style10 {
            width: 749px;
            text-align: right;
        }
        .auto-style11 {
            color: #FF0066;
        }
    </style>
</asp:Content>--%>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style3"><span class="auto-style9">FARE DETAILS&nbsp;</span><span class="auto-style6"> </span>
                <br class="auto-style6" />
                <br class="auto-style6" />
                <br class="auto-style6" />
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <br />
                <span class="auto-style11">DISTANCE</span><br />
            </td>
            <td class="auto-style5">
                <asp:TextBox ID="txtdist" runat="server" style="text-align: left" Width="200px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtdist" ErrorMessage="*" style="color: #FF0000"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">RATE</td>
            <td class="auto-style3">
                <a href="../Guest/HomePage.aspx"</a>
                <asp:TextBox ID="txtrate" runat="server" Width="199px"></asp:TextBox>
                </a>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtrate" ErrorMessage="*" style="color: #FF0000"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style3">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Save" />
            </td>
        </tr>
        <tr>
            <td class="auto-style7">
                <a href="../Guest/HomePage.aspx"</a>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" OnRowCommand="GridView1_RowCommand" Height="77px" Width="413px">
                    <Columns>
                        <asp:BoundField DataField="distance" HeaderText="DISTANCE" />
                        <asp:BoundField DataField="rate" HeaderText="FARE" />
                        <asp:TemplateField HeaderText="EDIT/DELETE">
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%# Eval("distance") %>' CausesValidation="False" CommandName="ed">EDIT</asp:LinkButton>
                                &nbsp;&nbsp;&nbsp;
                                <asp:LinkButton ID="LinkButton2" runat="server" CommandArgument='<%# Eval("distance") %>' CausesValidation="False" CommandName="del">DELETE</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                    <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                    <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                    <RowStyle BackColor="White" ForeColor="#003399" />
                    <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                    <SortedAscendingCellStyle BackColor="#EDF6F6" />
                    <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                    <SortedDescendingCellStyle BackColor="#D6DFDF" />
                    <SortedDescendingHeaderStyle BackColor="#002876" />
                </asp:GridView>
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
    </table>
    <br />
    <br />
</asp:Content>

<asp:Content ID="Content3" runat="server" contentplaceholderid="head">
    <style type="text/css">
    .auto-style1 {
        width: 1488px;
    }
    .auto-style3 {
        width: 747px;
        text-align: left;
    }
    .auto-style4 {
        height: 40px;
        width: 38px;
    }
    .auto-style5 {
        width: 747px;
        height: 40px;
        text-align: left;
    }
    .auto-style6 {
        width: 739px;
    }
    .auto-style7 {
        width: 38px;
    }
</style>
</asp:Content>


