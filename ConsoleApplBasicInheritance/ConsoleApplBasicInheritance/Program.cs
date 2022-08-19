using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplBasicInheritance
{

    class Shape
    {

        protected  double dblWidth;
        protected  double dblHeight;



        public void SetWidth(double dblW)
        {

            dblWidth = dblW;

        }

        public void SetHeight(double dblH)
        {

            dblHeight = dblH;
        }

       

    }


    class Rectangle : Shape
    {
        public double  GetArea()
        {

            return (dblHeight * dblWidth);

        }

    }

    class Program
    {



        static void Main(string[] args)
        {


            Rectangle rectTest = new Rectangle();

            rectTest.SetHeight(10);
            rectTest.SetWidth(5);

            Console.WriteLine("The area is " + rectTest.GetArea());

            Console.ReadKey();

        }
    }
}
