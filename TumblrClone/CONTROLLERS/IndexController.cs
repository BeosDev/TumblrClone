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
    public class IndexController
    {
        private static IndexController instance;
        public static IndexController Instance
        {
            get { if (instance == null) instance = new IndexController(); return IndexController.instance; }
            private set { IndexController.instance = value; }
        }

        internal void loadPost(ref Repeater rpt)
        {
            DataTable db = PostModel.Instance.getPosts();
            db.Columns.Add("COUNT_LIKE", typeof(int));
            for (int i = 0; i < db.Rows.Count; i++)
            {
                db.Rows[i]["COUNT_LIKE"] = LikerModel.Instance.countLikes(int.Parse(db.Rows[i]["ID"].ToString()));
            }
            rpt.DataSource = db;
            rpt.DataBind();
        }

        internal void actionLike(ref Repeater rpt, int uid,int pid)
        {
            if (LikerModel.Instance.isExistLike(uid,pid) > 0)
            {
                LikerModel.Instance.removeLike(uid,pid);
            }
            else
            {
                LikerModel.Instance.addLike(uid, pid);
            }
            loadPost(ref rpt);
        }
    }
}