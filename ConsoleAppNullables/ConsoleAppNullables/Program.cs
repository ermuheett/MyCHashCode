using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppNullables
{
    class Program
    {





        static void Main(string[] args)
        {


            int? intA = null;

            int? intB = 30;

            double dblA = new double();
            double? dblB = 3.4567;

            bool? blnNull = new bool?();

            Console.WriteLine("Nullables to show  {0},  {1}, {2}, {3}", intA, intB, dblA, dblB, blnNull);

            // Null Concelaing Operator 

            double? dblC = null;
            double? dblD = 3.123455;

            double dblE;

            dblE = dblC ?? 5.34;

            Console.WriteLine("The value of E is {0} ", dblE);

            dblE = dblD ?? 5.34;


            Console.WriteLine("The value of E is {0} ", dblE);


            Console.ReadKey();


        }
    }
}
