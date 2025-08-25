<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="userinfo.aspx.cs" Inherits="SampleWebFormsApp.userinfo" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User Info</title>
    <style>
        .card {
            border: 1px solid #ccc;
            padding: 15px;
            margin: 10px;
            border-radius: 8px;
            box-shadow: 2px 2px 5px #aaa;
            width: 250px;
            display: inline-block;
            vertical-align: top;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1>User Info</h1>
        <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
            <ItemTemplate>
                <div>
                    <strong><%# Eval("Username") %></strong>
                    <asp:Button ID="btnViewMore" runat="server" Text="View More"
                        CommandName="ViewMore"
                        CommandArgument='<%# Eval("Username") %>' />
                </div>
            </ItemTemplate>
        </asp:Repeater>

        <asp:Label ID="lblDetails" runat="server" ForeColor="DarkBlue" />

    </form>
</body>
</html>
