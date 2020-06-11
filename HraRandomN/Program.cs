using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HraRandomN
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int a;
            
            string again = "y";

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Number Guesser: Version 1.0 by MK");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("What is your name?");
            Console.ForegroundColor = ConsoleColor.White;
            string name = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nHello {0}, let's play a game... ", name);

            

            while (again == "y")
            {
                Random rnd = new Random();
                int num1 = rnd.Next(0, 11);
         

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nGuess a number between 1 and 10.");
                while (!(int.TryParse(Console.ReadLine(), out a) && a >= 0 && a <= 10 && a == num1))
                {

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong number, please try again");
                    Console.ForegroundColor = ConsoleColor.White;

                }

                if (a == num1)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("CORRECT!!! You guesed it!!!");
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine("Do you want play again? [Y or N]");
                    again = Console.ReadLine().ToLower();
                   

                }

            }

        



            Exit();

        
        }

        static void Exit()
        {
            ConsoleKeyInfo key;

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nFor exit from app, please press ENTER. ");
            key = Console.ReadKey();
            
            while (key.Key != ConsoleKey.Enter)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nYou hit wrong key. Please try again and press ENTER!");
                Console.ForegroundColor = ConsoleColor.White;
                key = Console.ReadKey();
                
            }

            if (key.Key == ConsoleKey.Enter)
            {
                Environment.Exit(0);
            }

        }

       

    }
}
