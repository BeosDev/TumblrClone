using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using TumblrClone.MODELS;

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
            rpt.DataSource = PostModel.Instance.getPosts();
        }
    }
}