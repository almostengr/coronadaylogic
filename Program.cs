using System;

namespace Almostengr.CoronaDayLogic
{
    class Program
    {
        private static int isSunday = 0;
        private static int isMonday = 0;
        private static int isTuesday = 0;
        private static int isWednesday = 0;
        private static int isThursday = 0;
        private static int isFriday = 0;
        private static int isSaturday = 0;

        static string processInput(string inputText){
            string returnVal = inputText.ToLower();
            return returnVal;
        }

        static void Main(string[] args)
        {
            Console.Write("Did my alarm go off? (y/n) ");
            string input = Console.ReadLine();

            input = processInput(input);

            if (input == "y") {
                isMonday++;
                isTuesday++;
                isWednesday++;
                isThursday++;
                isFriday++;
            }

            Console.Write("Did mailman run? ");
            input = Console.ReadLine();

            input = processInput(input);

            if (input == "y"){
                isMonday++;
                isTuesday++;
                isWednesday++;
                isThursday++;
                isFriday++;
                isSaturday++;
            }

            Console.Write("Is there a newspaper in the driveway? ");
            input = Console.ReadLine();

            input = processInput(input);

            if (input == "y"){
                isThursday++;
            }

            Console.Write("Do neighbors have trash cans by the street? ");
            input = Console.ReadLine();

            input = processInput(input);

            if (input == "y"){
                isTuesday++;
                isFriday++;
            }

            Console.Write("Did you hear tornado sirens at their tested time? ");
            input = Console.ReadLine();

            input = processInput(input);

            if (input == "y"){
                isWednesday++;
            }

            Console.Write("Did robot vacuum run? ");
            input = Console.ReadLine();

            input = processInput(input);

            if (input == "y"){
                isMonday++;
                isWednesday++;
                isFriday++;
            }

            Console.Write("Did church live stream today? ");
            input = Console.ReadLine();
            input = processInput(input);

            if (input == "y"){
                isSunday++;
            }

            Console.Write("Was there a weather radio test? ");
            input = Console.ReadLine();
            input = processInput(input);

            if (input == "y"){
                isWednesday++;
                isSaturday++;
            }

            // final results
            Console.WriteLine(); // blank line
            Console.WriteLine("Today is probably one of the days with the highest value");
            Console.WriteLine("Sunday: " + isSunday);
            Console.WriteLine("Monday: " + isMonday);
            Console.WriteLine("Tuesday: " + isTuesday);
            Console.WriteLine("Wednesday: " + isWednesday);
            Console.WriteLine("Thursday: " + isThursday);
            Console.WriteLine("Friday: " + isFriday);
            Console.WriteLine("Saturday: " + isSaturday);
        }
    }
}
