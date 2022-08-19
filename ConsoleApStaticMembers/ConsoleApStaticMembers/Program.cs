using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApStaticMembers
{
    class Program
    {

        class StaticVar
        {


            public static int intCnt;

            public void GetCount()
            {

                intCnt++;

            }


            public static int getNum()
            {
                return intCnt;


            }

        }



        static void Main(string[] args)
        {

            StaticVar objA = new StaticVar();

            StaticVar objB = new StaticVar();


            objA.GetCount ();
            objA.GetCount();
            objA.GetCount();

            objB.GetCount();
            objB.GetCount();

            Console.WriteLine("Count Value for OBJA is " + StaticVar.getNum());
            Console.WriteLine("Count Value for OBJB is " + StaticVar.getNum());

            Console.ReadKey();




        }
    }
}
