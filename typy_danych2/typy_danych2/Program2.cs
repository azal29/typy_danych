namespace typy_danych2
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            /*char jeden = 'a';
            char dwa = 'b';
            char trzy = 'c';*/

            Console.WriteLine("Wpisz zmienne:");
            char jeden = Char.Parse(Console.ReadLine());
            char dwa = Char.Parse(Console.ReadLine());
            char trzy = Char.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(trzy);
            Console.WriteLine(dwa);
            Console.WriteLine(jeden);
        }
    }
}