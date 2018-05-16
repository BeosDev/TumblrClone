using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TumblrClone.CONTROLLERS;
using TumblrClone.MODELS;

namespace TumblrClone
{
    public partial class PostManagement : System.Web.UI.Page
    {
        PostModel postModel = new PostModel();
        PostManagementController postManagementController = new PostManagementController();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                load();
            }
        }
        private void load()
        {
            GridView1.DataSource = postModel.getPosts();
            GridView1.DataBind();
        }
        protected void delete_Click(object sender, EventArgs e)
        {
            postManagementController.Delete(((Button)sender).CommandName, Response);
            load();
        }
    }
}