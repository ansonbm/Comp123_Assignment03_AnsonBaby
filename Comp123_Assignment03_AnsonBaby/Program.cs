/*
 * Assignment-03_Comp123
 * Name : Anson Baby
 * Date : 26 Feb 2015
 * App Description : Build and impliment planet class
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp123_Assignment03_AnsonBaby
{
    class Program
    {
        static void Main()
        {

            GiantPlanet jupiter = new GiantPlanet ("gas","Jupiter",10000000000,9999999999);
            Console.WriteLine(jupiter.ToString());
            Console.WriteLine();
            TerrestrialPlanet earth = new TerrestrialPlanet(true, "Earth", 55555555, 7777777777);
            Console.WriteLine(earth.ToString());

            waitForAnyKey();

        }

         // PRIVATE METHODS++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private static void waitForAnyKey()
        {
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++++++++++++++");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
       
        }
    }
}
