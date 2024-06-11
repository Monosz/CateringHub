using CateringHubV2.Controllers;
using CateringHubV2.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CateringHubV2.Views
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RegisterBtn_Click(object sender, EventArgs e)
        {
            String name = NameTxt.Text;
            String email = EmailTxt.Text;
            String password = PasswordTxt.Text;

            if (!UserController.ValidateRegister())
            {
                // ErrorMsg?
                return;
            }

            UserController.AddUser(UserFactory.CreateUser(name, email, password));

            Response.Redirect("~/Views/Login.aspx");
        }
    }
}