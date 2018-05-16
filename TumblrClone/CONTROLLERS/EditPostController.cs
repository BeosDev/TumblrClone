using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using TumblrClone.MODELS;
using TumblrClone.MODELS.DAO;

namespace TumblrClone.CONTROLLERS
{
    public class EditPostController
    {
        PostModel postModel = new PostModel();
        private static EditPostController instance;
        public static EditPostController Instance
        {
            get { if (instance == null) instance = new EditPostController(); return EditPostController.instance; }
            private set { EditPostController.instance = value; }
        }
        public DataTable getDataWithId(int id)
        {
            return postModel.getPosts(id);
        }

        internal void EditPost(string id, string title, string uid, string url, string desciprtion)
        {
            PostModel.Instance.EditPost(id, title, uid, url, desciprtion);
        }
    }
}