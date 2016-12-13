using System;
using System.Data;
using System.Data.SqlClient;

using LearnCSharp.Basic.Utils;

namespace LearnCSharp.Basic.Db
{
    public static class SqlServerTest
    {
        public static void Run()
        {
            //ConnectTest();
            RetrieveTest();
        }

        /// <summary>
        /// 连接测试
        /// </summary>
        public static void ConnectTest()
        {
            OutputUtil.ShowTitle("Sql Server Connect Test");
            try
            {
                //获取连接
                SqlConnection connect = GetConnection(true);

                Console.WriteLine("ClientConnectionId：" + connect.ClientConnectionId);
                Console.WriteLine("State：" + connect.State.ToString());

                connect.Open();
                Console.WriteLine("ClientConnectionId：" + connect.ClientConnectionId);
                Console.WriteLine("State：" + connect.State.ToString());

                connect.Close();
                Console.WriteLine("ClientConnectionId：" + connect.ClientConnectionId);
                Console.WriteLine("State：" + connect.State.ToString());
            }
            catch (Exception e) {
                Console.WriteLine("数据库连接失败！！！");
            }
        }

        /// <summary>
        /// 新增测试
        /// </summary>
        public static void CreateTest()
        {

        }

        /// <summary>
        /// 查询测试
        /// </summary>
        public static void RetrieveTest()
        {
            //连接
            SqlConnection sqlCnt = GetConnection(false);
            sqlCnt.Open();

            //执行sql，获取结果集
            SqlCommand sqlCmd = sqlCnt.CreateCommand();
            sqlCmd.CommandType = CommandType.Text;

            //遍历结果集
            sqlCmd.CommandText = "select * from student";
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader[0] + "\t" + reader[1] + "\t" + reader[2]);
            }

            //断开与数据库的链接
            sqlCnt.Close();
        }


        /// <summary>
        /// 更新操作
        /// </summary>
        public static void UpdateTest()
        {

        }

        public static void DeleteTest()
        {
        }



        #region 工具方法

        /// <summary>
        /// 获取数据库连接
        /// </summary>
        /// <returns></returns>
        public static SqlConnection GetConnection(bool integratedSecurity)
        {

            //服务器地址：Data Source=Server=Address=Addr=Network Address
            //数据库名称：Initial Catalog=Database
            //验证方式：Integrated Security=Trusted_Connection，为True时，用Windows账户登录，False时，需要指定数据库用户名、密码
            //用户名：User ID 或 UID
            //密码：Password 或 PWD

            //连接字符串
            string connectString = string.Empty;
            if (integratedSecurity == true)
            {
                connectString = "Data Source=127.0.0.1;Initial Catalog=School;Integrated Security=True;";
            }
            else
            {
                connectString = "Data Source=127.0.0.1;Initial Catalog=School;Integrated Security=False;UID=sa;PWD=SA123456";
            }

            SqlConnection connect = new SqlConnection();
            connect.ConnectionString = connectString;
            return connect;
        }

        #endregion

    }
}