using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace TumblrClone
{
    public partial class Register : System.Web.UI.Page
    {
        CONTROLLERS.RegisterController control = new CONTROLLERS.RegisterController();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            control.Register(txtUsername.Text, txtPassword.Text, txtFullName.Text, 1, Response, Session);
        }
    }
}