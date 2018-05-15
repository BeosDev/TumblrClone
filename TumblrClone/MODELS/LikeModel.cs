using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TumblrClone.MODELS
{
    public class LikeModel
    {
        private static LikeModel instance;
        public static LikeModel Instance
        {
            get { if (instance == null) instance = new LikeModel(); return LikeModel.instance; }
            private set { LikeModel.instance = value; }
        }

    }
}