using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppFunctions
{
    class Program
    {

        static int intCnt = 0;

        delegate double ProcessDegeGate(double param1, double param2);

        static double Multiply(double param1, double param2)
        {

            return (param1 * param2);

        }

        static double Divide(double param1, double param2)
        {

            return (param1 / param2);


        }


        static void Counter()
        {
            intCnt++;


          
        }


        static void Write()
        {

            Console.WriteLine("THis is the sub function ");

        }

        static void PopList(params String[] strTestArray)
        {




        }


        struct BOOK
        {
           public  string strAuthorFName;
           public  string strAuthorLName;

            public string FullName()
            {
                return (strAuthorFName + " " + strAuthorLName);


            }



        }

        public  static void NumAdd(int intA, int intB)
        {

            int intC = intA + intB;


        }
        
        static void Swap (ref int intC, ref int intD)
        {


           int  intTemp = intC;
            intC = intD;
            intD = intTemp;

        
        }


        static void Main(string[] args)
        {


          //  Write();

           // Console.ReadKey ();


            int intA = 30;
            int intB = 40;


            Console.WriteLine("The Value Before Swapping A = {0} and B = {1} ", intA, intB);


            Swap(ref intA, ref intB);

            
            Console.WriteLine("The Value After Swapping A = {0} and B = {1} ", intA, intB);



            BOOK bk1, bk2;

            bk1.strAuthorFName = "Hamid";
            bk1.strAuthorLName = "Ali";

            NumAdd (intB:30,intA:40);


            
            Console.WriteLine ( bk1.FullName());

            // Working with Delegates.. 


            ProcessDegeGate procMain;

            
           


            double param1 = 20;

            double param2 = 30;


            Console.WriteLine("Enter M for Multiply and D for Divide");
            string input = Console.ReadLine();

            if (input == "M")
            {

                procMain = new ProcessDegeGate(Multiply);

            }
            else
            {
                procMain = new ProcessDegeGate(Divide);

            }

            Console.WriteLine("Result : {0} ", procMain(param1, param2));


         //   List<String> myList = new List[String];
         //   myList.Add("Test");






            Console.ReadKey();

           

        }
    }
}
