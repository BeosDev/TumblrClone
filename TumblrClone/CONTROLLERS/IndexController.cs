using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using TumblrClone.MODELS;

namespace TumblrClone.CONTROLLERS
{
    public class IndexController
    {
        internal void loadPost(ref Repeater rpt)
        {
            rpt.DataSource = PostModel
        }
    }
}