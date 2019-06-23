using Core.Processing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Core.Models
{
    public class TimePeriod
    {
        static string pattern = @"(\d):(\d+)-(\d+)";
        //2:3-4

        public int Begin { get; set; }
        public int End { get; set; }
        public int DayInWeek { get; set; }

        public TimePeriod()
        {

        }

        public TimePeriod(string text)
        {
            Match match = Regex.Match(text, pattern);
            if(match.Success)
            { //2:3-4
                DayInWeek = int.Parse(match.Groups[1].Value); //2
                Begin = int.Parse(match.Groups[2].Value); //3
                End = int.Parse(match.Groups[3].Value); //4
            }

            if (!match.Success || !ValidTimePeriod())
                throw new Exception("MSG_006_WRONG_FORMAT");
        }

        private bool ValidTimePeriod()
        {
            return Misc.NumberBetweenRange(DayInWeek, 2, 8)
                && Misc.NumberBetweenRange(Begin, 1, 16)
                && Misc.NumberBetweenRange(End, 1, 16)
                && Begin <= End;
        }

        public static bool Intersect(TimePeriod period1, TimePeriod period2)
        {
            return period1.DayInWeek == period2.DayInWeek &&
                (Misc.NumberBetweenRange(period1.Begin, period2.Begin, period2.End)
                || Misc.NumberBetweenRange(period1.End, period2.Begin, period2.End));
        }

        public static bool Intersect(List<TimePeriod> periods1, List<TimePeriod> periods2)
        {
            foreach(TimePeriod period1 in periods1)
                foreach(TimePeriod period2 in periods2)
                    if (Intersect(period1, period2))
                        return true;

            return false;
        }

        public override string ToString()
        {
            return string.Format("{0}: {1} - {2}", DayInWeek, Begin, End);
        }

        public static string PeriodsListToString(List<TimePeriod> periods)
        {
            string result = "";
            foreach(TimePeriod period in periods)
            {
                result += period.ToString() + ", ";
            }

            return result.Length > 2 
                ? result.Remove(result.Length - 2) 
                : "";
        }
    }
}
