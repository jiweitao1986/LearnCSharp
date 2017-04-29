using System;
using System.Data;
using System.Data.SqlClient;

namespace LearnCSharp.Basic.Db
{
    /// <summary>
    /// SqlServer基础操作
    /// </summary>
    public static class SqlServerTest
    {
        /// <summary>
        /// 运行测试
        /// </summary>
        public static void Run()
        {
            //ConnectTest();
            //RetrieveTest();
            //DeleteTest();
            //CreateTest();
            //UpdateTest();
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
                SqlConnection connect = GetConnection();

                Console.WriteLine("//////////Init//////////");
                Console.WriteLine("ClientConnectionId：" + connect.ClientConnectionId);
                Console.WriteLine("State：" + connect.State.ToString());
                Console.WriteLine();

                Console.WriteLine("//////////Open//////////");
                connect.Open();
                Console.WriteLine("ClientConnectionId：" + connect.ClientConnectionId);
                Console.WriteLine("State：" + connect.State.ToString());
                Console.WriteLine();

                Console.WriteLine("//////////Open//////////");
                connect.Close();
                Console.WriteLine("ClientConnectionId：" + connect.ClientConnectionId);
                Console.WriteLine("State：" + connect.State.ToString());
            }
            catch (Exception e) {
                Console.WriteLine("数据库连接失败！！！");
            }
        }

        /// <summary>
        /// 查询测试
        /// </summary>
        public static void RetrieveTest()
        {
            //连接
            SqlConnection sqlCnt = GetConnection();
            sqlCnt.Open();

            //执行sql，获取结果集
            SqlCommand sqlCmd = sqlCnt.CreateCommand();
            sqlCmd.CommandType = CommandType.Text;

            //遍历结果集
            sqlCmd.CommandText = "select EmployeeID, LastName, FirstName from Employees ";
            SqlDataReader reader = sqlCmd.ExecuteReader();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0,-10}{1,-20}{2,-20}", "ID", "LastName", "FirstName");
            Console.ForegroundColor = ConsoleColor.White;
            while (reader.Read())
            {
                Console.Write("{0,-10}", reader[0]);
                Console.Write("{0,-20}", reader[1]);
                Console.Write("{0,-20}", reader[2]);
                Console.WriteLine();
            }

            //断开与数据库的链接
            sqlCnt.Close();
        }

        /// <summary>
        /// 新增测试
        /// </summary>
        public static void CreateTest()
        {
            //连接
            SqlConnection sqlCnt = GetConnection();
            sqlCnt.Open();
            
            //执行sql，获取结果集
            SqlCommand sqlCmd = sqlCnt.CreateCommand();
            sqlCmd.CommandType = CommandType.Text;

            string[] newEmployees = new string[]
            {
                "('Witt','Ji',    'Other', 'Mr', '1986-06-06')",
                "('Yi',  'Liu',   'Other', 'Mr', '1981-01-01')",
                "('Er',  'Chen',  'Other', 'Ms', '1982-02-02')",
                "('San', 'Zhang', 'Other', 'Mr', '1983-03-03')",
                "('Si',  'Li',    'Other', 'Ms', '1984-04-04')",
                "('Wu',  'Wang',  'Other', 'Mr', '1985-05-05')",
                "('Liu', 'Zhao',  'Other', 'Ms', '1986-06-06')",
                "('Qi',  'Sun',   'Other', 'Mr', '1987-07-07')",
                "('Ba',  'Zhou',  'Other', 'Ms', '1988-08-08')",
                "('Jiu', 'Wu',    'Other', 'Mr', '1989-09-09')",
                "('Shi', 'Zheng', 'Other', 'Mr', '1990-10-10')"
            };
            string newEmployeesString = string.Join(", ", newEmployees);
            sqlCmd.CommandText =
                "insert into Employees "
                + "(LastName, FirstName, Title, TitleOfCourtesy, BirthDate) "
                + "values "
                + newEmployeesString;

            int num = sqlCmd.ExecuteNonQuery();
            Console.WriteLine(num + " rows have been inserted.");
        }

        /// <summary>
        /// 更新操作
        /// </summary>
        public static void UpdateTest()
        {
            //连接
            SqlConnection sqlCnt = GetConnection();
            sqlCnt.Open();

            //执行sql，获取结果集
            SqlCommand sqlCmd = sqlCnt.CreateCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "update Employees set Title='Manager' where LastName='Witt'";
            int num = sqlCmd.ExecuteNonQuery();
            Console.WriteLine(num + " rows have been modified.");
        }

        /// <summary>
        /// 删除测试
        /// </summary>
        public static void DeleteTest()
        {
            //连接
            SqlConnection sqlCnt = GetConnection();
            sqlCnt.Open();

            //执行sql，获取结果集
            SqlCommand sqlCmd = sqlCnt.CreateCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "delete from Employees where LastName in"
                + "('Yi', 'Er', 'San', 'Si', 'Wu', 'Liu', 'Qi', 'Ba', 'Jiu', 'Shi')";
            int num = sqlCmd.ExecuteNonQuery();
            Console.WriteLine(num + " rows have been deleted.");
        }



        #region 工具方法

        /// <summary>
        /// 获取数据库连接
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        /// 服务器地址：
        /// Data Source或Server或Address或Addr或Network Address
        /// 
        /// 验证方式：
        /// Integrated Security或Trusted_Connection
        /// 默认为false，为true时，用Windows账户登录，false时，需要指定数据库用户名、密码
        /// 
        /// 密码：
        /// Password 或 PWD
        /// 
        /// 用户名：
        /// User ID 或 UID
        /// 
        /// 数据库名称：
        /// Initial Catalog或Database
        /// </remarks>
        public static SqlConnection GetConnection()
        {
            string connectString = string.Empty;

            //使用Window用户认证
            //connectString = "Data Source=127.0.0.1;Initial Catalog=NORTHWND;Integrated Security=True;";

            //使用
            //connectString = "Data Source=127.0.0.1;Initial Catalog=NORTHWND;Integrated Security=False;UID=sa;PWD=123456a?";

            connectString = "Server=127.0.0.1;Database=NORTHWND;UID=sa;PWD=123456a?";

            SqlConnection connect = new SqlConnection();
            connect.ConnectionString = connectString;
            return connect;
        }

        #endregion

    }
}