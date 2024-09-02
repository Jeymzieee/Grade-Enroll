using System;
using System.IO;

class Program
{
    static void Main()
    {
        string letter = "y";
        while (letter == "y" || letter == "Y")
        {

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Welcome to STI! Do you want to enroll in our Campus?");
            Console.WriteLine("Press (Y) to Continue\nPress (N) to Exit");
            Console.ResetColor();
            Console.WriteLine("=====================================================================");                                                             // Asking the user
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Enter your Choice: ");
            Console.ResetColor();

            string input = Console.ReadLine();

            string[] courses = {
                "BS in Tourism",
                "BS in Information Technology",
                "BS in Hospitality Management",
                "BS in Computer Engineering",
                "BS in Computer Science"
            };

            if (input == "Y" || input == "y")                                                                                                                       // if the user want to enroll
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Fill up the Information");

                Console.Write("Last Name: ");
                string lastName = Console.ReadLine();

                Console.Write("First Name: ");
                string firstName = Console.ReadLine();

                Console.Write("Middle Name: ");
                string middleName = Console.ReadLine();

                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("The minimum payment is PHP 10000");
                Console.Write("Please Enter your Payment: ");
                Console.ResetColor();

                                                                                                                                                                     // Validate user input for payment
                string paymentInput = Console.ReadLine();
                if (!double.TryParse(paymentInput, out double fee) || fee < 10000)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid input. Please enter a valid numeric value for the payment, and it must be at least PHP 10000.");
                    Console.ResetColor();
                    continue;                                                                                                                                           // Restart the loop
                }

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Welcome {lastName}, {firstName} {middleName}!");
                Console.WriteLine("Choose your preferred course below!");

                for (int i = 0; i < courses.Length; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"Course {i + 1}: {courses[i]}");
                    Console.ResetColor();
                }

                Console.Write("Enter your Chosen Course [1-5]: ");

                if (!int.TryParse(Console.ReadLine(), out int chosenChoice) || chosenChoice < 1 || chosenChoice > 5)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid course selection.");
                    Console.ResetColor();
                    continue;
                }

                Console.WriteLine("Submit the following requirements below: File Name (Document Type)");
                Console.WriteLine("=====================================================================");
                Console.WriteLine("1. Good_Moral (docx)\n2. Form_137 (docx)\n3. PSA (docx)\n4. SHS_Diploma (docx)");
                Console.WriteLine("=====================================================================");

                string directorPath = @"E:\C#\Files";

                Console.ForegroundColor = ConsoleColor.Magenta;
                string[] fileToCheck = {

                        "GOOD_MORAL.docx",
                        "FORM_137.docx",
                        "PSA.docx",
                        "SHS_Diploma.docx",
                    };
                Console.ResetColor();

                bool ifSubmitted = true;

                foreach (string fileName in fileToCheck)
                {
                    string filePath = Path.Combine(directorPath, fileName);
                    if (File.Exists(filePath))
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine($"File {fileName} is submitted!");                                                                        // if file/s are submitted
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($"File {fileName} is not submitted yet!");                                                                // if file/s are not submitted 
                        Console.ResetColor();
                        ifSubmitted = false;
                        break;
                    }
                }

                if (ifSubmitted)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"\nWelcome {firstName} {lastName}!");
                        Console.WriteLine($"You are now enrolled for {courses[chosenChoice - 1]}!");                                                    //ending if successfull
                        Console.WriteLine("See you around fellow STI'er!!");
                        Console.ResetColor();
                        break;
                    }
                else
                {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Please submit the required files.");
                        Console.ResetColor();
                }

                Console.WriteLine("Press Y to try again or any other key to exit.");                                                                // to loop the program
                letter = Console.ReadLine();
                Console.Clear();
            }
            else if (input == "n" || input == "N")
            {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Thank you for visiting and checking out our school!");                                                  // if the user select no                                                  
                        Console.ResetColor();
                        break;
            }
            else
            {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Invalid Input");
                        Console.ResetColor();
            }
        }
    }
}