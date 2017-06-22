<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin2MasterPage.master" AutoEventWireup="true" CodeFile="adminschedule.aspx.cs" Inherits="Admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 396px;
        }
        .auto-style3 {
            width: 188px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">TRAIN SCHEDULING</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <br />
            </td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">TRAIN NAME
                <br />
            </td>
            <td class="auto-style3">
                <asp:DropDownList ID="drptrain" runat="server" Height="16px" style="margin-right: 35px" Width="191px">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">STATION NAME<br />
            </td>
            <td class="auto-style3">
                <asp:DropDownList ID="drpstation" runat="server" Width="190px">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">ARRIVAL TIME<br />
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="txtarrivaltime" runat="server" Width="192px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">DEPARTURE TIME<br />
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="txtduration" runat="server" Width="192px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <br />
            </td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="SUBMIT" />
                <br />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" style="text-align: center; margin-left: 0px" Width="865px">
                    <Columns>
                        <asp:BoundField DataField="train_name" HeaderText="TRAIN NAME" />
                        <asp:BoundField DataField="station_name" HeaderText="STATION NAME" />
                        <asp:BoundField DataField="arrival_time" HeaderText="ARRIVAL TIME" />
                        <asp:BoundField DataField="departure_time" HeaderText="DEPARTURE TIME" />
                        <asp:TemplateField HeaderText="Edit/Delete">
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%# Eval("sch_id") %>' OnCommand="edt" CommandName="edt">Edit</asp:LinkButton>
                                &nbsp;
                                <asp:LinkButton ID="LinkButton2" runat="server" CommandArgument='<%# Eval("sch_id") %>' OnCommand="del" CommandName="del">delete</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

