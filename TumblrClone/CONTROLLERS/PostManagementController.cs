using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TumblrClone.MODELS;

namespace TumblrClone.CONTROLLERS
{
    public class PostManagementController
    {
        PostModel postModel = new PostModel();
        internal void Delete(string id, HttpResponse response)
        {
            int check = postModel.delete(id);
            if (check != 0)
            {
                response.Write("<script>alert('Upload Successful!')</script>");
            }
            else
            {
                response.Write("<script>alert('Upload Fail!')</script>");
            }
        }
    }
}