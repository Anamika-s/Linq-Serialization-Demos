using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LinqDemo
{
    class LinqDemo
    {
        static void Main()
        {
            int[] num = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // Select * from emp
            // LINQ Query > Query Syntax
            // Lazy Loading 
            var data = from x in num
            select x;
            foreach(int x in data)
                Console.WriteLine(x);
            // Early Loading
            int sum = (from x in data
                       select x).Sum();
            Console.WriteLine("Sum is " + sum);

            double avg = (from x in data
                         select x).Average();
            Console.WriteLine("Average is " + avg);

            var evenList = (from x in num
                            where x % 2 == 0
                            select x);

            Console.WriteLine("Even Numbers are " );
            foreach(int x in evenList)
                Console.WriteLine(x);

            var oddList = (from x in num
                            where x % 2 != 0
                            select x);

            Console.WriteLine("Odd Numbers are ");
            foreach (int x in oddList)
                Console.WriteLine(x);

            // Early Loading
            var data1 = (from x in num
                       select x).ToList();
            foreach (int x in data1)
                Console.WriteLine(x);
        }
    }
}
