internal class Program3
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Obliczanie długości przekątnej prostokąta");
        Console.WriteLine("podaj długość:");
        uint a = UInt32.Parse(Console.ReadLine());
        Console.WriteLine("Podaj szerokość:");
        uint b = UInt32.Parse(Console.ReadLine());
        Console.WriteLine();
        double a2 = Math.Pow(a, 2);
        double b2 = Math.Pow(b, 2);
        double d = Math.Pow((a2 + b2), 0.5);
        Console.WriteLine(d);
    }
}