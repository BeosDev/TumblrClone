using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using TumblrClone.MODELS;
using TumblrClone.MODELS.DAO;

namespace TumblrClone.CONTROLLERS
{
    public class PageDetailController
    {
        private static PageDetailController instance;
        public static PageDetailController Instance
        {
            get { if (instance == null) instance = new PageDetailController(); return PageDetailController.instance; }
            private set { PageDetailController.instance = value; }
        }

        internal void getPageDetail(ref Image img,ref Repeater rptCmt,int id)
        {
            img.ImageUrl = "./IMAGES/"+ PostModel.Instance.getNameImg(id);
            rptCmt.DataSource =
                DataProvider.Instance.ExecuteQuery(
                    "SELECT tb2.USERNAME , tb1.CONTENT FROM [COMMENT] tb1 INNER JOIN [USER] tb2 ON tb1.UID = tb2.ID WHERE PID = @PID ",
                    new object[] {id});
            rptCmt.DataBind();
        }

        internal void addComment(HttpRequest request, HttpResponse response, int pid, int uid,string content)
        {
            if (CommentModel.Instance.addComment(uid, pid, content) > 0)
            {
                response.Redirect(request.RawUrl);
            }
        }
    }
}