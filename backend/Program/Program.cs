using System.Globalization;

namespace Program;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter your name:");
        string? name = Console.ReadLine();
        Console.WriteLine($"Hello, {name}");
        Console.WriteLine("how are you?");
    }
}
