﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] zip = new int[10];

            Console.WriteLine("Enter 10 zip codes between 1-1000");

            for (int i = 0; i < 10; i++)
            {
                zip[i] = Convert.ToInt32(Console.ReadLine());

                if (zip[i] > 500)
                {
                    Console.WriteLine("We deliver there!");
                }
                else
                {
                    Console.WriteLine("Your Location is too far for us to deliver");
                }
            }
        }
    }
}
