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
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM LIKER WHERE PID = @PID ", new object[] {id}).Rows.Count;
        }
        public int isExistLike(int uid,int pid)
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM LIKER WHERE UID = @UID AND PID = @PID ", new object[] { uid,pid }).Rows.Count;
        }

        public int removeLike(int uid,int pid)
        {
            return DataProvider.Instance.ExecuteNonQuery("DELETE FROM LIKER WHERE UID = @UID AND PID = @PID ", new object[] {uid,pid});
        }

        public int addLike(int uid,int pid)
        {
            return DataProvider.Instance.ExecuteNonQuery("INSERT INTO LIKER VALUES( @UID , @PID )",
                new object[] {uid, pid});
        }
    }
}