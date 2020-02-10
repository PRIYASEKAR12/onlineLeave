<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="onlineLeave.register" %>

<asp:Content ID="RegisterHead" runat="server" ContentPlaceHolderID="head">
</asp:Content>
<asp:Content ID="contentPlaceHolderRegister" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">

    <div>
        <asp:HiddenField ID="hfEmployeeId" runat="server" />
        <table runat="server">
            <tr>
                <td>
                    <asp:Label ID="labelName" runat="server" Text="Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="getName" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="checkRequiredName" runat="server" ControlToValidate="getName" ErrorMessage="Name required"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="checkRegularName" runat="server" ControlToValidate="getName" ErrorMessage="Enter valid name" ValidationExpression="^[A-Za-z]+$"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="LabelDepartmentId" runat="server" Text="DepartmentId"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="getId" runat="server"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="checkRequiredId" runat="server" ControlToValidate="getId" ErrorMessage="Id required"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="labelPhoneNumber" runat="server" Text="PhoneNumber"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="getPhoneNumber" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="checkRequiredNumber" runat="server" ControlToValidate="getPhoneNumber" ErrorMessage="Phone Number required"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="checkRegularNumber" runat="server" ControlToValidate="getPhoneNumber" ErrorMessage="Enter valid phone number" ValidationExpression="[0-9]{10}"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="labelGender" runat="server" Text="Gender"></asp:Label>
                </td>
                <td>
                    <asp:RadioButtonList ID="getGender" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                        <asp:ListItem>other</asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:RequiredFieldValidator ID="checkReqiredGender" runat="server" ControlToValidate="getGender" ErrorMessage="gender required"></asp:RequiredFieldValidator>
                </td>


            </tr>
            <tr>
                <td>
                    <asp:Label ID="labelDateOfBirth" runat="server" Text="Date-of-birth"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="getDateOfBirth" runat="server" TextMode="Date"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="checkRequiredDateOfBirth" ControlToValidate="getDateOfBirth" ErrorMessage="date of birth required"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="labelEmail" runat="server" Text="EmailId"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="getEmail" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="checkRequiredGmail" runat="server" ControlToValidate="getEmail" ErrorMessage="Gmail required"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="checkRegualGmail" runat="server" ControlToValidate="getEmail" ErrorMessage="Enter valid mail id" ValidationExpression="^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="labelDesignation" runat="server" Text="Designation"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="getDesignation" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="checkRequiredDesignation" runat="server" ControlToValidate="getDesignation" ErrorMessage="Designation Required"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Onclick" />
                    <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Onclick" />
                    <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Onclick" />
                </td>
            </tr>
        </table>
        <br />
        <asp:GridView ID="gridTable" runat="server" AutoGenerateColumns="false" >
            <Columns>
                <asp:BoundField DataField="EmployeeId" HeaderText="EmloyeeId" />
                <asp:BoundField DataField="EmployeeName" HeaderText="EmloyeeName" />
                <asp:BoundField DataField="DepartmentId" HeaderText="DepartmentId" />
                <asp:BoundField DataField="EmployeePhoneNumber" HeaderText="EmployeePhoneNumber" />
                <asp:BoundField DataField="EmployeeGender" HeaderText="EmployeeGender" />
                <asp:BoundField DataField="EmployeeDateOfBirth" HeaderText="EmployeeDataOfBirth" />
                <asp:BoundField DataField="EmployeeEmailId" HeaderText="EmployeeEmail" />
                <asp:BoundField DataField="EmployeeDesignation" HeaderText="EmployeeDesignation" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="linkview" runat="server" CommandArgument='<%# Eval("EmployeeId") %>' OnClick="linkonclick">View</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>

    </div>
</asp:Content>
