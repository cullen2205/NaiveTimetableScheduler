using Core.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.IO
{
    public static class Output
    {
        public static void SubjectsToFile(List<Subject> subjects, string path)
        {
            File.WriteAllText(path, subjects.ToString());
        }
    }
}
