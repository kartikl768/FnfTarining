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
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <div class="card">
                    <h3><%# Eval("Username") %></h3>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </form>
</body>
</html>
