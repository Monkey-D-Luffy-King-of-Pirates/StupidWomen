using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidWomen
{
    internal class StupidWomen
    {
        int number;
        
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please, enter 1 or 2: ");
                string result = Console.ReadLine();
                if (result == " ") return;
                if (int.TryParse(result, out int number));
                {
                    if (number == 1)
                    {
                        Console.WriteLine("Fuck off, stupid women");
                        Console.ReadKey();
                    }
                    else if (number == 2)
                    {
                        Console.WriteLine("Shut up, stupid women");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Are you idiot?");

                    }
                }
            }
        }   
    }
}
