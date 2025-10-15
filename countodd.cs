using System;
class Program {
    static void Main() {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine()), count = 0;
        while(n != 0) {
            int d = n % 10;
            if(d % 2 == 1) count++;
            n /= 10;
        }
        Console.WriteLine("Odd digits: " + count);
    }
}
