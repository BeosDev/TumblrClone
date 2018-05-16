using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TumblrClone.CONTROLLERS;

namespace TumblrClone.VIEWS
{
    public partial class PageDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
            {
                int id = int.Parse(Request.QueryString["id"].ToString());
                PageDetailController.Instance.getPageDetail(ref myImg,ref rptCmt, id);
            }
        }
    }
}