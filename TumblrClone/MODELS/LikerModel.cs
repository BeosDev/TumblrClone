using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TumblrClone.MODELS.DAO;

namespace TumblrClone.MODELS
{
    public class LikerModel
    {
        private static LikerModel instance;
        public static LikerModel Instance
        {
            get { if (instance == null) instance = new LikerModel(); return LikerModel.instance; }
            private set { LikerModel.instance = value; }
        }

        public int countLikes(int id)
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM LIKER WHERE UID = @UID ", new object[] {id}).Rows.Count;
        }
    }
}