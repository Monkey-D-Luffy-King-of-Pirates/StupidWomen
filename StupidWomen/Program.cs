using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidWomen
{
    internal class StupidWomen
    {
        static void Main(string[] args)
        {
            int myNumber;

            Console.Write("Please, enter 1 or 2: ");

            while (!int.TryParse(Console.ReadLine(), out myNumber) || !(myNumber > 0 && myNumber < 3))
            {
                Console.Clear();
                Console.Write("No! \nPlease, enter 1 or 2: "); 
            }

                if (myNumber == 1)
                {
                    Console.WriteLine("Fuck off, stupid women");

                }

                else if (myNumber == 2)
                {
                    Console.WriteLine("Shut up, stupid women");                   
                }

                Console.ReadKey();

                Console.Clear();

                Console.WriteLine("Please, enter 1 or 2: ");
        }
    }       
}
