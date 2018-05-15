using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TumblrClone.CONTROLLERS;

namespace TumblrClone.VIEWS
{
    public partial class Login : System.Web.UI.Page
    {
        string loai_tk;
        UserController userController = new UserController();
        protected void Page_Load(object sender, EventArgs e)
        {


            if (Session["username"] != null)
            {
                if (Session["loai_tk"] != null)
                {
                    loai_tk = Session["loai_tk"].ToString();
                    if (loai_tk.Equals("Admin"))
                        Response.Redirect("Admin.aspx");
                    else
                        Response.Redirect("Index.aspx");
                }
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            userController.Login(username, password, Response,Session);
        }
    }
}