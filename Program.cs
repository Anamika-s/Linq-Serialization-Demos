using System;

namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach(int x in num)
            {
                Console.WriteLine(x);
            }
            int sum = 0;
            foreach (int x in num)
            {
                sum += x;
               }
            Console.WriteLine(sum);
            float avg = (float)sum / 10;

            foreach (int x in num)
            {
                if(x%2==0)
                    Console.WriteLine(x);
               
            }


        }
    }
}
