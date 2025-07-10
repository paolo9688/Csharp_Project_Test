public class Program
{
    public static void Main(string[] args)
    {
        Random dice = new Random();

        // variabili che simulano il lancio di tre dadi a 6 facce:
        int roll1 = dice.Next(1, 7);
        int roll2 = dice.Next(1, 7);
        int roll3 = dice.Next(1, 7);

        // variabile booleana che verifica se il lancio triplo si è avverato:
        bool triple = false;

        // variabile dello score finale:
        int total = roll1 + roll2 + roll3;

        Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

        // verifico se si è avverato il caso del lancio triplo:
        if (Methods.CheckTriple(roll1, roll2, roll3))
        {
            Console.WriteLine("You rolled triples! +6 bonus to total!");
            total += 6;
            triple = true;
        }

        // verifico se si è avverato il caso del lancio doppio:
        if (Methods.CheckDouble(roll1, roll2, roll3, triple))
        {
            Console.WriteLine("You rolled doubles! +2 bonus to total!");
            total += 2;
        }

        // stampo il risultato finale:
        Console.WriteLine("Total = " + total);

        // verifico il risultato finale:
        Methods.CheckResults(total);
    }
}