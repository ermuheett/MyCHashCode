using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplTestC
{
    class Program
    {
        static void Main(string[] args)
        {
            int i =7, c;


            c = (++i) / (i++);


            Console.WriteLine(c);

            Console.ReadKey();

        }
    }
}
