using System;
using System.Text.RegularExpressions;

namespace hrSplit_Number
{
    class Program
    {
        static void Main()
        {
            var numCases = Int32.Parse(Console.ReadLine());
            var regex = new Regex(@"(\d{1,3})[- ](\d{1,3})[- ](\d{4,10})", RegexOptions.Compiled);
            while (numCases-- > 0)
            {
                var str = Console.ReadLine();
                var matches = regex.Match(str).Groups;
                var answer = String.Format("CountryCode{0},LocalAreaCode={1},Number={2}",
                    matches[0], matches[1], matches[2]);
                Console.WriteLine(answer);
            }
        }
    }
}
