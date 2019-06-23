using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Processing
{
    public class BlackBox
    {
        public static List<Subject> SubjectsNotIntersectConditions(List<Subject> subjects, List<TimePeriod> conditionPeriods)
        {
            return subjects.Where(s => !TimePeriod.Intersect(s.Periods, conditionPeriods)).ToList();
        }

        public static List<Tuple<Subject, Subject>> IntersectPairs(List<Subject> subjects)
        {
            List<Tuple<Subject, Subject>> pairs = new List<Tuple<Subject, Subject>>();

            for(int i = 0; i < subjects.Count - 1; ++i)
                for(int j = i + 1; j < subjects.Count; ++j)
                {
                    if (Subject.Intersect(subjects[i], subjects[j]))
                        pairs.Add(Tuple.Create(subjects[i], subjects[j]));
                }

            return pairs;
        }

        public static bool HasDifferentSubjectNames(List<Subject> subjects)
        {
            return subjects.Select(s => s.Name).Distinct().Count() == subjects.Count;
        }

        public static List<Subject> GetSubjectsByNames(List<Subject> subjects, 
            params string[] names)
        {
            return subjects
                .Where(s => names.Contains(s.Name))
                .ToList();
        }

        public static List<List<Subject>> GroupSubjectsByName(List<Subject> subjects)
        {
            return subjects
                .GroupBy(s => s.Name)
                .Select(g => g.ToList())
                .ToList();
        }

        public List<List<Subject>> ValidChoices { get; set; }

        public BlackBox()
        {
            ValidChoices = new List<List<Subject>>();
        }
        
        public void Attempt(List<Subject> selectedSubjects,
            List<List<Subject>> groupedSubjects, int index = 0)
        {
            if(index == groupedSubjects.Count)
            {
                ValidChoices.Add(selectedSubjects.ToList());
                return;
            }

            foreach(Subject subject in groupedSubjects[index])
                //if there is no selected subject, select the first group, et cetera
            {
                if (!Subject.Intersect(subject, selectedSubjects))
                {
                    selectedSubjects.Add(subject);
                    Attempt(selectedSubjects, groupedSubjects, index + 1);
                    selectedSubjects.Remove(subject);
                }
            }
        }
    }
}
