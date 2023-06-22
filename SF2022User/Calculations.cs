using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF2022User
{
    public class Calculations
    {
        public static string[] AvailablePeriods(TimeSpan[] startTimes, int[] durations , TimeSpan beginWorkingTime, TimeSpan endWorkingTime, int consultationTime)
        {
            List<string> result = new List<string>();
            int numberOfIntervals = startTimes.Length;
            DateTime currentStart = DateTime.Today.Add(beginWorkingTime);
            DateTime currentEnd = currentStart.AddMinutes(consultationTime);

            for (int i = 0; i < numberOfIntervals; i++)
            {
                DateTime busyStart = DateTime.Today.Add(startTimes[1]);
                DateTime busyEnd = currentStart.AddMinutes(durations[1]);

                while (currentEnd <= busyStart)
                {
                    result.Add($"{currentStart: HH:mm}-{currentEnd:HH:mm}");
                    currentStart = currentStart.AddMinutes(consultationTime);
                    currentEnd = currentStart.AddMinutes(consultationTime);
                }
                if (currentStart < busyEnd)
                {
                    currentStart = busyEnd;
                    currentEnd = currentEnd.AddMinutes(consultationTime);
                }
            }
            while (currentEnd <= DateTime.Today.Add(endWorkingTime))
            {
                result.Add($"{currentStart: HH:mm}-{currentEnd:HH:mm}");
                currentStart = currentStart.AddMinutes(consultationTime);
                currentEnd = currentStart.AddMinutes(consultationTime);
            }
            return result.ToArray();
        }
    }
}
