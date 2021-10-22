using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace LinqDemo
{
    class LinqUsingMethodSyntax
    {
        static void Main()
        {
            int[] num = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var data = num.Select(x => x);
            Console.WriteLine("Elements are ");
            foreach(int x in data)
            Console.WriteLine(x);
            var evenList = num.Where(x => x % 2 == 0);
            Console.WriteLine("Even Numbers are ");
            foreach (int x in evenList)
                Console.WriteLine(x);

            var oddList = num.Where(x => x % 2 != 0);
            Console.WriteLine("Odd Numbers are ");
            foreach (int x in oddList)
                Console.WriteLine(x);
            List<string> list = new List<string>()
            {  "Ajay" , "Deepak","Sagar", "Mandeep Singh"};

            var namesContainse = list.Where(x => x.Contains("e"));
        }
    }
}
