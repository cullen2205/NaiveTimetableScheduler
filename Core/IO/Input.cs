using Core.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.IO
{
    public static class Input
    {
        public static List<Subject> GetSubjectsFromFile(string path)
        {
            List<Subject> subjects = new List<Subject>();
            string[] subjectTexts;

            try
            {
                subjectTexts = File.ReadAllLines(path);
            }
            catch
            {
                throw new Exception("MSG_007_INPUT_ERROR");
            }

            foreach (string subjectText in subjectTexts)
            {
                subjects.Add(new Subject(subjectText));
            }
            return subjects;
        }
    }
}
