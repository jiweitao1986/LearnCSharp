using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Basic
{
    class EventDemo
    {

        public static void Run()
        {
        
            List<Event> eventList = new List<Event>();

            Event onInitialized = new Event
            {
                Type = "Custom",
                Script = "",
                Positon = "onInitialized",
                Priority = 100
            };

            Event afterWidgetsInit = new Event
            {
                Type = "Custom",
                Script = "console.log('afterWidgetsInit ...')",
                Positon = "render",
                Priority = 300
            };

            Event initWidgets = new Event
            {
                Type = "Register",
                Script = "console.log('initWidgets ...')",
                Positon = "initWidgets",
                Priority = 500
            };

            Event onInitializing = new Event
            {
                Type = "Register",
                Script = "console.log('onInitializing ...')",
                Positon = "onInitializing",
                Priority = 400
            };

            Event render = new Event
            {
                Type = "Register",
                Script = "console.log('render ...')",
                Positon = "render",
                Priority = 200
            };

            eventList.AddRange(new Event[5] {
                onInitialized, afterWidgetsInit,
                initWidgets, onInitializing, render
            });

            ListSort(eventList, "Priority", "desc");

            //排序
            foreach (Event e in eventList)
            {
                Console.WriteLine("{0}:{1}", e.Positon, e.Priority);
            }

            //分组
            


        }

        private static void ListSort(List<Event> eventList, string field, string rule)
        {
            if (!string.IsNullOrEmpty(rule) && (!rule.ToLower().Equals("desc") || !rule.ToLower().Equals("asc")))
            {
                try
                {
                    eventList.Sort(
                        delegate(Event e1, Event e2)
                        {
                            Type t1 = e1.GetType();
                            Type t2 = e2.GetType();
                            PropertyInfo pro1 = t1.GetProperty(field);
                            PropertyInfo pro2 = t2.GetProperty(field);
                            return rule.ToLower().Equals("asc") ?
                                pro1.GetValue(e1, null).ToString().CompareTo(pro2.GetValue(e2, null).ToString()) :
                                pro2.GetValue(e2, null).ToString().CompareTo(pro1.GetValue(e1, null).ToString());
                        });
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        /// <summary>
        /// 分组
        /// </summary>
        private static void ListGroup(List<Event> eventList, string field)
        {
            
            /*
            IEnumerable<IGrouping<string, Event>> query = eventList.GroupBy(x => x.Priority);
            foreach (IGrouping<string, Event> e in query)
            {
                //分组后的集合
                List<Event> sl = e.ToList<Event>();
                foreach (Event item in sl)
                {

                }
            }
             * */
        }


    }
}
