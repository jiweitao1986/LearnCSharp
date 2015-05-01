using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;


namespace LearningCSharp.Basic
{
    class DataSetDemo
    {
        /// <summary>
        /// 连接数据库
        /// </summary>
        /// <returns></returns>
        public static SqlConnection GetSqlConnection()
        {
            //string cntString = "Data Source=MSSQL1;Initial Catalog=AdventureWorks; Integrated Security=true;";
            string cntString = "Data Source=.;Initial Catalog=School; Integrated Security=true;";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = cntString;
            connection.Open();
            return connection;

        }

        public static void Demo1()
        {
            SqlConnection sqlCnt = GetSqlConnection();

            //获取数据
            string sql = "SELECT S.Name, SC.Grade FROM Student AS S  ";
            sql += "LEFT JOIN  StudentCourse AS SC ON s.id=sc.StudentID ";
            sql += "WHERE CourseID=1";
            SqlDataAdapter myDataAdapter = new SqlDataAdapter(sql, sqlCnt);
            DataSet myDataSet = new DataSet();
            myDataAdapter.Fill(myDataSet, "student");

            DataTable myTable = myDataSet.Tables["student"];
            foreach (DataRow myRow in myTable.Rows)
            {
                foreach (DataColumn myColumn in myTable.Columns)
                {
                    Console.Write(myRow[myColumn] + "\t");
                }
                Console.WriteLine();
            }

            //断开与数据库的链接
            sqlCnt.Close();
            Console.ReadKey();
        }

        public static void readerDemo()
        {
            //连接数据库
            string cntConfig = "server=127.0.0.1;database=School;uid=sa;pwd=123456";
            SqlConnection sqlCnt = new SqlConnection(cntConfig);
            sqlCnt.Open();

            //执行sql
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

    }
}
