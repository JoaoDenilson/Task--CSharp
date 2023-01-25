using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Reflection
{
    public class Log
    {
        public static List<Object> Loggers = new List<Object>();

        public static void RegisterLog(object obj)
        {
            Loggers.Add(obj);
        }

        public static void ShowLog()
        {
            foreach (object log in Loggers)
            {
                Console.WriteLine("----- Nome da classe: {0} -----", log.GetType().Name);
                foreach (var prop in log.GetType().GetProperties())
                {
                    Console.WriteLine(prop.Name + ":" + prop.GetValue(log));
                }
            }
        }
    }
}
