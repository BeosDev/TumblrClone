using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using TumblrClone.MODELS.DAO;

namespace TumblrClone.MODELS
{
    public class CommentModel
    {
        private static CommentModel instance;
        public static CommentModel Instance
        {
            get { if (instance == null) instance = new CommentModel(); return CommentModel.instance; }
            private set { CommentModel.instance = value; }
        }
  
        public DataTable getCommentViaPID(int id)
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM COMMENT WHERE PID = @PID ", new object[] {id});
        }
    }
}