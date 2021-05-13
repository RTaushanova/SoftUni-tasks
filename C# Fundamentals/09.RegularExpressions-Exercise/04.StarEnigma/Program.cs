using System;
using System.Text.RegularExpressions;

namespace _04.StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string newPassword = "";
                string input = Console.ReadLine();
                int key = 0;
                Regex star = new Regex(@"[s,t,a,r,S,T,A,R]");
                MatchCollection matchStar = star.Matches(input);
                for (int a = 0; a < matchStar.Count; a++)
                {
                    key += a;
                }

                for (int j = 0; j < input.Length; j++)
                {
                    int currentSymbol = input[j];
                    currentSymbol -= key;
                    newPassword += (char)currentSymbol;
                }

                Regex planetRegex = new Regex(@"@[A-Za-z]+");
                Regex populationRegex = new Regex(@":\d+");
                Regex typeRegex = new Regex(@":\d+");
            }
        }
    }
}
