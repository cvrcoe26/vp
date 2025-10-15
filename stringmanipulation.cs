using System;
using System.Text;
class Program {
    static void Main() {
        string str = "hello";
        Console.WriteLine(str.ToUpper());
        Console.WriteLine(str.Replace('l','x'));
        StringBuilder sb = new StringBuilder(str);
        sb.Append(" world");
        Console.WriteLine(sb.ToString());
        sb.Remove(0,2);
        Console.WriteLine(sb);
        sb.Insert(0, "hi ");
        Console.WriteLine(sb);
    }
}
