using System.Text.RegularExpressions;

namespace ExtensionMethods
{
    static class StringExtensions
    {
        public static bool ContainsDigit(this string s)
        {
            foreach (var c in s)
            {
                if (char.IsDigit(c))
                    return true;
            }

            return false;
        }

        public static int IndexOfExp(this string s, string expression)
        {
            Regex regex = new Regex(expression);
            var match = regex.Match(s);
            if (!match.Success)
                return -1;

            return match.Index;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "jjjjjjjjjjj";
            Console.WriteLine(s.ContainsDigit());
            Console.WriteLine(s.IndexOfExp(@"\d"));
        }
    }
}
