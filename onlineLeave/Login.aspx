<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="onlineLeave.Login" %>
<asp:Content ID="contentHead" runat="server" ContentPlaceHolderID="head">
    </asp:Content>
        <asp:Content ID="contentPlaceHolderLogin" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <style type="text/css">
        .auto-style1 {
            height: 140px;
        }
    </style>
        <div>
            <table >
                <tr>
                    <td>userName</td>
                    <td>
                        <asp:TextBox ID="userName" runat="server"></asp:TextBox>
                    </td>

                </tr>
                <tr>
                    <td>Password</td>
                    <td>
                        <asp:TextBox ID="Password" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </asp:Content>