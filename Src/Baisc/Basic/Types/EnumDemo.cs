using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Basic.Types
{
    enum Days
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    class EnumDemo
    {
        public static void Run()
        {

            
            Days meetingDay = Days.Friday;
            if (meetingDay != Days.Thursday)
            {
                Console.WriteLine("会议日期不是周四！");
            }
        }
    }
}
