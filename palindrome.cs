using System;
using System.Linq;
class Program {
    static void Main() {
        Console.Write("Enter string: ");
        string str = Console.ReadLine();
        string rev = new string(str.Reverse().ToArray());
        Console.WriteLine(str == rev ? "Palindrome" : "Not palindrome");
    }
}
