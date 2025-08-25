<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="SampleWebFormsApp.Register" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User Registration</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
        }

        .form-container {
            background-color: #fff;
            padding: 30px;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0,0,0,0.1);
            width: 400px;
        }

        h1 {
            text-align: center;
            margin-bottom: 20px;
            color: #333;
        }

        .form-group {
            margin-bottom: 15px;
        }

        label {
            display: block;
            margin-bottom: 5px;
            font-weight: bold;
        }

        input[type="text"],
        input[type="email"],
        input[type="number"],
        input[type="password"] {
            width: 100%;
            padding: 8px;
            border: 1px solid #ccc;
            border-radius: 4px;
        }

        .error {
            color: red;
            font-size: 0.9em;
        }

        .submit-btn {
            width: 100%;
            padding: 10px;
            background-color: #28a745;
            border: none;
            color: white;
            font-size: 16px;
            border-radius: 4px;
            cursor: pointer;
        }

        .submit-btn:hover {
            background-color: #218838;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="form-container">
            <h1>User Registration</h1>

            <div class="form-group">
                <label for="txtusername">Username</label>
                <asp:TextBox ID="txtusername" runat="server" />
            </div>

            <div class="form-group">
                <label for="txtemail">Email</label>
                <asp:TextBox ID="txtemail" runat="server" TextMode="Email" />
            </div>

            <div class="form-group">
                <label for="txtage">Age</label>
                <asp:TextBox ID="txtage" runat="server" TextMode="Number" />
            </div>

            <div class="form-group">
                <label for="txtpassword">Password</label>
                <asp:TextBox ID="txtpassword" runat="server" TextMode="Password" />
                <asp:RegularExpressionValidator ID="revPassword" runat="server"
                    ControlToValidate="txtpassword"
                    ValidationExpression="^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$"
                    ErrorMessage="Password must be at least 8 characters and include letters and numbers."
                    CssClass="error" Display="Dynamic" />
            </div>

            <div class="form-group">
                <label for="txtpassword2">Confirm Password</label>
                <asp:TextBox ID="txtpassword2" runat="server" TextMode="Password" />
                <asp:CompareValidator ID="cvPassword" runat="server"
                    ControlToCompare="txtpassword"
                    ControlToValidate="txtpassword2"
                    ErrorMessage="Passwords do not match."
                    CssClass="error" Display="Dynamic" />
            </div>

            <asp:Button ID="btnRegister" runat="server" Text="Register" CssClass="submit-btn" OnClick="btnRegister_Click" />
            <asp:Label runat="server" ID="lbltxt"></asp:Label>
        </div>
    </form>
</body>
</html>
