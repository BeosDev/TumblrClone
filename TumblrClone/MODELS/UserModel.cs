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
        DataProvider dataProvider = new DataProvider();
        public DataTable GetUser(string username, string password)
        {
            string query = "select * from USERS where USERNAME = @username and PASSWORD = @password";
            string []para = { username, password };
            DataTable dt = dataProvider.ExecuteQuery(query,para);
            return dt;
        }
    }
}