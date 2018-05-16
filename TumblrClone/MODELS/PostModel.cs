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
       

        public int deletePost(int pid)
        {
            DataProvider.Instance.ExecuteNonQuery("DELETE FROM LIKER WHERE PID = @PID ", new object[] {pid});
            DataProvider.Instance.ExecuteNonQuery("DELETE FROM COMMENT WHERE PID = @PID ",new object[] {pid});
            return DataProvider.Instance.ExecuteNonQuery("DELETE FROM POST WHERE ID = @PID ", new object[] {pid});

        }
        public DataTable getPostViaUID(int uid)
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM POST WHERE UID = @UID ",new object[] {uid});
        }

        public DataTable getPosts(int id)
        {
            return DataProvider.Instance.ExecuteQuery("SELECT TITLE, UID, IMAGE_URL, DESCRIPTION FROM POST where Id='" + id + "'");
        }

        public int upload(string title, int uid, string image_url, string description)
        {
            string query = "insert into POST(TITLE, UID, IMAGE_URL, DESCRIPTION) values (N'" + title + "', '" + uid + "', '" + image_url + "', '" + description + "')";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public int delete(string id)
        {
            string query = "delete POST where Id = '" + id + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public string getNameImg(int id)
        {
            return DataProvider.Instance.ExecuteScalar("SELECT IMAGE_URL FROM POST WHERE ID = @ID ",
                new object[] {id}).ToString();
        }
    }
}