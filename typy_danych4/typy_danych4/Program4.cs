internal class Program4
{
    private static void Main(string[] args)
    {
        int liczba = 0;
        string tekst;
        double liczba2 = 0;

        /* liczba = 10;
         tekst = "Szkoła Dotneta";
         liczba2 = 12.5;*/


        Console.WriteLine("Wpisz wartość liczbową:");
        Int32.TryParse(Console.ReadLine(), out liczba);
        Console.WriteLine("Wpisz tekst:");
        tekst = Console.ReadLine();
        Console.WriteLine("Wpisz kolejną wartość liczbową:");
        Double.TryParse(Console.ReadLine(), out liczba2);

    }
}