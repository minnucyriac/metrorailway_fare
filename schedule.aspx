<%@ Page Title="" Language="C#" MasterPageFile="~/Guest/GuestMasterPage.master" AutoEventWireup="true" CodeFile="schedule.aspx.cs" Inherits="Guest_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:DropDownList ID="DropDownList1" runat="server">
</asp:DropDownList>
<table style="width: 100%">
        <tr>
            <td style="width: 402px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 402px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 402px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 402px">TRAIN NAME</td>
            <td>
                <asp:DropDownList ID="DropDownList2" runat="server" Width="212px">
                    <asp:ListItem>-SELECT-</asp:ListItem>
                    <asp:ListItem>KOCHIEXPRESS1</asp:ListItem>
                    <asp:ListItem>KOCHIEXPRESS2</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 402px">STATION NAME</td>
            <td>
                <asp:DropDownList ID="dropstation" runat="server" Height="16px" Width="214px">
                    <asp:ListItem>-SELECT-</asp:ListItem>
                    <asp:ListItem>ALUVA</asp:ListItem>
                    <asp:ListItem>KALAMASSERY</asp:ListItem>
                    <asp:ListItem>EDAPALLY</asp:ListItem>
                    <asp:ListItem>KALOOR</asp:ListItem>
                    <asp:ListItem>PETTA</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 402px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 402px">&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="OK" />
            </td>
        </tr>
        <tr>
            <td style="width: 402px; height: 42px;">
                <asp:GridView ID="gridview" runat="server" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField DataField="train_name" HeaderText="TRAIN NAME" />
                        <asp:BoundField DataField="station_name" HeaderText="STATION NAME" />
                        <asp:BoundField DataField="arrival_time" HeaderText="ARRIVAL TIME" />
                        <asp:BoundField DataField="departure_time" HeaderText="DEPARTURE TIME" />
                    </Columns>
                </asp:GridView>
            </td>
            <td style="height: 42px"></td>
        </tr>
        <tr>
            <td style="width: 402px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 402px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

