﻿using System;

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
                    Console.Write("Enter assignment number (or -1 to exit): ");
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
                        case -1:
                            keepAlive = false;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("That is not a valid exercise number!");
                            break;
                    }
                    Console.ResetColor();
                    Console.WriteLine("Hit any key to continue!");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is not a valid exercise number!");
                    Console.ResetColor();
                }
            }
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
        private static void RunExerciseTwo()
        {
            DateTime todayDate = DateTime.Today;
            DateTime yesterdayDate = todayDate.AddDays(-1);
            DateTime tomorrowDate = todayDate.AddDays(1);
            Console.WriteLine("Todays date is {0}", todayDate.ToShortDateString());
            Console.WriteLine("Tomorrows date will be {0}", tomorrowDate.ToShortDateString());
            Console.WriteLine("Yesterdays date was {0}", yesterdayDate.ToShortDateString());

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
        private static void RunExerciseFour()
        {
            String str = "The quick fox Jumped Over the DOG";

            String newStr;

            newStr = str.Substring(0, 1) + str.Substring(1).ToLower();
            newStr = newStr.Replace("quick", "brown");
            newStr = newStr.Insert(newStr.IndexOf("dog"), "lazy ");

            Console.WriteLine(newStr);
        }
    }
}