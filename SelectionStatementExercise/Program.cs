using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            int favnumber = r.Next(0, 1001);
            int userInput;
            var counter = 0;

            do
            {
                Console.WriteLine("Pick a number from 1-1000");
                userInput = int.Parse(Console.ReadLine());

                if (userInput < favnumber)
                {
                    Console.WriteLine($"{userInput} is too low!");
                }
                else if (userInput > favnumber)
                {
                    Console.WriteLine($"{userInput} is too high");
                }
                else
                {
                    Console.WriteLine("YOU GOT IT!!! CONGRATULATIONS!");
                }

                counter++;

                Console.WriteLine($"You have guessed {counter} times");

            } while (userInput != favnumber);

            Console.WriteLine("What is your favorite subject?");


            string subject = Console.ReadLine();

            switch(subject)
            {
                case "Math":
                case "Calculus":
                case "Statistics":
                    Console.WriteLine("I love Math");
                    break;
                case "Science":
                case "Physics":
                case "Chemistry":
                    Console.WriteLine("Science is my most favorite subject");
                    break;
                case "History":
                case "Government":
                case "Economic":
                    Console.WriteLine("I do not like history");
                    break;
                case "P.E.":
                    Console.WriteLine("P.E. is very exhausting");
                    break;

                default:
                    Console.WriteLine("What is this subject?");
                    break;

            }    
            

        }
    }
}
