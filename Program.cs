public class Program
{
    public static void Main(string[] args)
    {
        // inizializzo un nuovo oggetto di tipo Random:
        Random dice = new Random();

        // inizializzo un nuovo oggetto della classe Methods:
        Methods method = new Methods();

        // variabili che simulano il lancio di tre dadi a 6 facce:
        int roll1 = dice.Next(1, 7);
        int roll2 = dice.Next(1, 7);
        int roll3 = dice.Next(1, 7);

        // variabile booleana che verifica se il lancio doppio si è avverato:
        bool doubleCase = false;

        // variabile booleana che verifica se il lancio triplo si è avverato:
        bool tripleCase = false;

        // variabile dello score finale:
        int total = roll1 + roll2 + roll3;

        // stampo la somma totale dal lancio dei 3 dadi:
        Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

        // verifico se si è avverato il caso del lancio triplo:
        if (method.CheckTriple(roll1, roll2, roll3))
        {
            Console.WriteLine("You rolled triples! +6 bonus to total!");
            tripleCase = true;
            total += 6;
        }

        // verifico se si è avverato il caso del lancio doppio
        // (se si è verificato il lancio triplo questo bonus non deve valere):
        if (method.CheckDouble(roll1, roll2, roll3, tripleCase))
        {
            Console.WriteLine("You rolled doubles! +2 bonus to total!");
            doubleCase = true;
            total += 2;
        }

        // stampo il risultato finale (solo nel caso in cui si sia avverato un bonus):
        if (tripleCase || doubleCase) {
            Console.WriteLine("Total = " + total);
        }

        // verifico il risultato finale:
        method.CheckResults(total);
    }
}