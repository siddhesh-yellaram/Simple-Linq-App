using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLinqApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Display Names in given order
            var names = args;
           
            Console.Write("Names in args are: ");
            foreach(string n in names)
            {
                Console.Write(n+" ");
            }
            Console.WriteLine();

            //Display Names in ascending order
            var namesAscen = from n in names
                             orderby n
                             select n;

            Console.Write("Names in ascending order are: ");
            foreach (string n in namesAscen)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();

            //Display Names in descending order
            var namesDescen = from n in names
                             orderby n descending
                             select n;

            Console.Write("Names in descending order are: ");
            foreach (string n in namesDescen)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();

            //Display names with vowels in it.
            string[] vowels = { "a", "e", "i", "o", "u" };
            var namesWithVowels = from n in names
                                  from v in vowels
                                  where n.Contains(v)
                                  select n;
            Console.Write("Names with vowels in it are: ");
            foreach (string n in namesWithVowels)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();

            //Display names with first four characters.
            List<string> subNames = new List<string>();
            foreach(string n in names)
            {
                if(n.Length > 4)
                {
                    subNames.Add(n.Substring(0, 4));
                }
            }
            Console.Write("Names with first four characters are: ");
            foreach (string n in subNames)
            {
                Console.Write(n+" ");
            }

             Console.ReadLine();
        }
    }
}
