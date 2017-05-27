using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.Basic.Collection
{
    public static class IEnumerableTest
    {
        public static void Run()
        {
            CastTest();
            ToDicTest();
        }

        public static void CastTest()
        {
            OutputUtil.ShowTitle("Cast Test");

            var animals = new List<Animal>();
            animals.Add(new Cow("Cow1st"));
            animals.Add(new Cow("Cow2st"));
            animals.Add(new Cow("Cow3st"));

            //转换类型前
            foreach (var animal in animals)
            {
                animal.Feed();
            }

            //转换类型后
            var cows = animals.Cast<Cow>();
            foreach (var cow in cows)
            {
                cow.Milk();
            }
        }

        public static void ToDicTest()
        {

            OutputUtil.ShowTitle("ToDictionary Test");

            var persons = MockDataUtil.GetEmployees();
            var males = persons.Where(p => p.Gender == Gender.Male).ToDictionary(p => p.Id);
            foreach (var malePair in males)
            {
                Console.WriteLine(malePair.Key + ":" + malePair.Value.Name);
            }
        }
    }
}
