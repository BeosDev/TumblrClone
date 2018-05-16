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
    public class LoginController
    {
        UserModel userModel = new UserModel();
        internal void Login(string username, string password, HttpResponse response, HttpSessionState session)
        {
            DataTable user = userModel.GetUser(username, password);
            if (user.Rows.Count > 0)
            {
                session["userid"] = user.Rows[0]["ID"];
                session["username"] = user.Rows[0]["USERNAME"];
                session["loai_tk"] = user.Rows[0]["LOAI_TK"];
                response.Write("<script>alert("+ user.Rows[0]["LOAI_TK"] + ")</script>");
                if (user.Rows[0]["LOAI_TK"].ToString().Equals("0"))
                    response.Redirect("UserManagement.aspx");
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