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
    }
}