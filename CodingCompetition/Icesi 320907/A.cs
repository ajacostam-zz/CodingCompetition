using System;
/// <summary>
/// A - Bear and Big Brother 
/// By: Alvaro Acosta
/// </summary>
public class A
{
    static void Main(string[] args)
    {
        string w = Console.ReadLine();

        string[] ws = w.Split(' ');

        int a = int.Parse(ws[0]);
        int b = int.Parse(ws[1]);

        double years = Math.Floor((Math.Log10(a) - Math.Log10(b)) / (Math.Log10(2) - Math.Log10(3))) + 1;

        Console.WriteLine(years);
        Console.ReadLine();
    }
}

