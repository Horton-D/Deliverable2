using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            int heads = 0;
            int tails = 0;
            int numOfFlips = 0;
            string userPick;
            Random coinflip = new Random();




            System.Console.WriteLine("Welcome to coin flip, whats your name");
            string name;
            name = Console.ReadLine();
            Console.WriteLine("Please choose heads or tails");
            userPick = Console.ReadLine();


            Console.WriteLine(name + " How many times would you like to flip a coin? ");
            numOfFlips = Convert.ToInt32(Console.ReadLine());









            for (int i = 0; i < numOfFlips; i++)
            {


                int flip = coinflip.Next(1, 3);
                if (flip == 1)
                {
                    heads++;
                    Console.WriteLine("Heads");
                }
                else
                {
                    tails++;
                    Console.WriteLine("Tails");
                    
                }

            }
            Console.WriteLine("User chose " + userPick);

            Console.WriteLine("You flipped a coin " + numOfFlips
               + " times " + "and you got " + heads + " heads and " + tails + " tails.");

            int percentage = (heads / numOfFlips) * 100;
            Console.WriteLine(percentage);


        }
    }
}
