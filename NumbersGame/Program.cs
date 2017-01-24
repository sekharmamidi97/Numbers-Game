using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Numbers Game!");
            bool likeToPlay = true;
            
            while (likeToPlay)
            {
                try
                {
                    Console.WriteLine("Please enter any number: ");
                    string userChoice = Console.ReadLine();
                    int userPick = int.Parse(userChoice);

                    Random random = new Random();
                    int computerPick = random.Next(1,5);

                    if (computerPick > userPick)
                    {
                        Console.WriteLine("Rats! The computer picked a larger number and you lose!");
                    }

                    else if (computerPick < userPick)
                    {
                        Console.WriteLine("Awesome! You picked a larger number than the computer and you win!");
                    }

                    else 
                    {
                        Console.WriteLine("You picked the same number as the computer and it's a tie!");
                    }

                    Console.WriteLine("Do you want play this game again? y = yes or n = no");
                    ConsoleKeyInfo key = Console.ReadKey();
                    Console.WriteLine();
                    likeToPlay = key.KeyChar == 'y';
                }
                catch(FormatException ex)
                {
                    Console.WriteLine("You must enter a number!");
                }
            }

        }
    }
}

