using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppOopsOptr
{
    class Program
    {

        class Rectangle
        {

            internal double dblLen;
            internal double dblwith;

            double GetArea()
            {

                return (dblLen * dblwith);

            }


            public void display()
            {

                Console.WriteLine("Length = {0} ", dblLen);
                Console.WriteLine("Width  = {0}", dblwith);
                Console.WriteLine("Area = {0} ", GetArea());


            }

        }


        static void Main(string[] args)
        {


            Rectangle rectR = new Rectangle();
            rectR.dblLen = 12;
            rectR.dblwith = 12;

            rectR.display();

            Console.ReadKey();




        }
    }
}
