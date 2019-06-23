using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Core.Processing
{
    public static class Misc
    {
        public static bool NumberBetweenRange(int x, int begin, int end)
        {
            return begin <= x && x <= end;
        }

        public static string ToAbbreviation(string text)
        {
            return new string
            (
                text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(s => s[0]).ToArray()
            );
        }

        public static string ReplaceSpaces(string text, string replaceWith)
        {
            return Regex.Replace(text.Trim(), @"\s+", replaceWith);
        }

        public static string Prettify(string text)
        {
            return ReplaceSpaces(text, " ");
            //a    Pretty  string => a Pretty string
        }

        public static string RemoveAllWhiteSpace(string text)
        {
            //return new string(text.Where(c => !char.IsWhiteSpace(c)).ToArray());
            return ReplaceSpaces(text, "");
        }
    }
}
