using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToEstool.ways
{
    class wayssql
    {
        /// <summary>
        /// 读取数据库
        /// </summary>
        /// <param name="query"></查询语句>
        /// <param name="dbFilePath"></数据库地址>
        /// <returns></returns>
        public DataTable Get_sqldata(string query, string dbFilePath)
        {
            DataTable dataTable = new DataTable();
            // SQLite连接字符串          
            string connectionString = $"Data Source={dbFilePath};Version=3;";

            // 创建SQLite连接
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                // 打开数据库连接
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    // 使用DataAdapter填充DataTable
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                    {
                        // 填充DataTable
                        adapter.Fill(dataTable);
                    }
                }
                // 关闭数据库连接
                connection.Close();
            }
            return dataTable;
        }
        /// <summary>
        /// 清除数据库中所有表的数据
        /// </summary>
        public void del_sqldata(string dbpath)
        {

            // 创建SQLite连接
            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={dbpath};Version=3;"))
            {
                conn.Open();

                // 获取所有表名
                DataTable tables = conn.GetSchema("Tables");
                foreach (DataRow table in tables.Rows)
                {
                    string tableName = table["TABLE_NAME"].ToString();
                    if (tableName!= constants.sqlconstdata)
                    {
                        // 清除表数据
                        using (SQLiteCommand cmd = new SQLiteCommand($"DELETE FROM {tableName}", conn))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }                
                }
                // 关闭连接
                conn.Close();
            }
        }

    }
}
