using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicproject
{
    class Program
    {
        static void Main(string[] args)
        {
            int whatAge;
            bool anyDui;
            int speedingTickets;


            Console.WriteLine("What is your age? ");
            whatAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI? True or False");
            anyDui = Convert.ToBoolean(Console.ReadLine());


            Console.WriteLine("How many speeding tickets have you had? If none, please type in 0");
            speedingTickets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qualified?");

            if (whatAge >= 15 && anyDui == false && speedingTickets <= 2)
            {

                Console.WriteLine("True");
            }else
            {
                Console.WriteLine("False");
            }

            

            Console.ReadLine();

        }
    }
}
