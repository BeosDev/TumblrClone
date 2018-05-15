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
        private static UserModel instance;
        public static UserModel Instance
        {
            get { if (instance == null) instance = new UserModel(); return UserModel.instance; }
            private set { UserModel.instance = value; }
        }

        public DataTable GetUser(string username, string password)
        {
            string query = "select * from USERS where USERNAME = @username and PASSWORD = @password";
            string []para = { username, password };
            DataTable dt = DataProvider.Instance.ExecuteQuery(query,para);
            return dt;
        }
    }
}