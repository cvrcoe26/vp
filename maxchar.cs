using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        string str = input.ToLower();

        int[] freq = new int[256];

        for (int i = 0; i < str.Length; i++)
        {
            freq[(int)str[i]]++;
        }

        int maxFreq = -1;
        char maxChar = ' ';

        for (int i = 0; i < 256; i++)
        {
            if (freq[i] > maxFreq)
            {
                maxFreq = freq[i];
                maxChar = (char)i;
            }
        }

        Console.WriteLine("Maximum occurring character: " + maxChar);
        Console.WriteLine("Frequency: " + maxFreq);
    }
}
