using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using TumblrClone.MODELS;
using System.Data;

namespace TumblrClone.CONTROLLERS
{
    public class RegisterController
    {
        internal void Register(string username, string password, string fullname, int typeOfUser, HttpResponse response , HttpSessionState session )
        {
            DataTable account = UserModel.Instance.checkUser(username);
            if (account.Rows.Count == 0)
            {
                UserModel.Instance.Register(username, password, fullname, 1);
                session["username"] = username;
                session["fullname"] = fullname;
                session["loai_tk"] = typeOfUser;
                response.Redirect("Login.aspx");
            }
            else
            {
                response.Write("<script>alert('Username or Password is incorrect!')</script>");
            }
        }
    }
}