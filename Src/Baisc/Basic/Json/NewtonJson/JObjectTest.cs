using System;
using Newtonsoft.Json.Linq;

namespace LearnCSharp.Basic.Json.NewtonJson
{
    public static class JObjectTest
    {

        public static void Run()
        {
            ParseTest();
        }

        public static void ParseTest()
        {
            string strJson = @"{
                CPU: 'Intel',
                Price: 5000.00,
                ProductionDate: '2017-01-01 01:01:01',
                DiscreteGraphics: false,
                Drives: [
                    'DVD read/writer',
                    '500 gigabyte hard drive'
                ],
                Company: {
                    Name: 'Lenovo',
                    Tel: '0531-88888888'
                }
            }";
            JObject jObject = JObject.Parse(strJson);

            foreach (var jTokenPair in jObject)
            {
                var jTokenKey = jTokenPair.Key;
                var jToken = jTokenPair.Value;

                if (jToken is JValue)
                {
                    Console.WriteLine("|----" + jTokenKey + "：" + (jToken as JValue).Value);
                }
                else if (jToken is JArray)
                {
                    Console.WriteLine("|----" + jTokenKey);
                    foreach (var jArrayToken in jToken)
                    {
                        if (jArrayToken is JValue)
                        {
                            Console.WriteLine("|----|----" + (jArrayToken as JValue).Value);
                        }
                    }
                } else if (jToken is JObject)
                {
                    Console.WriteLine("|----" +　jTokenKey);
                    foreach (var jObjectTokenPair in (jToken as JObject))
                    {
                        var jObjectTokenKey = jObjectTokenPair.Key;
                        var jObjectToken    = jObjectTokenPair.Value;
                        if (jObjectToken is JValue)
                        {
                            Console.WriteLine("|----|----" + jObjectTokenKey + "：" + (jObjectToken as JValue).Value);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Unknown Type");
                }

            }
        }
    }
}
