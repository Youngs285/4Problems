using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckZips
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Scores = {100, 1000, 250, 20, 56};

            for (int i = 0; i < Scores.Length; i++)
            {
                Array.Sort(Scores);
                Array.Reverse(Scores);
                Console.WriteLine("{0}", Scores[i]);
            }
        }
    }
}
