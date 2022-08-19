using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppVirtualFunc
{

    class Shape
    {

        protected int intLen, intWid;

        public Shape(int intL = 0, int intW = 0)
        {

            intLen = intL;
            intWid = intW;


        }

        public virtual int GetArea()
        {
            Console.WriteLine("Parent Class");

            return 0;


        }
        
    }

    class Rectangle : Shape
    {
        public Rectangle ( int intL = 0, int intW = 0) 
            : base(intL, intW)
        {



        }

        public override int GetArea()
        {
            return (intWid * intLen);

        }

    }

    class Traingle : Shape
    {

        public Traingle(int intL, int intW)
            : base(intL, intW)
        {



        }


        public override int GetArea()
        {
            return (intWid * intLen / 2);

        }

    }


    class Caller
    {


        public void CallArea(Shape sh)
        {

            int intArea;
            intArea = sh.GetArea();

            Console.WriteLine("Area is " + intArea);


        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            Caller c = new Caller();

            Rectangle r = new Rectangle(3,3);

            Traingle t = new Traingle(4,4);

            c.CallArea(r);
            c.CallArea(t);

            Console.ReadKey();




        }
    }
}
