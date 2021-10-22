using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace LinqDemo
{
    class LinqDemo2
    {
        static void Main()
        {
            List<string> list = new List<string>()
            {  "Ajay" , "Deepak","Sagar", "Mandeep Singh"};

            var names = (from x in list
                         select x);


            var namesContainse = (from x in list
                                 where x.Contains("e")
                                 select x);

            Console.WriteLine("Names which contains e");
            foreach(string x in namesContainse)
                Console.WriteLine(x);

            var namesStartsA = (from x in list
                                  where x.StartsWith("A")
                                  select x);

            Console.WriteLine("Names which Starts with A");
            foreach (string x in namesStartsA)
                Console.WriteLine(x);


            var charactersMoreThan10 = (from x in list
                                where x.Length>10
                                select x);

            Console.WriteLine("Names with charcaters more than 10");
            foreach (string x in charactersMoreThan10)
                Console.WriteLine(x);





        }
    }
}
