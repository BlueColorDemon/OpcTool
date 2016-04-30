using OpcAppDemo.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpcAppDemo.Common
{
    public class TagDataOper
    {
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="ServerName"></param>
        /// <param name="AliasName"></param>
        /// <param name="TagValue"></param>
        /// <param name="Qualities"></param>
        /// <param name="TimeStamps"></param>
        public static int Add(TagData tagData)
        {
            using (SqlConnection connection = new SqlConnection(ConfigInfo.ConnectionStr))
            {
                try
                {
                    connection.Open();
                    StringBuilder sql = new StringBuilder();
                    sql.Append("INSERT INTO TagData(   ");
                    sql.Append("    ServerName,");
                    sql.Append("    AliasName,");
                    sql.Append("    TagValue,");
                    sql.Append("    CreateTime");
                    sql.Append("    )");
                    sql.Append("    VALUES (");
                    sql.AppendFormat("'{0}',", tagData.ServerName);
                    sql.AppendFormat("'{0}',", tagData.AliasName);
                    sql.AppendFormat("'{0}',", tagData.TagValue);
                    sql.AppendFormat("'{0}' ", DateTime.Now);
                    sql.Append("    )");
                    SqlCommand comm = new SqlCommand(sql.ToString(), connection);
                    int result = comm.ExecuteNonQuery();
                    return result;
                }
                catch (SqlException ex)
                {
                    return -1;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        /// <summary>
        /// 读取数据
        /// </summary>
        /// <param name="ServerName"></param>
        /// <param name="AliasName"></param>
        public static List<TagData> Read(string ServerName, string AliasName)
        {
            using (SqlConnection connection = new SqlConnection(ConfigInfo.ConnectionStr))
            {
                try
                {
                    var list = new List<TagData>();

                    connection.Open();
                    StringBuilder sql = new StringBuilder();
                    sql.Append("SELECT TOP 100 *");
                    sql.Append("    FROM [TagData]");
                    sql.AppendFormat("    where ServerName='{0}' and AliasName='{1}' ", ServerName, AliasName);
                    sql.Append("    order by CreateTime");
                    SqlCommand comm = new SqlCommand(sql.ToString(), connection);
                    SqlDataReader reader = comm.ExecuteReader();

                    while (reader.Read())
                    {
                        list.Add(new TagData()
                        {
                            Id = Convert.ToInt16(reader[0]),
                            ServerName = reader[1].ToString(),
                            AliasName = reader[2].ToString(),
                            TagValue = reader[3].ToString(),
                            CreateTime = Convert.ToDateTime(reader[4])
                        });
                    }
                    return list;
                }
                catch (SqlException ex)
                {
                    return null;
                }
                finally
                {
                    connection.Close();
                }
            }
        }



    }
}
