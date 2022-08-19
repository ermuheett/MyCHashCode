using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppUserDefinedExcep
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckAge objA = new CheckAge(23);
            CheckAge objB = new CheckAge(12);
            CheckAge objC = new CheckAge(21);
            CheckAge objD = new CheckAge(45);
            CheckAge objE = new CheckAge(16);


            try
            {
                objB.EvalAge();



            }
            catch (TestInvalidAgeException e)
            {
                Console.WriteLine("Invalid Age Exception {0} ", e.Message);

            }

            finally
            {
                Console.WriteLine("THe Code successfully Executed....");

            }

            Console.ReadKey();

        }
    }


    public class TestInvalidAgeException : ApplicationException
    {

        public TestInvalidAgeException(string strMessage)
            : base(strMessage)
        {



        }

    }

    public class CheckAge
    {


        int intAge = 0;

        public CheckAge(int intA)
        {
            intAge = intA;
        }
        

        public void EvalAge()
        {

            if (!(intAge >= 18 && intAge <= 37))
                throw new TestInvalidAgeException("Invalid Age of the Canidate");
            else
                Console.WriteLine("The Age is Evaulated and found correct...");

        }
    }

     
}
  

