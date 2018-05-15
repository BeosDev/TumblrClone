using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using TumblrClone.MODELS;

namespace TumblrClone.CONTROLLERS
{
    public class UserController
    {
        UserModel userModel = new UserModel();
        internal void Login(string username, string password, HttpResponse response, HttpSessionState session)
        {
            DataTable user = userModel.GetUser(username, password);
            if (user.Rows.Count == 0)
            {
                session["username"] = user.Rows[0]["USERNAME"];
                session["loai_tk"] = user.Rows[0]["LOAI_TK"];
                if (user.Rows[0]["LOAI_TK"].ToString().Equals("Admin"))
                    response.Redirect("Admin.aspx");
                else
                    response.Redirect("Index.aspx");
            }
            else
            {
                response.Write("<script>alert('Username or Password is incorrect!')</script>");
            }
        }
    }
}