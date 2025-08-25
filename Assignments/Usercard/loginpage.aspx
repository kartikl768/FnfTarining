<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loginpage.aspx.cs" Inherits="SampleWebFormsApp.loginpage" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            margin: 0;
            padding: 0;
        }

        .login-container {
            width: 350px;
            margin: 80px auto;
            padding: 20px;
            background-color: #fff;
            border: 1px solid #ddd;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0,0,0,0.1);
        }

        h1 {
            text-align: center;
            margin-bottom: 20px;
        }

        .form-group {
            margin-bottom: 15px;
        }

        label {
            display: block;
            margin-bottom: 5px;
        }

        .form-control {
            width: 100%;
            padding: 8px;
            box-sizing: border-box;
        }

        .error-message {
            color: IndianRed;
            font-size: 0.9em;
        }

        .submit-btn {
            width: 100%;
            padding: 10px;
            background-color: #4285f4;
            color: white;
            border: none;
            border-radius: 4px;
            cursor: pointer;
        }
        .register-btn {
            width: 100%;
            padding: 10px;
            background-color: #4285f4;
            color: white;
            border: none;
            border-radius: 4px;
            cursor: pointer;
            margin:10px;
        }

        .submit-btn:hover {
            background-color: #357ae8;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="login-container">
            <h1>Login</h1>

            <div class="form-group">
                <label for="txtname">Username</label>
                <asp:TextBox ID="txtname" runat="server" CssClass="form-control" />
                <asp:RequiredFieldValidator 
                    ControlToValidate="txtname"
                    ErrorMessage="Name is Mandatory" 
                    CssClass="error-message"
                    runat="server" />
            </div>

            <div class="form-group">
                <label for="txtpassword">Password</label>
                <asp:TextBox ID="txtpassword" runat="server" TextMode="Password" CssClass="form-control" />
                <asp:RequiredFieldValidator 
                    ControlToValidate="txtpassword"
                    ErrorMessage="Password is Mandatory" 
                    CssClass="error-message"
                    runat="server" />
                <asp:RegularExpressionValidator 
                    ID="regexPassword" 
                    ControlToValidate="txtpassword"
                    ValidationExpression="^(?=.*\d).{6,}$"
                    ErrorMessage="Password must be at least 6 characters and include a number." 
                    CssClass="error-message"
                    runat="server" />
            </div>

            <asp:Button ID="btnsubmit" runat="server" Text="Login" CssClass="submit-btn" OnClick="btnsubmit_Click" />
            <asp:Button ID="btnRegister" runat="server" Text="Register"
                CssClass="register-btn"
                OnClick="btnregister_Click"
                CausesValidation="false" />
            <asp:Label ID="lbltext" runat="server" />        

        </div>
    </form>
</body>
</html>
