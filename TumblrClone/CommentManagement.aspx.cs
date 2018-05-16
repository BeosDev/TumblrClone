using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using TumblrClone.MODELS.DAO;

namespace TumblrClone
{
    public partial class CommentManagement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataProvider.Instance.ExecuteQuery("SELECT * FROM COMMENT");
        }
    }
}