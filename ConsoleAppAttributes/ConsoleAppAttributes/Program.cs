using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppAttributes
{

    


    class Program
    {
        [Obsolete("Dont use this method use new method insttead", true)]
        

        static void OldMethod()
        {

            Console.WriteLine("It is the old method");


        }

     
        static void NewMethod()
        {

            Console.WriteLine("This is hte New Method");

        }

     
        [program ("Some into")]


        static void Main(string[] args)
        {

            // Attribute Usuage
            // Predefined
            // Obselete

            OldMethod();


            Console.ReadKey();

           





        }
    }
}
