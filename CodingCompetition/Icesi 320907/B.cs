using System;
/// <summary>
/// B - Burglar and Matches 
/// By: Alvaro Acosta
/// </summary>
public class B
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        string[] inputSplit = input.Split(' ');

        int n = int.Parse(inputSplit[0]);
        int m = int.Parse(inputSplit[1]);

        int[] matches = new int[11];

        while (m > 0)
        {
            input = Console.ReadLine();
            inputSplit = input.Split(' ');

            int ai = int.Parse(inputSplit[0]);
            int bi = int.Parse(inputSplit[1]);

            matches[bi] += ai;
            m--;
        }

        int maximum = 0;

        for (int i = 10; i > 0 && n > 0; i--)
        {
            maximum += matches[i] <= n ? i * matches[i] : (i * n);
            n -= matches[i];
        }

        Console.WriteLine(maximum);
    }
}

