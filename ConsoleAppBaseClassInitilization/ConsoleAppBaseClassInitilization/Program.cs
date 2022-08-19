using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppBaseClassInitilization
{

    class Rectangle
    {

        protected double dblLen;
        protected double dblWid;

        public Rectangle(double dblLh, double dblWh)
        {

            dblLen = dblLh;
            dblWid = dblWh;


        }

        public double  getArea()
        {
            return (dblWid * dblLen);


        }

        public void Display()
        {

            Console.WriteLine("Length is {0} ", dblLen);
            Console.WriteLine("Width is {0} ", dblWid);
            Console.WriteLine("Area is {0} ", getArea());

        }

    }


    class MatFloor : Rectangle 
    {

        public double dblCost;

        public MatFloor(double dblL, double dblW)
            : base(dblL, dblW)
        {
        }

        public double GetPrice()
        {

            return (getArea() * 3.4);

        }



    }


    class Program
    {
        static void Main(string[] args)
        {


            Rectangle rctTest = new Rectangle(2, 3);

            rctTest.Display();

            MatFloor mFLoor = new MatFloor(4, 5);

           Console.Write ("The Price is " +  mFLoor.GetPrice());

        

            Console.ReadKey();


        }
    }
}
