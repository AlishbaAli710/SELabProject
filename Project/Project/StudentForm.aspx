﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentForm.aspx.cs" Inherits="Project.StudentForm" %>

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
                        Category
                    </td>
                    <td>
                        <asp:RadioButton ID="student" runat="server" text="Student"/>
                        <asp:RadioButton ID="advisor" runat="server" text="Advisor"/>
                    </td>
                </tr>
                <tr>
                    <td>Name</td>
                    <td>
                        <asp:TextBox ID="name" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Registration Number
                    </td>
                    <td>
                        <asp:TextBox ID="registrationnumber" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Degree Program
                    </td>
                    <td>
                        <asp:TextBox ID="degreeprogram" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Contact
                    </td>
                    <td>
                        <asp:TextBox ID="contact" runat="server"></asp:TextBox>
                    </td>
              
                </tr>
                <tr>
                   <td>
                       Rank
                   </td>
                    <td>
                        <asp:TextBox ID="rank" runat="server"></asp:TextBox>
                    </td>
                </tr>
               
                <tr>
                    <td>
                        <asp:Button ID="submit" runat="server" Text="Submit" OnClick="submit_Click" />
                    </td>
                    <td>
                        <asp:Button ID="reset" runat="server" Text="Reset" OnClick="reset_Click" />
                    </td>
                </tr>
               
            </table>
            

        </div>
    </form>
</body>
</html>
