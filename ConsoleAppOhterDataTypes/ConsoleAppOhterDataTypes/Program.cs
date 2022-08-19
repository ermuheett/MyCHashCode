using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppOhterDataTypes
{
    class Program
    {

        struct BOOK
        {
            public string strAuthor;
            public string strPub;
            public string strAccNo;
        }





        enum ROMAN : byte
        {


            I = 1,
            II = 2,
            III = 3,
            IV = 4,
            V = 5,
            VI = 6,
            VII = 7,
            VIII = 8,
            IX = 9,
            X = 10

        }


        static void Main(string[] args)
        {
            // Structures
            BOOK bk1, bk2, bk3;


            bk1.strAccNo = "1001002";
            bk1.strAuthor = "Hensy Perterson";
            bk1.strPub = "Wiley Publications";



            // Enumerations
            ROMAN rmnA, rmnB, rmnC;

            int intC;

            rmnA = ROMAN.III;
            rmnB = ROMAN.IV;



            intC = (byte) rmnA + (byte) rmnB;
                
            rmnC = (ROMAN) intC ;

            Console.WriteLine("The sum is {0}",rmnC );


            // Arrays

            int[] intArray = {1, 2, 3, 4, 5};


            int[] intMyArray = new int[10];

            int[] intNewArray = new int[5] { 3, 4, 5, 6, 7 };

            int intArrSize = 5;

            int[] intConsArray = new int[intArrSize];

            int[] intLastArray;

            intLastArray = new int[5];


            string[] strTestArray = { "Sunday", "Monday", "Tuesday" };


            // Array of Arrays

            int [] [] intJaggedArray = new int [3][];

            intJaggedArray[0] = new int[3];
            intJaggedArray[1] = new int[10];


            Console.WriteLine("Enter your string ");
            String strTest = Console.ReadLine();

            foreach (char chrVal in strTest)
            {

                Console.WriteLine(chrVal);


            }



            Console.WriteLine(strTest);











            

            Console.ReadKey();




        }
    }
}
