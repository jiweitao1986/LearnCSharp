using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

using System.Reflection;

namespace LearnCSharp.Basic
{
    class DbDemo
    {

        public static void BasicDemo()
        {
            //连接数据库
            string cntString = "Data Source=127.0.0.1;Initial Catalog=School;Integrated Security=True;";

            SqlConnection sqlCnt = new SqlConnection();
            sqlCnt.ConnectionString = cntString;
            sqlCnt.Open();

            Console.WriteLine(sqlCnt.ToString());

            //执行sql，获取结果集
            SqlCommand sqlCmd = sqlCnt.CreateCommand();
            //SqlCommand sqlCmd = new SqlCommand();
            //sqlCmd.Connection = sqlCnt;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select * from student";
            SqlDataReader reader = sqlCmd.ExecuteReader();

            //遍历结果集
            while (reader.Read())
            {
                Console.WriteLine(reader[0] + "\t" + reader[1] + "\t" + reader[2]);
            }

            //断开与数据库的链接
            sqlCnt.Close();

            Console.ReadKey();
        }

        /// <summary>
        /// 演示数据库连接
        /// </summary>
        /// <returns></returns>
        public static void CntDemo()
        {
            
            //服务器地址：Data Source=Server=Address=Addr=Network Address
            //数据库名称：Initial Catalog=Database
            //验证方式：Integrated Security=Trusted_Connection，为True时，用Windows账户登录，False时，需要指定数据库用户名、密码
            //用户名：User ID 或UID
            //密码：Password=PWD

            string cntString = "Data Source=127.0.0.1;Initial Catalog=School;Integrated Security=False;UID=sa;PWD=123456";

            SqlConnection sqlCnt = new SqlConnection();
            sqlCnt.ConnectionString = cntString;

            sqlCnt.Open();

            Console.WriteLine(sqlCnt.State);



 

            //利用反射遍历连接对象的所有属性
            /*
            Type t = sqlCnt.GetType();
            foreach (PropertyInfo pi in t.GetProperties())
            {
                string name = pi.Name;
                Console.WriteLine(name);
            }
            */
            
            Console.ReadLine();
        }
    }
}
