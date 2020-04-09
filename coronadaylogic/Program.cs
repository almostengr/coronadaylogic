using System;

namespace coronadaylogic
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
            Console.WriteLine("Did my alarm go off? (y/n)");
            string input = Console.ReadLine();

            input = processInput(input);

            if (input == "y") {
                isMonday++;
                isTuesday++;
                isWednesday++;
                isThursday++;
                isFriday++;
            }

            Console.WriteLine("Did mailman run?");
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

            Console.WriteLine("Is there a newspaper in the driveway? (y/n)");
            input = Console.ReadLine();

            input = processInput(input);

            if (input == "y"){
                isThursday++;
            }

            Console.WriteLine("Do neighbors have trash cans by the street?");
            input = Console.ReadLine();

            input = processInput(input);

            if (input == "y"){
                isTuesday++;
                isFriday++;
            }
            
            Console.WriteLine("Did you hear tornado sirens at their tested time?");
            input = Console.ReadLine();

            input = processInput(input);

            if (input == "y"){
                isWednesday++;
            }
            
            Console.WriteLine("Did robot vacuum run?");
            input = Console.ReadLine();

            input = processInput(input);

            if (input == "y"){
                isMonday++;
                isWednesday++;
                isFriday++;
            }

            Console.WriteLine("Did church live stream today?");
            input = Console.ReadLine();
            input = processInput(input);

            if (input == "y"){
                isSunday++;
            }

            Console.WriteLine("Was there a weather radio test?");
            input = Console.ReadLine();
            input = processInput(input);

            if (input == "y"){
                isWednesday++;
                isSaturday++;
            }

            // final results
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
