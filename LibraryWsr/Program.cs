using SF2022User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWsr
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan[] startTimes = { };
            int[] durations = { };
            TimeSpan beginWorkingTime = new TimeSpan(8, 0, 0);
            TimeSpan endWorkingTime = new TimeSpan(18, 0, 0);
            int consultationTime = 30;

            string[] availablePeriods = Calculations.AvailablePeriods(startTimes, durations, beginWorkingTime, endWorkingTime, consultationTime);

            foreach (var item in availablePeriods)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
