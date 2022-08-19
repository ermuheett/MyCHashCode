using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppMultipleInherit
{

    class Shape 
    {

        protected double dblWidth;
        protected double dblHeight;


        public void SetWidth(double dblW)
        {

            dblWidth = dblW;

        }

        public void SetHeight(double dblH)
        {
           dblHeight = dblH;

        }

     }


     public interface MatCost
     {

      double GetCost(double dblArea);

     }

    class Rectangle : Shape, MatCost 
    {

        public double GetArea()
        {

            return (dblHeight * dblWidth );

        }
        
        public double GetCost( double dblArea)
        {
            return (20.5 * GetArea ());
            
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            Rectangle rctTest = new Rectangle();

            rctTest.SetHeight(2);
            rctTest.SetWidth(3);

            double dblAr = rctTest.GetArea();

            Console.Write("The Cost of coloring is " + rctTest.GetCost(dblAr));

            Console.ReadKey();




        }
    }
}
