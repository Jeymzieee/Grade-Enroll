
class Program
{
    public class WordsOnlyException : Exception
    {
        public WordsOnlyException(string message) : base(message)
        {
        }
    }
static void Main()
    {        
        while(true)

            try{
                Console.WriteLine("Welcome to my Grade Computer! \nPlease input the following information...");
                Console.Write("FirstName: ");
                string name = Convert.ToString(Console.ReadLine());
                

                if (Approved(name))                                                       //error if user not input name/words//
                        {
                            throw new WordsOnlyException("Oops! Invalid input\n");                 
                        }

                Console.Write("Course: ");
                string course = Convert.ToString(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("\nInput your Grade\n");
                Console.ResetColor();


                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("English: ");
                Console.ResetColor();
                double E = Convert.ToDouble(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Math: ");
                Console.ResetColor();
                double M = Convert.ToDouble(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Science: ");
                Console.ResetColor();
                double S = Convert.ToDouble(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Filipino: ");
                Console.ResetColor();
                double F = Convert.ToDouble(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("History: ");
                Console.ResetColor();
                double H = Convert.ToDouble(Console.ReadLine());

                double ave = (E + M + S + F + H) / 5;
                double cave = Math.Round(ave);
                if (ave > 75)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("\nCongrats, " + name + " you PASSED!!!!!\nYour Average is " + cave);
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Keep learning " + name + "! your average is " + cave);
                    break;
                }
            }
            catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Ooops, invalid input try again...\n");
                    Console.ResetColor();
                }

                catch (WordsOnlyException a)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Ooops, invalid input try again...\n");
                    Console.ResetColor();
                }

                static bool Approved(string name)
            {
                return  !name.All(char.IsLetter);                 //Space,Empty, and whitespace is not accepted in name//
            }

        Console.WriteLine("\nPress any key to exit....");
        Console.ReadKey();
    }}