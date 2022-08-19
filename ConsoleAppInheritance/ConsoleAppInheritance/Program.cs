using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppInheritance
{


    
    class Shape
    {
        protected int intWid;
        protected int intHeight;


        public void SetWidth(int intW)
        {

            intWid = intW;


        }

        public void SetHeight(int intH)
        {


            intHeight  = intH;

        }


    }


    class RectAngle : Shape
    {


        public int GetArea()
        {

            return (intWid * intHeight);


        }

    }


    class Program
    {


        static void Main(string[] args)
        {

            RectAngle rctTest = new RectAngle();

            rctTest.SetWidth(5);
            rctTest.SetHeight(5);

            Console.WriteLine("Total Area : {0} ", rctTest.GetArea());

            Console.ReadKey();


        }
    }
}
