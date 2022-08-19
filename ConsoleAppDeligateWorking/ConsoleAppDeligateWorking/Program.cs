using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppDeligateWorking
{
    class Program
    {

       delegate int DelSelOperation (int Param1, int param2);

        static  int  Addition(int intA, int intB)
        {

            return (intA + intB);
                
        }

        static int Multiplulation(int intA, int intB)
        {

            return (intA * intB);


        }

        static void Main(string[] args)
        {


            DelSelOperation procDeligate = null;

            int intValA = 20;
            int intValB = 30;


            Console.WriteLine("Enter 1 for Multiply and 2 for Addition");

            int intChoice = Convert.ToInt16(Console.ReadLine());



            if (intChoice == 1)
            {

                procDeligate = new DelSelOperation(Multiplulation);
                
            }
            else if (intChoice == 2)
            {

                procDeligate = new DelSelOperation(Addition);
            }

            Console.WriteLine("The Result is {0} ", procDeligate(intValA , intValB ));

            Console.ReadKey();



        }
    }
}
