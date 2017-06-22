<%@ Page Title="" Language="C#" MasterPageFile="~/Guest/GuestMasterPage.master" AutoEventWireup="true" CodeFile="New user.aspx.cs" Inherits="Guest_Default" %>

<%--<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 556px;
        }
        .auto-style3 {
            width: 556px;
            height: 26px;
        }
        .auto-style4 {
            height: 26px;
        }
        .auto-style5 {
            width: 556px;
            height: 34px;
        }
        .auto-style6 {
            height: 34px;
        }
    </style>
</asp:Content>--%>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    &nbsp;<table class="auto-style1">
        <tr>
            <td class="auto-style7" style="width: 198px">USER REGISTRATION</td>
            <td class="auto-style6" style="width: 383px">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7" style="width: 198px">&nbsp;</td>
            <td class="auto-style6" style="width: 383px">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7" style="width: 198px">FIRST&nbsp; NAME<br />
                <br />
            </td>
            <td class="auto-style6" style="width: 383px">
                <asp:TextBox ID="txtfname" runat="server" Width="186px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtfname" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                <br />
            </td>
        </tr>
        <tr>
            <td class="auto-style7" style="width: 198px">MIDDLE&nbsp; NAME<br />
                <br />
            </td>
            <td class="auto-style6" style="width: 383px">
                <asp:TextBox ID="txtmname" runat="server" Width="185px"></asp:TextBox>
                <br />
                <br />
            </td>
        </tr>
        <tr>
            <td class="auto-style7" style="width: 198px">LAST&nbsp; NAME<br />
                <br />
            </td>
            <td class="auto-style6" style="width: 383px">
                <asp:TextBox ID="txtlname" runat="server" Width="184px"></asp:TextBox>
                <br />
                <br />
            </td>
        </tr>
        <tr>
            <td class="auto-style7" style="width: 198px">GENDER<br />
            </td>
            <td class="auto-style6" style="width: 383px">
                <asp:RadioButtonList ID="radgen" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:RadioButtonList>
            &nbsp;&nbsp;&nbsp;&nbsp;
            </td>
        </tr>
        <tr>
            <td class="auto-style7" style="width: 198px">EMAIL&nbsp; ID<br />
                <br />
            </td>
            <td class="auto-style6" style="width: 383px">
                <asp:TextBox ID="txteid" runat="server" TextMode="Email" Width="185px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txteid" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                <br />
            </td>
        </tr>
        <tr>
            <td class="auto-style7" style="width: 198px">CONTACT NUMBER<br />
            </td>
            <td class="auto-style6" style="width: 383px">
                <asp:TextBox ID="txtcontactno" runat="server" Width="184px"></asp:TextBox>
                <br />
            </td>
        </tr>
        <tr>
            <td class="auto-style7" style="width: 198px">WALLET AMOUNT</td>
            <td class="auto-style6" style="width: 383px">
                <asp:TextBox ID="txtvallet" runat="server" placeholder="Required minimum 200 rupees" Width="311px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style7" style="width: 198px">&nbsp;</td>
            <td class="auto-style6" style="width: 383px">
                <asp:Button ID="Button1" runat="server" Text="Make Vallet" Width="129px" OnClick="Button1_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style7" style="width: 198px">&nbsp;</td>
            <td class="auto-style6" style="width: 383px">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7" colspan="2">
                <asp:Panel ID="Panel1" runat="server">
                    <table class="auto-style8">
                        <tr>
                            <td class="auto-style7">AADHAR NUMBER<br /> <br /> </td>
                            <td class="auto-style6">
                                <asp:TextBox ID="txtadarno" runat="server" OnTextChanged="txtadarno_TextChanged" AutoPostBack="True" Width="182px"></asp:TextBox>
                                &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtadarno" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                                <br />
                                <br />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style7">USERNAME<br /> <br /> </td>
                            <td class="auto-style6">
                                <asp:TextBox ID="txtuname" runat="server" OnTextChanged="txtuname_TextChanged" AutoPostBack="True" Width="182px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ControlToValidate="txtuname" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                                <br />
                                <br />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style7">PASSWORD<br /> </td>
                            <td class="auto-style6">
                                <asp:TextBox ID="txtpswd" runat="server" TextMode="Password" Width="179px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="txtpswd" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                                <br />
                                <br />
                            </td>
                        </tr>
                        <tr>
                            <td>CONFIRM PASSWORD<br /> <br /> </td>
                            <td>
                                <asp:TextBox ID="txtcpswd" runat="server" OnTextChanged="txtbname_TextChanged" TextMode="Password" Width="178px"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToCompare="txtpswd" ControlToValidate="txtcpswd" ErrorMessage="incorrect password"></asp:CompareValidator>
                                <br />
                            </td>
                        </tr>
                        <tr>
                            <td>SECURITY QUESTION<br /> &nbsp;</td>
                            <td>
                                <asp:DropDownList ID="drpsqstn" runat="server" Height="16px" Width="184px">
                                    <asp:ListItem>favourite flower</asp:ListItem>
                                    <asp:ListItem>Nationality</asp:ListItem>
                                    <asp:ListItem>pet animal</asp:ListItem>
                                    <asp:ListItem></asp:ListItem>
                                </asp:DropDownList>
                                <br />
                            </td>
                        </tr>
                        <tr>
                            <td>ANSWER<br /> </td>
                            <td>
                                <asp:TextBox ID="txtanswer" runat="server" OnTextChanged="txtbname_TextChanged" Width="177px"></asp:TextBox>
                                <br />
                            </td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>
                                <asp:Button ID="btnsav0" runat="server" OnClick="btnsav_Click" Text="Submit" />
                            </td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td class="auto-style7" style="width: 198px">&nbsp;</td>
            <td class="auto-style6" style="width: 383px">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7" style="width: 198px">&nbsp;</td>
            <td class="auto-style6" style="width: 383px">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7" style="width: 198px">&nbsp;</td>
            <td class="auto-style6" style="width: 383px">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7" style="width: 198px">&nbsp;</td>
            <td class="auto-style6" style="width: 383px">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7" style="width: 198px">&nbsp;</td>
            <td class="auto-style6" style="width: 383px">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7" style="width: 198px">&nbsp;</td>
            <td class="auto-style6" style="width: 383px">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7" style="width: 198px">&nbsp;</td>
            <td class="auto-style6" style="width: 383px">&nbsp;</td>
        </tr>
    </table>
</asp:Content>

<%--<asp:Content ID="Content3" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style1 {
            width: 1098px;
            margin-right: 100px;
        }
        .auto-style6 {
            width: 674px;
        }
        .auto-style7 {
        }
        .auto-style8 {
            width: 100%;
        }
    </style>
</asp:Content>--%>


