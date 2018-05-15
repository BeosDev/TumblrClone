using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using TumblrClone.MODELS.DAO;

namespace TumblrClone.MODELS
{
    public class UserModel
    {
        public DataTable GetUser(string username, string password)
        {
            string query = "select * from USERS where USERNAME = @username and PASSWORD = @password";
            string []para = { username, password };
            DataTable dt = DataProvider.Instance.ExecuteQuery(query,para);
            return dt;
        }
    }
}