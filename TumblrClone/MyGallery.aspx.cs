using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TumblrClone.CONTROLLERS;

namespace TumblrClone
{
    public partial class MyGallery : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GalleryController.Instance.getGallery(ref RptGallery, 1);
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Button btn = (Button) sender;
            GalleryController.Instance.deleteImage(ref RptGallery,1,Int32.Parse(btn.CommandName));
        }
    }
}