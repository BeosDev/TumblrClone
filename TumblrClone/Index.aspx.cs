using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TumblrClone.CONTROLLERS;

namespace TumblrClone.VIEWS
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IndexController.Instance.loadPost(ref RptPost);
        }
        protected void btnLike_Click(object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)sender;
            lbTest.Text = btn.CommandName;
            IndexController.Instance.actionLike(ref RptPost,1,int.Parse(btn.CommandName));
        }
    }
}