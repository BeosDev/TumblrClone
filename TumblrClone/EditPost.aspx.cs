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
                    txb_uid.Text = table.Rows[0]["UID"].ToString();
                    txb_description.Text = table.Rows[0]["DESCRIPTION"].ToString();
                }
            }
        }
        public String GetTimestamp(DateTime value)
        {
            return value.ToString("yyyyMMddHHmmssfff");
        }

        protected void btn_edit_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null) {
                System.IO.FileInfo f = new System.IO.FileInfo(fu_image.FileName);
                string fileName = GetTimestamp(DateTime.Now) + f.Extension;

                fu_image.SaveAs(Server.MapPath("./IMAGES/") + fileName);
                string url = Server.MapPath("./IMAGES/") + fileName;
                EditPostController.Instance.EditPost(Request.QueryString["id"], txb_title.Text, txb_uid.Text, url, txb_description.Text);
            }
        }
    }
}