using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TumblrClone.CONTROLLERS;

namespace TumblrClone
{
    public partial class EditPost : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    int id = int.Parse(Request.QueryString["id"].ToString());
                    DataTable table = EditPostController.Instance.getDataWithId(id);
                    txb_title.Text = table.Rows[0]["TITLE"].ToString();
                    //txb_uid.Text = table.Columns[1].ToString();
                    //fu_image.
                }
            }
        }
    }
}