using System;
class Program {
    static void Main() {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());
        int min = 9;
        while(n > 0) {
            int d = n % 10;
            if(d < min) min = d;
            n /= 10;
        }
        Console.WriteLine("Smallest digit: " + min);
    }
}
 
