<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Monday_RegiForm_023.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 423px;
        }
        .auto-style2 {
            width: 100%;
            height: 581px;
        }
        .auto-style3 {
            width: 100%;
            height: 580px;
        }
        .auto-style4 {
            height: 406px;
            text-align: center;
        }
        .auto-style5 {
            text-align: center;
        }
        .auto-style6 {
            font-weight: bold;
            color: #FF6600;
            margin-left: 0px;
            background-color: #FFFF00;
        }
        .auto-style7 {
            color: #FF6600;
            background-color: #FFFF00;
        }
        .auto-style8 {
            color: #CC3399;
            font-weight: bold;
            background-color: #FF6600;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="Registretion Form"></asp:Label>
            <br />
            <br />
        </div>
        <table class="auto-style1">
            <tr>
                <td>
                    <table border="1" class="auto-style2">
                        <tr>
                            <td class="auto-style5">Roll No</td>
                            <td class="auto-style5">
                                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Search" />
                                <br />
                                <asp:Label ID="Label2" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style5">Student&nbsp; Name</td>
                            <td class="auto-style5">
                                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style5">Father Name</td>
                            <td class="auto-style5">
                                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style5">Last Name</td>
                            <td class="auto-style5">
                                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style5" colspan="2">
                                <strong>
                                <asp:Button ID="Button3" runat="server" CssClass="auto-style6" OnClick="Button3_Click" Text="Save" Width="100px" />
                                </strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>
                                <asp:Button ID="Button2" runat="server" Height="25px" OnClick="Button2_Click" Text="Update" Width="126px" CssClass="auto-style7" />
                                <br />
                                <br />
                                </strong>
                                <br />
                                <asp:Label ID="Label3" runat="server"></asp:Label>
                            </td>
                        </tr>
                    </table>
                </td>
                <td>
                    <table border="1" class="auto-style3">
                        <tr>
                            <td class="auto-style4">
                                <asp:Image ID="Image1" runat="server" Width="101px" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style5">
                                <strong>
                                <asp:FileUpload ID="FileUpload1" runat="server" CssClass="auto-style8" />
                                </strong>
                                <br />
                                Maximum Size 200 Kb</td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
