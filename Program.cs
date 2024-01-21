using System;

public class Program
{
    public static void Main()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();

        Console.WriteLine("Hi, " + name + "! Do you want to do the COIN FLIP CHALLENGE? (y/n)");
        string play = Console.ReadLine().ToLower();

        if (play == "y")
        {
            Random rand = new Random();
            int totalCorrect = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Round " + (i + 1) + ": The computer flipped a coin. Do you think it's heads or tails?");
                string guess = Console.ReadLine().ToLower();

                string flip = rand.Next(0, 2) == 0 ? "heads" : "tails";

                Console.WriteLine("The computer flipped " + flip);

                if (guess == flip)
                {
                    totalCorrect++;
                }
            }

            Console.WriteLine("You got " + totalCorrect + " out of 10 correct!");
        }
        else
        {
            Console.WriteLine("Okay, see you next time!");
        }
    }
}