<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Projects.aspx.cs" Inherits="SE_Project.Projects" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 270px">
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        Advisor
                    </td>
                    <td>
                        <asp:DropDownList ID="advisorlist" runat="server" OnSelectedIndexChanged="advisorlist_SelectedIndexChanged"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>Project Name</td>
                    <td>
                        <asp:TextBox ID="projectname" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Project Description</td>
                    <td>
                        <asp:TextBox ID="projectdescription" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="submit" runat="server" Text="Submit" OnClick="submit_Click" />
                    </td>
                    <td>
                        <asp:Button ID="addmore" runat="server" Text="Add More+" OnClick="addmore_Click" />
                    </td>
                    <td>
                        <asp:Button ID="manage" runat="server" Text="Manage Projects" OnClick="manage_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
