using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace LINQ_Queries
{
    class Answer
    {
        internal void Quiz01(int[] intArray)
        {
            Console.WriteLine("");
            foreach(var item in intArray)
            {
                Console.Write($" {item} ");
            }
            Console.WriteLine("");
            Console.WriteLine("\tEven numbers only:");
            var evenNum = intArray.Where(i => i % 2 == 0).Select(i => i);
            foreach (var item in evenNum)
            {
                Console.Write($" {item} ");
            }
        }
        internal void Quiz02(int[] intArray)
        {
            Console.WriteLine("");
            foreach (var item in intArray)
            {
                Console.Write($" {item} ");
            }
            Console.WriteLine("");
            Console.WriteLine("\tPositive numbers only");

            var posNum = from i in intArray where i > 0 select i;
            foreach (var item in posNum)
            {
                Console.Write($" {item} ");
            }
        }
        internal void Quiz03(int[] intArray)
        {
            Console.WriteLine("");
            foreach (var item in intArray)
            {
                Console.Write($" {item} ");
            }
            Console.WriteLine("");

            var sqNum = from i in intArray select (i * i);

            Console.WriteLine("Squared numbers:");
            foreach (var item in sqNum)
            {
                Console.Write($" {item} ");
            }
            Console.WriteLine("");
        }
        internal void Quiz04(int[] intArray)
        {
            Console.WriteLine("");
            foreach (var item in intArray)
            {
                Console.Write($" {item} ");
            }
            Console.WriteLine("");

            var freqNum = intArray.GroupBy(i => i);

            Console.WriteLine("frequency of each number:");
            foreach (var item in freqNum)
            {
                Console.WriteLine($" {item.Key}: {item.Count()} ");
            }
            Console.WriteLine("");
        }
    }
}
