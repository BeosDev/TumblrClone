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

        internal void DeleteUser(string id)
        {
            string query = "delete from [USER] where id = @id";
            string[] par = { id };
            DataProvider.Instance.ExecuteNonQuery(query, par);
        }

        internal void EditUser(string id, string username, string password, string fullname, string selectedValue)
        {
            string query = "Update [USER] set USERNAME = @username , PASSWORD = @password , HO_TEN = @hoten , LOAI_TK = @loaitk where ID = @id";
            string[] par = { username, password, fullname, selectedValue, id };
            DataProvider.Instance.ExecuteNonQuery(query, par);
        }

        internal void EditUser(string username, string newPassword)
        {
            string query = "update [USER] set PASSWORD = @newPassword where USERNAME = @username";
            string[] par = { newPassword,username };
            DataProvider.Instance.ExecuteNonQuery(query, par);
        }

        internal DataTable GetUsers()
        {
            string query = "select * from [USER]";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        internal void AddUser(string username, string password, string fullname, string selectedValue)
        {
            string query = "insert [USER](USERNAME, PASSWORD, HO_TEN, LOAI_TK) values( @username , @password , @fullname , @loaitk )";
            string[] par = { username, password, fullname, selectedValue };
            DataProvider.Instance.ExecuteNonQuery(query, par);
        }

        public DataTable GetUser(string username, string password)
        {
            string query = "select * from [USER] where USERNAME = @username and PASSWORD = @password";
            string []para = { username, password };
            DataTable dt = DataProvider.Instance.ExecuteQuery(query,para);
            return dt;
        }

        public DataTable CheckUser(string username)
        {
            string query = "select * from [USER] where USERNAME = @username";
            string[] para = { username };
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, para);
            return dt;
        }
    }
}