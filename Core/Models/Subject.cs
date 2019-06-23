using Core.Processing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Subject
    {
        static string pattern = @"(.+);(.+)";

        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public List<TimePeriod> Periods { get; set; }

        public Subject()
        {
            Periods = new List<TimePeriod>();
        }

        public Subject(string text) : this()
        {
            Match match = Regex.Match(text, pattern);
            if (match.Success)
            {
                Name = Misc.Prettify(match.Groups[1].Value);
                Abbreviation = Misc.ToAbbreviation(Name).ToUpper();

                string[] periodsText = Misc
                    .RemoveAllWhiteSpace(match.Groups[2].Value)
                    .Split(new char[] { ',' }, 
                        StringSplitOptions.RemoveEmptyEntries);

                foreach (string periodText in periodsText)
                {
                    Periods.Add(new TimePeriod(periodText));
                }
            }
            else
                throw new Exception("MSG_006_WRONG_FORMAT");

        }

        public static bool Intersect(Subject subject1, Subject subject2)
        {
            foreach (TimePeriod period1 in subject1.Periods)
                foreach (TimePeriod period2 in subject2.Periods)
                    if (TimePeriod.Intersect(period1, period2))
                        return true;

            return false;
        }

        public static bool Intersect(Subject subject, List<Subject> subjects)
        {
            foreach(Subject subject_ in subjects)
            {
                if (Intersect(subject, subject_))
                    return true;
            }

            return false;
        }

        public override string ToString()
        {
            return string.Format("{0}; {1}", Name, TimePeriod.PeriodsListToString(Periods));
        }
    }
}
