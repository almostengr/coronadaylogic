using System;

namespace coronadaylogic
{
    class Program
    {

        static string processInput(string inputText){
            string returnVal = inputText.ToLower();
            return returnVal;
        }

        static void Main(string[] args)
        {
            bool daySunday, dayMonday, dayTuesday, dayWednesday,
                dayThursday, dayFriday, daySaturday;

            daySunday = dayMonday = dayTuesday = dayWednesday =
                dayThursday = dayFriday = daySaturday = true;

            Console.WriteLine("Did my alarm go off? (y/n)");
            string input = Console.ReadLine();

            input = processInput(input);

            if (input == "y") {
                daySunday = false;
                daySaturday = false;
            }

            Console.WriteLine("Is there a newspaper in the driveway? (y/n)");
            input = Console.ReadLine();

            input = processInput(input);

            if (input == "y"){
                daySunday = dayMonday = dayTuesday = dayWednesday =
                    dayFriday = daySaturday = false;
            }

            Console.WriteLine("Do neighbors have trash cans by the street?");
            input = Console.ReadLine();

            input = processInput(input);

            if (input == "y"){
                daySunday = dayMonday = dayWednesday = dayThursday =
                     daySaturday = false;
            }

            Console.WriteLine("Did mailman run?");
            input = Console.ReadLine();

            input = processInput(input);

            if (input == "y"){
                daySunday = false;
            }



            Console.WriteLine("Did you hear tornado sirens at their tested time?");
            input = Console.ReadLine();

            input = processInput(input);

            if (input == "y"){
                daySunday = dayMonday = dayTuesday = dayThursday =
                     dayFriday = daySaturday = false;
            }


            // final results
            Console.WriteLine("Sunday: " + daySunday);
            Console.WriteLine("Monday: " + dayMonday);
            Console.WriteLine("Tuesday: " + dayTuesday);
            Console.WriteLine("Wednesday: " + dayWednesday);
            Console.WriteLine("Thursday: " + dayThursday);
            Console.WriteLine("Friday: " + dayFriday);
            Console.WriteLine("Saturday: " + daySaturday);
        }
    }
}
