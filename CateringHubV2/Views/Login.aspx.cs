using CateringHubV2.Models;
using CateringHubV2.Repositories;
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
            return;

            String email = EmailTxt.Text;
            String password = PasswordTxt.Text;

            User u = UserRepository.FindUserByEmail(email);
            if (u == null || u.UserPassword != password)
            {
                return;
            }

            Session["user"] = u;

            // Response.Redirect("~/Home.aspx");
        }
    }
}