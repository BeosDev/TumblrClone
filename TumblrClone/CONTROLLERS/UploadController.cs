﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TumblrClone.MODELS;

namespace TumblrClone.CONTROLLERS
{
    public class UploadController
    {
        PostModel postModel = new PostModel();
        internal void Upload(string title, int uid, string image_url, string description, HttpResponse response)
        {
            int check = postModel.upload(title, uid, image_url, description);
            if(check != 0)
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