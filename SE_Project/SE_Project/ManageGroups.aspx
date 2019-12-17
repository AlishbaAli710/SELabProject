<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageGroups.aspx.cs" Inherits="SE_Project.ManageGroups" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        Projects
                    </td>
                    <td>
                        <asp:DropDownList ID="allprojects" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        Advisor
                    </td>
                    <td>
                        <asp:TextBox ID="advisorofproject" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Students
                    </td>
                    <td>
                        <asp:CheckBoxList ID="studentslist" runat="server"></asp:CheckBoxList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="addgroup" runat="server" Text="Add Group" OnClick="addgroup_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        Check
                    </td>
                    <td>
                        <asp:Button ID="check" runat="server" Text="Check" OnClick="check_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
