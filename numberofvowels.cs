using System;
class Program {
    static void Main() {
        Console.Write("Enter string: ");
        string str = Console.ReadLine();
        int count = str.Count(c => "aeiouAEIOU".Contains(c));
        Console.WriteLine("Vowels: " + count);
    }
}
