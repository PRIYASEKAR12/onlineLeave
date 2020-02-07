<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="onlineLeave.register" %>

<asp:Content ID="RegisterHead" runat="server" ContentPlaceHolderID="head">
</asp:Content>
<asp:Content ID="contentPlaceHolderRegister" runtat="server" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>
        <table>
            <tr>
                <td>Name :</td>                
                    <td>
                        <asp:TextBox ID="getName" runat="server"></asp:TextBox>
                    </td>
                <td>
                    <asp:RequiredFieldValidator ID="checkRequiredName" runat="server" ControlToValidate="getName" ErrorMessage="Name required"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="checkRegularName" runat="server" ControlToValidate="getName" ErrorMessage="Enter valid name" ValidationExpression="^[A-Za-z]+$"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>ID</td>
                <td>
                    <asp:TextBox ID="getId" runat="server"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="checkRequiredId" runat="server" ControlToValidate="getId" ErrorMessage="Id required"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td>PhoneNumber</td>
                <td>
                    <asp:TextBox ID="getPhoneNumber" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="checkRequiredNumber" runat="server" ControlToValidate="getPhoneNumber" ErrorMessage="Name required"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="checkRegularNumber" runat="server" ControlToValidate="getPhoneNumber" ErrorMessage="Enter valid phone number" ValidationExpression="[0-9]{10}"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>City</td>
                <td>
                    <asp:DropDownList ID="getCity" runat="server">
                        <asp:ListItem Text="Select City" Value="select" Selected="True"></asp:ListItem>
                        <asp:ListItem Text="Bangalore" Value="Bangalore"></asp:ListItem>
                        <asp:ListItem Text="Mysore" Value="Mysore"></asp:ListItem>
                        <asp:ListItem Text="Hubli" Value="hubli"></asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>

            <tr>
                <td>Gmail</td>
                <td>
                    <asp:TextBox ID="getGmail" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="checkRequiredGmail" runat="server" ControlToValidate="getGmail" ErrorMessage="Gmail required"></asp:RequiredFieldValidator></td>
                <asp:RegularExpressionValidator ID="checkRegualGmail" runat="server" ControlToValidate="getGmail" ErrorMessage="Enter valid mail id" ValidationExpression="^[a-z0-9][-a-z0-9._]+@([-a-z0-9]+.)+[a-z]{2,5}$"></asp:RegularExpressionValidator>
            </tr>
            <tr>
                <td>Designation</td>
                <td>
                    <asp:TextBox ID="getDesignation" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="checkRequiredDesignation" runat="server" ControlToValidate="getDesignation" ErrorMessage="Designation Required"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="submit" runat="server" Text="Submit" OnClick="Submit_Click" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
