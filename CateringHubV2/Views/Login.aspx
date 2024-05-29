<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CateringHubV2.Views.Login" %>

<!DOCTYPE html>

<html xmlns=y"http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link rel="stylesheet" href="../Styles/loginregister.css" />
</head>
<body>
    <!-- CATERING HUB LOGO -->
    <div class="log-reg">
        <asp:Image ID="CateringHubImg" runat="server" ImageUrl="~/Assets/cateringhub-logo.png" AlternateText="logo-cateringhub" Width="300px" />
    </div>
    <!-- CATERING HUB LOGO END -->
    
    <!-- FORM -->
    <div class="form">
        <form runat="server">
            <asp:Label ID="EmailLbl" runat="server" Text="Email address"></asp:Label>
            <asp:TextBox ID="EmailTxt" runat="server" TextMode="Email" placeholder="somebody@example.com"></asp:TextBox>
            <div id="log-reg-email-error"></div>

            <asp:Label ID="PasswordLbl" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="PasswordTxt" runat="server" TextMode="Password" placeholder="Password"></asp:TextBox>
            <div id="log-reg-password-error"></div>

            <asp:Button ID="LoginBtn" runat="server" CssClass="login-btn" Text="Login" OnClick="LoginBtn_Click" />
        </form>
    <!-- FORM END -->
    
    <!-- LOGIN WITH -->
        <div class="log-reg-with">
            <p>Or, login with</p>

            <div class="container">
                <div class="logo">
                    <asp:Image ID="GoogleImg" runat="server" ImageUrl="~/Assets/google-logo.png" AlternateText="google-logo" Width="60px" />
                </div>
                <div class="logo">
                    <asp:Image ID="FacebookImg" runat="server" ImageUrl="~/Assets/facebook-logo.png" AlternateText="facebook-logo" Width="60px" />
                </div>
                <div class="logo">
                    <asp:Image ID="AppleImg" runat="server" ImageUrl="~/Assets/apple-logo.png" AlternateText="apple-logo" Width="60px" />
                </div>
            </div>
        </div>
    <!-- LOGIN WITH END -->

    <!-- FOOTER -->
        <div class="footer">
            <p>Haven't account? <a href="Register.aspx">Register now</a></p>
        </div>
    <!-- FOOTER END -->
    </div>
</body>
</html>
