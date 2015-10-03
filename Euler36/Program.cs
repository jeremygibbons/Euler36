using System;
using System.Linq;

namespace Euler36
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            foreach(int n in Enumerable.Range(1, 1000000))
            {
                string bin = Convert.ToString(n, 2);
                string dec = n.ToString();
                if(bin == Reverse(bin) && dec == Reverse(dec))
                {
                    Console.WriteLine(n + " " + Convert.ToString(n, 2));
                    sum += n;
                }
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
