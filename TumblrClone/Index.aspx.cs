﻿using System;
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
    }
}