using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppVarDataType
{
    class Program
    {
        static void Main(string[] args)
        {


            // Implicit COnversions

            ushort uVar1;

            char chrTest = 'a';

            uVar1 = chrTest;

            Console.WriteLine(" Source Val = {0} ", uVar1);

            Console.WriteLine("Desination Var = {0} ", chrTest);


            // Explicit Conversions

            byte byteVar;

            short shVar = 255;

            byteVar = unchecked ((byte) shVar);

            Console.WriteLine(" Source Val = {0} ", byteVar );

            Console.WriteLine("Desination Var = {0} ", shVar );


            Console.ReadKey();


        }
    }
}
