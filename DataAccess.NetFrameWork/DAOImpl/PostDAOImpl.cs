using DataAccess.NetFrameWork.DTO;
using DataAccess.NetFrameWork.Interface;
using DataAccess.NetFrameWork.SQL_HELPER;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.NetFrameWork.DAOImpl
{
    public class PostDAOImpl : IPostDAO
    {
        public List<Post> GetPosts()
        {
            var list = new List<Post>();
            try
            {
                // Bước 1 : 
                var connection = DB_Helper.GetSqlConnection();
                var cmd = new SqlCommand("SP_Post_GetAll", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                /// var param = cmd.Parameters.AddWithValue("")
                /// 
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var p = new Post
                    {
                        PostID = reader["PostID"] != null ? Convert.ToInt32(reader["PostID"]) : 0,
                        PostName = reader["PostName"] != null ? reader["PostName"].ToString() : String.Empty
                    };

                    list.Add(p);
                }

                connection.Close();

                return list;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int Post_Insert(Post post)
        {
            int rs = 0;
            try
            {
                // Bước 1 : 
                var connection = DB_Helper.GetSqlConnection();
                var cmd = new SqlCommand("SP_PostInsert", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@_PostName", post.PostName); // input c# -> DB 
                cmd.Parameters.Add("@_ResponseCode", System.Data.SqlDbType.Int).Direction = System.Data.ParameterDirection.Output; // DB -> C#

                var result = cmd.ExecuteNonQuery();
                connection.Close();

                rs = cmd.Parameters["@_ResponseCode"].Value != null ? Convert.ToInt32(cmd.Parameters["@_ResponseCode"].Value) : 0;

                return rs;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
