using Core.IO;
using Core.Models;
using Core.Processing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    class Program
    {
        static void Main(string[] args)
        {
            TimePeriod p1 = new TimePeriod()
            {
                DayInWeek = 2,
                Begin = 1,
                End = 6
            }, p2 = new TimePeriod()
            {
                DayInWeek = 2,
                Begin = 6,
                End = 9
            };

            Console.WriteLine(TimePeriod.Intersect(p1, p2));

            Console.ReadKey();
        }
    }
}
