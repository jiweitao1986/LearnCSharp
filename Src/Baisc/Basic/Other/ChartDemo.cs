using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;

using System.Data;
using System.Data.SqlClient;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace LearningCSharp.Basic
{
    class ChartDemo
    {
        public static void Run()
        {
            string chartOptsString = "{";
            chartOptsString += "\"xAxis\":[{\"_field\":\"HourDate\",\"_formatType\":\"datetime\",\"_formatString\":\"d\"}],";
            chartOptsString += "\"yAxis\":[{\"_field\":\"\",\"_formatType\":\"\",\"_formatString\":\"\"}],";
            chartOptsString += "\"series\":[{\"type\":\"line\",\"_field\":\"StudyHour\",\"_formatType\":\"numeric\",\"_formatString\":\"#,#.0\"},{\"type\":\"column\",\"_field\":\"SleepHour\",\"_formatType\":\"\",\"_formatString\":\"\"}]";
            chartOptsString += "}";

            JObject chartOpts = JObject.Parse(chartOptsString);

            //数据库中读取数据
            DataSet chartData = GetChartData();

            //格式化数据
            Dictionary<string, ArrayList> formatChartData = FormatChartData(chartOpts, chartData);

            //生成JSON并返回。
            Console.WriteLine(JsonConvert.SerializeObject(formatChartData));
        }

        public static ArrayList GetPartOfChartOpts(JObject optJObject, string optName)
        {
            //初始化
            ArrayList optArrayList = new ArrayList();

            //解析xAxis
            JArray optJArray = (JArray)optJObject[optName];

            foreach (JObject items in optJArray)
            {
                Dictionary<string, string> optDict = new Dictionary<string, string>();
                foreach (var item in items)
                {
                    optDict.Add(item.Key, item.Value.ToString().Replace("\"", ""));
                }
                optArrayList.Add(optDict);
            }
            return optArrayList;
        }

        public static DataSet GetChartData()
        {
            //连接数据库
            //string connectionString = "Data Source=MSSQL1;Initial Catalog=AdventureWorks; Integrated Security=true;";
            string cntString = "Data Source=.;Initial Catalog=School; Integrated Security=true;";
            SqlConnection sqlCnt = new SqlConnection();
            sqlCnt.ConnectionString = cntString;
            sqlCnt.Open();

            //获取数据
            string sql = "SELECT S.Name, SH.* FROM Student AS S  ";
            sql += "LEFT JOIN  StudentHour AS SH ON S.ID=SH.StudentID ";
            sql += "WHERE S.ID=1";
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
            return myDataSet;

        }

        public static Dictionary<string, ArrayList> FormatChartData(JObject chartOpts, DataSet chartData)
        {
            //初始化
            Dictionary<string, ArrayList> formatChartData = new Dictionary<string, ArrayList>();

            //解析配置选项
            ArrayList xAxisOptList = GetPartOfChartOpts(chartOpts, "xAxis");
            ArrayList yAxisOptList = GetPartOfChartOpts(chartOpts, "yAxis");
            ArrayList seriesOptList = GetPartOfChartOpts(chartOpts, "series");

            //组织x轴数据
            ArrayList xAxisDataList = PluckAndFormat(chartData, xAxisOptList);

            //组织y轴数据
            ArrayList yAxisDataList = PluckAndFormat(chartData, yAxisOptList);

            //组织series数据
            ArrayList seriesDataList = PluckAndFormat(chartData, seriesOptList);


            formatChartData.Add("xAxis", xAxisDataList);
            formatChartData.Add("yAxis", xAxisDataList);
            formatChartData.Add("series", seriesDataList);

            //系列类型为饼状图的时候，合并x轴和系列的数据
            return formatChartData;
        }

        /// <summary>
        /// 从DataSet中抽取指定字段，并进行格式化
        /// </summary>
        /// <param name="ds">DataSet数据</param>
        /// <param name="optList">配置选项</param>
        /// <returns></returns>
        public static ArrayList PluckAndFormat(DataSet ds, ArrayList optList)
        {
            ArrayList dataList = new ArrayList();
            foreach (Dictionary<string, string> opt in optList)
            {
                //格式选项
                string field = opt["_field"];
                string formatType = opt["_formatType"];
                string formatString = opt["_formatString"];

                if (field != "")
                {
                    ArrayList dataItem = new ArrayList();
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        object rowField = row[field];
                        object formatField = FormatFieldValue(rowField, formatType, formatString);
                        dataItem.Add(formatField);
                    }
                    dataList.Add(dataItem);
                }
            }
            return dataList;
        }

        public static object FormatFieldValue(object fieldValue, string formatType, string formatString)
        {
            object formatFieldValue;
            if (formatType == "datetime" && formatString != String.Empty)
            {
                formatFieldValue = DateTime.Parse(fieldValue.ToString()).ToString(formatString);
            }
            else if (formatType == "numeric" && formatString != String.Empty)
            {
                //格式化数字
                string strFieldValue = Single.Parse(fieldValue.ToString()).ToString(formatString);
                Regex intReg =new Regex(@"^\d+$");
                Regex floatReg = new Regex(@"^(-?\d+)(\.\d+)?$");
                if (intReg.IsMatch(strFieldValue))
                {
                    formatFieldValue = Int32.Parse(strFieldValue);
                }
                else if (floatReg.IsMatch(strFieldValue))
                {
                    formatFieldValue = Single.Parse(strFieldValue);
                }
                else
                {
                    formatFieldValue = strFieldValue;
                }
            }
            else
            {
                formatFieldValue = fieldValue;
            }
            return formatFieldValue;
        }

    }
}
