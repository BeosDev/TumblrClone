using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using TumblrClone.MODELS.DAO;
using System.Text;

namespace TumblrClone
{
    public partial class CommentManagement : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
           if (!IsPostBack)
           {
                string delete = Request.QueryString["delete"];
                if(delete!=null)
                {
                    DataProvider.Instance.ExecuteNonQuery("DELETE FROM COMMENT WHERE Id =  "+ delete);
                }
              GridView1.DataSource= DataProvider.Instance.ExecuteQuery("SELECT * FROM COMMENT");
              GridView1.DataBind();
           }
            
           
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}