using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppDynamicPolyMorphism
{
    abstract class Shape
    {

        public abstract  int GetArea();

    }

    class Rectangle : Shape
    {
        public int intLen;
        public int intWid;


        public Rectangle(int intL = 0, int intW = 0)
        {

            intLen = intL;
            intWid = intW;

        }


        public override int GetArea()
        {

            return (intLen * intWid);
        }


    }


    class Program
    {
        static void Main(string[] args)
        {


            Rectangle rctTest = new Rectangle(2,3);

            Console.WriteLine("The Area is " + rctTest.GetArea());


            Console.ReadKey();

        }
    }
}
