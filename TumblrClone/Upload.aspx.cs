using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TumblrClone.CONTROLLERS;

namespace TumblrClone
{
    public partial class Upload : System.Web.UI.Page
    {
        UploadController postController = new UploadController();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public String GetTimestamp(DateTime value)
        {
            return value.ToString("yyyyMMddHHmmssfff");
        }

        protected void btn_upload_Click(object sender, EventArgs e)
        {
  
            FileInfo f = new FileInfo(fu_image.FileName);
            string fileName = GetTimestamp(DateTime.Now) + f.Extension;

            fu_image.SaveAs(Server.MapPath("./IMAGES/") + fileName);
            string url = Server.MapPath("./IMAGES/") + fileName;

            string title = txb_title.Text;
            int uid = int.Parse(txb_uid.Text);
            string image_url = url;
            string description = txb_description.Text;
            postController.Upload(title, uid, image_url, description, Response);
            Response.Redirect("Upload.aspx");
        }
    }
}