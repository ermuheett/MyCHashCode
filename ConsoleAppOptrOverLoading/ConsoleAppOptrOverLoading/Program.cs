using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppOptrOverLoading
{

    class Box
    {

        private double dblLen;
        private double dblWid;
        private double dblHit;

      

        public void SetLength(double dblL)
        {
            dblLen = dblL;

        }

        public void SetBreadth(double dblB)
        {

            dblWid = dblB;
        }

        public void SetHeight(double dblH)
        {
            dblHit = dblH;

        }


        public double GetVolume()
        {

            return (dblHit * dblLen * dblWid);

        }



        public static Box operator+(Box bxA, Box bxB)
        {

            Box bxC = new Box();

            bxC.dblLen = bxA.dblLen + bxB.dblLen;
            bxC.dblWid  = bxA.dblWid + bxB.dblWid;
            bxC.dblHit = bxA.dblHit + bxB.dblHit;

            return bxC;
            


        }

    }



    class Program
    {
        static void Main(string[] args)
        {


            Box boxA = new Box();
            Box boxB = new Box();
            Box boxC = new Box();


            
            boxA.SetLength(3);
            boxA.SetBreadth(3);
            boxA.SetHeight(3);

            boxB.SetLength(3);
            boxB.SetBreadth(3);
            boxB.SetHeight(3);

            Console.WriteLine("Volument of Box A is " + boxA.GetVolume());
            Console.WriteLine("Volument of Box B is " + boxB.GetVolume());
            

            boxC = boxA + boxB;

            Console.WriteLine("Volument of Box C is " + boxC.GetVolume());



            Console.ReadKey();



        }
    }
}
