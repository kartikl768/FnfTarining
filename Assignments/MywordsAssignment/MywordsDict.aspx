<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MywordsDict.aspx.cs" Inherits="webformsAssignments.MywordsDict" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1> Add to My Words </h1>
        <div style="text-align: center">
            <asp:Repeater ID="rpMyWords" runat="server" OnItemCommand="rpMyWords_ItemCommand">
                <HeaderTemplate>
                    <table>
                        <tr>
                            <th>Word</th>
                            <th>Translation</th>
                            <th>Action</th>
                        </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("Word") %></td>
                        <td>
                            <asp:TextBox ID="txtTranslation" runat="server" Text='<%# Eval("Translation") %>' />
                        </td>
                        <td>
                            <asp:LinkButton ID="btnAdd" runat="server" CommandName="Add" CommandArgument='<%# Eval("Word") %>' Text="Add to Dictionary" />
                        </td>
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </table>
                </FooterTemplate>
            </asp:Repeater>
            <asp:Button  runat="server" ID="btndisplay" Text="Display words" OnClick="btndisplay_Click"/>
            <asp:Label ID="lblStatus" runat="server" ForeColor="Green" />

        </div>
    </form>
</body>
</html>
