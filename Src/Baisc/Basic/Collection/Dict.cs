/*
string value = "1,2";
char[] sep = new char[] {','};
string[] dayVals = value.Split(sep);
Dictionary<string, string> dayNames = new Dictionary<string, string>() {
    {"1", "周一"}, {"2", "周二"}, {"3", "周三"}, {"4", "周四"},
    {"5", "周五"}, {"6", "周六"}, {"7", "周日"}
};
string result = String.Empty;
foreach (string dayVal in dayVals)
{
    if (result.Length > 0)
    {
        result += ",";
    }
    result += dayNames[dayVal];
}

Console.WriteLine(result);
*/