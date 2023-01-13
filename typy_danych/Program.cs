namespace typy_danych
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz dane pracownika \n");
            Console.WriteLine("Imię:");
            string imie = Console.ReadLine();
            Console.WriteLine("Nazwisko:");
            string nazwisko = Console.ReadLine();
            Console.WriteLine("Wiek:");
            short wiek = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Płeć (m/k):");
            char sex = Char.Parse(Console.ReadLine());
            Console.WriteLine("PESEL:");
            ulong pesel = UInt64.Parse(Console.ReadLine());
            Console.WriteLine("Nr pracownika:");
            uint nr = UInt32.Parse(Console.ReadLine()); 

        }
    }
}