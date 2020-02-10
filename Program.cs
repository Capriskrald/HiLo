using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiLo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool guessed = false;
            int randomNumber;
            int response;
            String str;

            Console.WriteLine("This is a game of Hi-lo");
            Console.WriteLine("Are you the guesser(1) or am I?(2)");
            Console.WriteLine("Choose wisely");
            str = Console.ReadLine();
            response = int.Parse(str);

            if(response == 1)
            {
                Console.WriteLine("I will think of a number between 1 and 100, and you guess it");
                randomNumber = random.Next(1, 100);

                while (guessed == false)
                {
                    Console.WriteLine("Enter your guess");
                    str = Console.ReadLine();
                    response = int.Parse(str);

                    if (response == randomNumber)
                    {
                        Console.WriteLine("Good guess, Niller is gay");
                        guessed = true;
                    }

                    else if (response < randomNumber)
                        Console.WriteLine("Your guess is too low");
                    else
                        Console.WriteLine("Your guess is too high");
                }
            }
            
            else if(response == 2)
            {
                Console.WriteLine("Think of a number between 1 and 100 and I will guess it");
                Console.WriteLine("Press any key, when you're ready");
                Console.ReadLine();
                Console.WriteLine("I will make a guess");
                System.Threading.Thread.Sleep(1000);
                randomNumber = random.Next(1, 100);
                
                while(guessed == false)
                {
                    Console.WriteLine($"My guess is {randomNumber}");
                    Console.WriteLine("Tell me if I'm <H>igh, <L>ow or <E>qual?");
                    str = Console.ReadLine();
                    str = str.ToUpper();

                    switch (str)
                    {
                        case "H":
                            randomNumber--;
                            break;
                        case "L":
                            randomNumber++;
                            break;
                        case "E":
                            Console.WriteLine("Haha, I got you, that was too easy! Niller is gay haha lol");
                            Console.ReadKey();
                            return;
                    }
                }
            }

            else
            {
                Console.WriteLine("Bad choice");
            }

            Console.ReadLine();
        }
    }
}
