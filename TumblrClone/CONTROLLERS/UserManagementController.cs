using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using TumblrClone.MODELS;

namespace TumblrClone.CONTROLLERS
{
    public class UserManagementController
    {
        internal void DeleteUser(string id)
        {
            UserModel.Instance.DeleteUser(id);
        }

        internal void EditUser(string id, string username, string password, string fullname, string selectedValue)
        {
            UserModel.Instance.EditUser(id,username,password,fullname,selectedValue);
        }

        internal void LoadUserTable(Repeater rUsers)
        {
            rUsers.DataSource = UserModel.Instance.GetUsers();
            rUsers.DataBind();
        }

        internal void AddUser(string username, string password, string fullname, string selectedValue)
        {
            UserModel.Instance.AddUser(username, password, fullname, selectedValue);
        }
    }
}