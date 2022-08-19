using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NameTestA;
using NameTestB;



namespace NameTestA
{
    class NameSpaceClassTestA
    {


        public void TestFunc()
        {

            Console.Write("I am in Name Space a");

        }

    }

   }

namespace NameTestB
{
    class NameSpaceClassTestA
    {

         
        public void TestFunc()
        {

            Console.Write("I am in Name Space a");

        }

    }

    namespace NameTestBNested
    {

        class NSNested
        {

            public void TEstFunc()
            {

                Console.WriteLine("THis is the Test FUnction ");


            }

        }
    }

}



namespace ConsoleAppNameSpaces
{
    class Program
    {
        static void Main(string[] args)
        {

            


        }
    }
}


