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
            string query = "select * from [USER] where USERNAME = @username and PASSWORD = @password";
            string[] para = { username, password };
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, para);
            return dt;
        }

        public DataTable checkUser(string username)
        {
            string query = "select * from [USER] where USERNAME = @username";
            string[] para = { username };
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, para);
            return dt;
        }

        public void Register( string fullname, string username, string password)
        {
            string query = "INSERT INTO [USER] (USERNAME, PASSWORD, HO_TEN) VALUES ( @fullname , @username , @password )";
            string[] para = { username, fullname , password };
            DataProvider.Instance.ExecuteNonQuery(query, para);
        }

        internal void Register(string username, string password, string fullname, int loai_tk)
        {
            string query = "INSERT INTO [USER] (USERNAME, PASSWORD, HO_TEN, LOAI_TK) VALUES ( @username , @password , @fullname , @loai_tk )";
            object[] para = { username, password , fullname , loai_tk};
            DataProvider.Instance.ExecuteNonQuery(query, para);
        }
    }
}