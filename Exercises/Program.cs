using System;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var keepAlive = true;
            while (keepAlive)
            {
                try
                {
                    DisplayMenu();
                    var assignmentChoice = int.Parse(Console.ReadLine() ?? "");
                    Console.Clear();
                    switch (assignmentChoice)
                    {
                        case 1:
                            RunExerciseOne();
                            break;
                        case 2:
                            RunExerciseTwo();
                            break;
                        case 3:
                            RunExerciseThree();
                            break;
                        case 4:
                            RunExerciseFour();
                            break;
                        case 5:
                            RunExerciseFive();
                            break;
                        case 6:
                            RunExerciseSix();
                            break;
                        case 7:
                            RunExerciseSeven();
                            break;
                        case 0:
                            keepAlive = false;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("That is not a valid exercise number!");
                            break;
                    }
                    Console.ResetColor();
                    Console.WriteLine("Hit any key to continue");
                    Console.ReadKey();
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is not a valid exercise number!");
                    Console.ResetColor();
                }
            }
        }

        private static void RunExerciseSeven()
        {
            double radius = GetValidDouble("Please enter the radius: ");
            double area = 2 * Math.PI * Math.Pow(radius, 2);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("The area of a circle with radius {0} is {1}", radius, area);
            double volume = (4 * Math.PI * Math.Pow(radius, 3)) / 3;
            Console.WriteLine("The volume of a sphere with radius {0} is {1}", radius, volume);
        }
        private static void RunExerciseSix()
        {

            int numberOne = GetValidInt();
            int numberTwo = GetValidInt();
            Console.ForegroundColor = ConsoleColor.Yellow;
            double output = (double)numberOne > numberTwo ? numberOne : numberTwo;
            Console.WriteLine("The biggest number of {0} and {1} is {2}", numberOne, numberTwo, output);
            output = (double)numberOne < numberTwo ? numberOne : numberTwo;
            Console.WriteLine("The smallest number of {0} and {1} is {2}", numberOne, numberTwo, output);
            output = Math.Abs((double)(numberOne - numberTwo));
            Console.WriteLine("The diffrence between {0} and {1} is {2}", numberOne, numberTwo, output);
            output = (double)(numberOne + numberTwo);
            Console.WriteLine("The sum of {0} and {1} is {2}", numberOne, numberTwo, output);
            output = (double)(numberOne * numberTwo);
            Console.WriteLine("The product of {0} and {1} is {2}", numberOne, numberTwo, output);
            if (numberTwo == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The ratio is infinte as the denominator can't be 0");
            }
            else
            {
                output = (double)numberOne / (double)numberTwo;
                Console.WriteLine("The ratio of {0} and {1} is {2}", numberOne, numberTwo, output);
            }

        }

        private static void RunExerciseFive()
        {
            String str = "Arrays are very common in programming, they look something like: [1,2,3,4,5]";
            String newStr = str.Substring(str.IndexOf("["));
            newStr = newStr.Remove(newStr.IndexOf("2,3,"), 4);
            for (int i = 6; i <= 10; i++)
            {
                newStr = newStr.Insert(newStr.Length - 1, "," + i);
            }

            Console.WriteLine(newStr);

        }

        private static void RunExerciseFour()
        {
            String str = "The quick fox Jumped Over the DOG";

            String newStr;

            newStr = str.Substring(0, 1) + str.Substring(1).ToLower();
            newStr = newStr.Replace("quick", "brown");
            newStr = newStr.Insert(newStr.IndexOf("dog"), "lazy ");

            Console.WriteLine(newStr);
        }
        private static void RunExerciseThree()
        {
            String firstName, lastName;
            Console.Write("Enter your first name: ");
            firstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            lastName = Console.ReadLine();
            Console.WriteLine("{0} {1}", firstName, lastName);
        }
        private static void RunExerciseTwo()
        {
            DateTime todayDate = DateTime.Today;
            DateTime yesterdayDate = todayDate.AddDays(-1);
            DateTime tomorrowDate = todayDate.AddDays(1);
            Console.WriteLine("Todays date is {0}", todayDate.ToShortDateString());
            Console.WriteLine("Tomorrows date will be {0}", tomorrowDate.ToShortDateString());
            Console.WriteLine("Yesterdays date was {0}", yesterdayDate.ToShortDateString());

        }

        private static void RunExerciseOne()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Please enter your first name: ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            string firstName = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Please enter your Last name: ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            string lastName = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Hello {0} {1}!\nI'm glad to inform you are the test subject om my very first exercise!", firstName, lastName);
            Console.ResetColor();
        }

        private static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("1.\tExercise One - Welcome!");
            Console.WriteLine("2.\tExercise Two - Dating");
            Console.WriteLine("3.\tExercise Three - Who are you?");
            Console.WriteLine("4.\tExercise Four - Fox the Lazy Dog");
            Console.WriteLine("5.\tExercise Five - String of Manipulations");
            Console.WriteLine("6.\tExercise six - Comaprison of numbers");
            Console.WriteLine("7.\tExercise seven - Circelations");

            Console.WriteLine("0.\tExit");
            Console.Write("\nEnter menu number (or 0 to exit): ");
        }
        private static int GetValidInt(string displayMessage) //Caller entered a message to display
        {
            int number = 0;
            bool didParseNumber = false;
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(displayMessage);
                Console.ForegroundColor = ConsoleColor.Green;

                didParseNumber = int.TryParse(Console.ReadLine(), out number);
                if (!didParseNumber)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("You must enter an integer");
                }
            }
            while (didParseNumber == false);

            return number;
        }
        private static int GetValidInt()//Default message is shown.
        {
            return GetValidInt("Please enter an integer: ");
        }
        private static double GetValidDouble(string displayMessage) //Caller entered a message to display
        {
            double number = 0;
            bool didParseNumber = false;
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(displayMessage);
                Console.ForegroundColor = ConsoleColor.Green;
                didParseNumber = double.TryParse(Console.ReadLine(), out number);
                if (!didParseNumber)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("You must enter a number!");
                }
            }
            while (didParseNumber == false);

            return number;
        }
        private static double GetValidDouble()//Default message is shown.
        {
            return GetValidInt("Please enter a number: ");
        }


    }
}