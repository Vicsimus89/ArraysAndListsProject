using System;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evens = new List<int>();

            var odds = new List<int>();

            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    evens.Add(num);
                }
                else
                {
                    odds.Add(num);
                }
            }

            foreach (var evenNumber in evens) 
            {
                Console.WriteLine($"{evenNumber} is truly an even number.");
            }

            foreach(var oddNumber in odds)
            {
                Console.WriteLine($"This {oddNumber} is an odd number for sure.");
            }
        }
    }
}
