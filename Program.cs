using System;

public class Program
{
    public static void Main(string[] args)
    {
        Random dice = new Random();

        int roll1 = dice.Next(1, 7);
        int roll2 = dice.Next(1, 7);
        int roll3 = dice.Next(1, 7);

        bool bonus = false;

        int total = roll1 + roll2 + roll3;

        Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

        if ((roll1 == roll2) && (roll2 == roll3))
        {
            Console.WriteLine("All scores equals! +6 bonus to total!");
            total += 6;
            bonus = true;
            Console.WriteLine("Total = " + total);
        }

        if (((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) && !bonus)
        {
            Console.WriteLine("You rolled doubles! +2 bonus to total!");
            total += 2;
            Console.WriteLine("Total = " + total);
        }

        if (total > 14)
        {
            Console.WriteLine("Hai vinto!");
        }
        else
        {
            Console.WriteLine("Hai perso.");
        }
    }
}