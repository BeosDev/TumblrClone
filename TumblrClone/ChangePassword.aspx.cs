using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TumblrClone
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            string username = Session["username"].ToString();
            if (username != null)
            {
                username = Session["username"].ToString();
                System.Data.DataTable user = CONTROLLERS.ChangePasswordController.Instance.CheckUser(username, txtCurrentPassword.Text);
                if (user.Rows.Count > 0)
                {
                    CONTROLLERS.ChangePasswordController.Instance.ChangePassword(username, txtNewPassword.Text);
                    Response.Redirect("Logout.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Current password is incorrect!')</script>");
                }
            }
        }
    }
}