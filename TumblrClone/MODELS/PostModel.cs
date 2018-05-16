using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using TumblrClone.MODELS.DAO;

namespace TumblrClone.MODELS
{
    public class PostModel
    {
        private static PostModel instance;
        public static PostModel Instance
        {
            get { if (instance == null) instance = new PostModel(); return PostModel.instance; }
            private set { PostModel.instance = value; }
        }

        public DataTable getPosts()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM POST");
        }

        public int upload(string title, int uid, string image_url, string description)
        {
            string query = "insert into POST(TITLE, UID, IMAGE_URL, DESCRIPTION) values (N'" + title + "', '" + uid + "', '" + image_url + "', '" + description + "')";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public int delete(string id)
        {
            string query = "delete POST where Id = '"+id+"'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}