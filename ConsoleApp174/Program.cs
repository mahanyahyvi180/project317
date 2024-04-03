using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp174
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex expression = new Regex(@"J.*\d[\d-[4]]-\d\d-\d\d");

            string testString = "Jane's Birthday is 05-12-75\n" + "Dave's Birthday is 11-04-68\n" + "John's Birthday is 04-28-73\n" + "Joe's Birthday is 12-17-77";

            foreach (var regexMatch in expression.Matches(testString))
                Console.WriteLine(regexMatch);
            Console.ReadLine();
        }
    }
}
