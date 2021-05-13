using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> participants = Console.ReadLine().Split(", ").ToList();
            string input = Console.ReadLine();
            Dictionary<string, int> dict = new Dictionary<string, int>();

            while (input != "end of race")
            {

                Regex regexRacer = new Regex(@"[A-Za-z]+");
                Regex regexDistance = new Regex(@"\d");
                MatchCollection matchesRacer = regexRacer.Matches(input);
                MatchCollection matchesDistance = regexDistance.Matches(input);

                string name = "";

                foreach (Match letter in matchesRacer)
                {
                    name += letter.Value;
                }
                int distance = 0;
                foreach (Match digit in matchesDistance)
                {
                    distance += int.Parse(digit.Value);
                }

             

                if (participants.Contains(name))
                {
                    
                        if (!dict.ContainsKey(name))
                        {
                            dict[name] = distance;
                        }

                        else
                        {
                            dict[name] += distance;
                        }
                    

                }


                input = Console.ReadLine();
            }
            dict = dict.OrderByDescending(x => x.Value).Take(3).ToDictionary(x => x.Key, y => y.Value);

            for (int i = 0; i < dict.Count; i++)
            {
                string word = "";
                if (i == 0)
                {
                    word = "st";
                }
                else if (i == 1)
                {
                    word = "nd";
                }
                else if (i == 2)
                {
                    word = "rd";
                }

                Console.WriteLine($"{i+1}{word} place: {dict.ElementAt(i).Key}");
            }
        }
    }
}
