using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using TumblrClone.MODELS;
using TumblrClone.MODELS.DAO;

namespace TumblrClone.CONTROLLERS
{
    public class GalleryController
    {
        private static GalleryController instance;
        public static GalleryController Instance
        {
            get { if (instance == null) instance = new GalleryController(); return GalleryController.instance; }
            private set { GalleryController.instance = value; }
        }

        internal void getGallery(ref Repeater rpt,int uid)
        {
            rpt.DataSource = PostModel.Instance.getPostViaUID(uid);
            rpt.DataBind();
        }

        internal void deleteImage(ref Repeater rpt, int uid, int pid)
        {
            if (PostModel.Instance.deletePost(pid) > 0)
            {
                rpt.DataSource = PostModel.Instance.getPostViaUID(uid);
                rpt.DataBind();
            }
        }
    }
}