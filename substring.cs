using System;
class Program {
    static void Main() {
        Console.Write("Enter string: ");
        string str = Console.ReadLine();
        Console.Write("Enter start and length: ");
        int start = int.Parse(Console.ReadLine());
        int length = int.Parse(Console.ReadLine());
        string sub = str.Substring(start, length);
        Console.WriteLine("Substring: " + sub);
    }
}
