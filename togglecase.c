using System;

class P
{
    static string Toggle(string s)
    {
        char[] a = s.ToCharArray();
        for (int i = 0; i < a.Length; i++)
            a[i] = char.IsLower(a[i]) ? char.ToUpper(a[i]) : char.ToLower(a[i]);
        return new string(a);
    }

    static void Main()
    {
        Console.WriteLine(Toggle("HeLLo")); // hEllO
    }
}
