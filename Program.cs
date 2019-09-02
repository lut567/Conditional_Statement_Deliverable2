/*
 * 
 * coder: Shane Luttmann
 * 9/2/19
 * Deliverable 2
 * 
 */

using System;

namespace Conditional_Statement_Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vars needed for program
            String exit = "Y";
            string input = "";
            decimal expGrade = 0;
            string finalGrade = "";

            // Try Catch statment to catch any errors
            try
            {
                // While statement to control is the user wants to input another grade
                while (exit == "Yes" || exit == "yes" || exit == "y" || exit == "Y")
                {
                    // Asks for user input
                    Console.Write("What grade do you expect to get for ISM 4300?: ");
                    input = Console.ReadLine();

                    // Phrse the input string into a decimal
                    expGrade = decimal.Parse(input);

                    // Nested While loop that checks if the user inputed a number between 0 to 100. If not, asks the user to input a new grade.
                    while (expGrade < 0 && expGrade > 100)
                    {
                        Console.WriteLine("\nPlease input a grade less than 100 and greater than 0");
                        Console.Write("What grade do you expect to get for ISM 4300?: ");
                        input = Console.ReadLine();

                        expGrade = decimal.Parse(input);
                    }

                    // If loop that takes user input and gives a grade based on the syllabus
                    if (expGrade <= 100 && expGrade >= 98)
                    {
                        finalGrade = "A+";
                    }
                    else if (expGrade <= 97 && expGrade >= 92)
                    {
                        finalGrade = "A";
                    }
                    else if (expGrade <= 91 && expGrade >= 90)
                    {
                        finalGrade = "A-";
                    }
                    else if (expGrade <= 89 && expGrade >= 88)
                    {
                        finalGrade = "B+";
                    }
                    else if (expGrade <= 87 && expGrade >= 82)
                    {
                        finalGrade = "B";
                    }
                    else if (expGrade <= 81 && expGrade >= 80)
                    {
                        finalGrade = "B-";
                    }
                    else if (expGrade <= 79 && expGrade >= 78)
                    {
                        finalGrade = "C+";
                    }
                    else if (expGrade <= 77 && expGrade >= 72)
                    {
                        finalGrade = "C";
                    }
                    else if (expGrade <= 71 && expGrade >= 70)
                    {
                        finalGrade = "C-";
                    }
                    else if (expGrade <= 69 && expGrade >= 68)
                    {
                        finalGrade = "D+";
                    }
                    else if (expGrade <= 67 && expGrade >= 62)
                    {
                        finalGrade = "D";
                    }
                    else if (expGrade <= 61 && expGrade >= 60)
                    {
                        finalGrade = "D-";
                    }
                    else if (expGrade <= 60 && expGrade >= 0)
                    {
                        finalGrade = "F";
                    }

                    // Output that shows your grade.
                    Console.WriteLine("\nYour grade is: " + finalGrade);

                    // Reads input for the user to restart the while loop. (Restarting the program)
                    Console.Write("\nDo you want to input a new grade?: ");
                    exit = Console.ReadLine();
                }

            }
            // catch if there is an error.
            catch
            {
                Console.WriteLine("Error");
            }
        }
    }
}
