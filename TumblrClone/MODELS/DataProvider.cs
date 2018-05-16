using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TumblrClone.MODELS.DAO
{
    public class DataProvider
    {
        // Tạo kết nối với sql
        //private String connectionSTR = System.Configuration.ConfigurationManager.ConnectionStrings["TumblrClone"].ConnectionString;
        private String connectionSTR = @"Data Source=DESKTOP-3R43QO1\SQL;Initial Catalog=D:\PROJECT\TUMBLR\TUMBLR-CLONE\NEW\TUMBLRCLONE\TUMBLRCLONE\APP_DATA\TUMBLRCLONE.MDF;Integrated Security=True";
        // Hạn chế việc tạo AccountDao nhiều lần phát sinh các connection để chỉ tạo duy nhất 1 lần
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }


        //Lấy ra bảng dữ liệu 
        //Parameter chứa các giá trị để tìm xuất ra dữ liệu
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            //    DataTable data = new DataTable();

            //    using (SqlConnection connection = new SqlConnection(connectionSTR))
            //    {
            //        connection.Open();

            //        SqlCommand command = new SqlCommand(query, connection); //Tạo truy ván query trong database

            //        if (parameter != null)
            //        {
            //            string[] listPara = query.Split(' '); // Đưa câu truy vấn thành mảng để 
            //            int i = 0;
            //            foreach (string item in listPara)
            //            {
            //                if (item.Contains('@'))
            //                {
            //                    command.Parameters.AddWithValue(item, parameter[i]); //Add vào các giá trị cần truy vấn vào command
            //                    i++;
            //                }
            //            }
            //        }

            //        SqlDataAdapter adapter = new SqlDataAdapter(command);

            //        adapter.Fill(data); // Chuyển từ datasource sang dataTable

            //        connection.Close();
            //    }

            //    return data;
            //

            SqlConnection cnn = new SqlConnection(connectionSTR);
            DataTable table = new DataTable();
            cnn.Open();
            SqlCommand cmd = new SqlCommand(query, cnn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            cnn.Close();
            return table;
        }

        // Trả về số dòng table bị thay đổi trong database bởi sử dụng các lệnh như INSERT, DELETE, UPDATE
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;

                    //Thêm các giá trị vào truy vấn
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery(); // Số dòng thay đổi

                connection.Close();
            }

            return data;
        }

        // Trả về 1 dữ liệu duy nhất
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;

                    //Thêm các giá trị vào truy vấn
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar(); // đưa dữ liệu vào data

                connection.Close();
            }

            return data;
        }


        public void ExecuteQuerysimple(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
