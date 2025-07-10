public class Methods
{
    // Metodo che consente di verificare se nel lancio di tre dadi si è verificato
    // almeno una coppia di double:
    public static bool CheckDouble(int roll1, int roll2, int roll3, bool bonus)
    {
        if (((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) && !bonus)
        {
            return true;
        }
        return false;
    }

    // Metodo che consente di verificare se, nel lancio di tre dadi, tutti e tre i dadi
    // hanno dato risultato uguale:
    public static bool CheckTriple(int roll1, int roll2, int roll3)
    {
        if ((roll1 == roll2) && (roll2 == roll3))
        {
            return true;
        }
        return false;
    }

    // Metodo di verifica del risultato finale:
    public static void CheckResults(int total)
    {
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