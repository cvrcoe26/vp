using System;
class Program {
    static void Main() {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine()), sum = 0;
        while(n > 0) {
            sum += n % 10;
            n /= 10;
        }
        Console.WriteLine("Sum: " + sum);
    }
}
