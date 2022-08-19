using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppPolyMor
{

    abstract class Shape
    {

        public abstract int GetArea();


    }

    class Rectangle: Shape
    {




        private int intLen;
        private int intWid;

     


        public Rectangle(int a = 0, int b = 0)
        {

            intLen = a;
            intWid = b;




        }

        public override int GetArea()
        {

            Console.Write("Rectangale Class area:");

            return (intLen * intWid);


        }
        

    }

    class Program
    {
        static void Main(string[] args)
        {

            
            Rectangle recTest = new Rectangle(10, 10);
            
            double dblArea = recTest.GetArea();


            Console.WriteLine("Area is " + dblArea);


            Console.ReadKey();


        }
    }
}
