using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TumblrClone.CONTROLLERS;

namespace TumblrClone
{
    public partial class UserManagement : System.Web.UI.Page
    {
        UserManagementController managementController = new UserManagementController(); 
        protected void Page_Load(object sender, EventArgs e)
        {
            managementController.LoadUserTable(rUsers);
            if(null != Request.QueryString["id"])
            {
                managementController.DeleteUser(Request.QueryString["id"]);
                Response.Redirect("UserManagement.aspx");
            }
        }

        protected void btn_Click(object sender, EventArgs e)
        {
            if(null != hfID && hfID.Value.Length > 0)
            {
                managementController.EditUser(hfID.Value, txtUsername.Text, txtPassword.Text, txtFullname.Text, ddlTypeOfUser.SelectedValue);
            }
            else
            {
                managementController.AddUser(txtUsername.Text, txtPassword.Text, txtFullname.Text, ddlTypeOfUser.SelectedValue);
            }
            Response.Redirect("UserManagement.aspx");
        }
    }
}