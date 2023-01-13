internal class Program5
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Wpisz swoje dane:");
        Console.WriteLine("Imię:");
        string imie = Console.ReadLine();
        Console.WriteLine("Nazwisko:");
        string nazwisko = Console.ReadLine();
        Console.WriteLine("Wiek:");
        ushort wiek = UInt16.Parse(Console.ReadLine());
        Console.WriteLine("Numer telefonu:");
        ulong tel = UInt64.Parse(Console.ReadLine());
        Console.WriteLine("Adres e-mail:");
        string email = Console.ReadLine();
        Console.WriteLine("Wzrost:");
        double wzrost = Double.Parse(Console.ReadLine());
        Console.WriteLine("Waga:");
        double waga = Double.Parse(Console.ReadLine());
        Console.WriteLine("Płeć (m/k):");
        char sex = Char.Parse(Console.ReadLine());
        Console.WriteLine("Miejsce zamieszkania:");
        string miasto = Console.ReadLine();
        Console.WriteLine("nr paragonu:");
        ulong numer = UInt64.Parse(Console.ReadLine());
    }
}