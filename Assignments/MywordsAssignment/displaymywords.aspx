<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="displaymywords.aspx.cs" Inherits="webformsAssignments.displaymywords" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblMyWordsHeader" runat="server" Text="My Saved Words:" Font-Bold="True" />
            <asp:GridView ID="gvMyWords" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="Word" HeaderText="Word" />
                    <asp:BoundField DataField="Translation" HeaderText="Translation" />
                </Columns>
</asp:GridView>
        </div>
    </form>
</body>
</html>
