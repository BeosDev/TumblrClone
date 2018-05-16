using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace TumblrClone.CONTROLLERS
{
    public class ChangePasswordController
    {
        private static ChangePasswordController instance;
        public static ChangePasswordController Instance
        {
            get { if (instance == null) instance = new ChangePasswordController(); return ChangePasswordController.instance; }
            private set { ChangePasswordController.instance = value; }
        }

        internal DataTable CheckUser(string username, string password)
        {
            return MODELS.UserModel.Instance.GetUser(username, password);
        }

        internal void ChangePassword(string username, string newPassword)
        {
            MODELS.UserModel.Instance.EditUser(username, newPassword);
        }
    }
}