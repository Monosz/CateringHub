using CateringHubV2.Controllers;
using CateringHubV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CateringHubV2.Views
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            string email = EmailTxt.Text;
            string password = PasswordTxt.Text;

            if (!UserController.ValidateLogin(email, password))
            {
                // ErrorMsg?
                return;
            }

            User u = UserController.FindUserByEmail(email);

            Session["user"] = u.UserId;

            Response.Redirect("~/Views/Home.aspx");
        }
    }
}