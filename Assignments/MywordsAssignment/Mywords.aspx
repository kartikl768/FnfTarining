<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Mywords.aspx.cs" Inherits="webformsAssignments.Mywords" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>My Words</title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        table {
            margin: auto;
            border-collapse: collapse;
        }
        th, td {
            border: 1px solid #ccc;
            padding: 8px;
        }
        .action-links {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1 class="auto-style1">My Words</h1>
        <div>
            <p class="auto-style1">
                English Word:
                <asp:TextBox runat="server" ID="txtword" />
                &nbsp;&nbsp;
                <asp:Button ID="btnsearch" runat="server" OnClick="btnsearch_Click" Text="Search" />
            </p>
            <p style="margin-left: 560px">
                <asp:Label ID="lbltxt" runat="server"></asp:Label>
            </p>
        </div>
        
        <div style="text-align: center; margin-top: 20px;">
            
            Add New Word :
            <asp:TextBox ID="txtnewword" runat="server"></asp:TextBox>
            <asp:Button ID="btnadd" runat="server" OnClick="btnadd_Click" Text="Add word" />
            <br />
            <asp:Label ID="lbltxt1" runat="server"></asp:Label>
            
        </div>
    </form>
</body>
</html>
