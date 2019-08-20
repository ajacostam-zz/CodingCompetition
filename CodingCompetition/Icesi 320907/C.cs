using System;
using System.Collections.Generic;
/// <summary>
/// C - Soldier and Cards 
/// By: Alvaro Acosta
/// </summary>
public class C
{
    static void Main(string[] args)
    {
        string cardNumbers = Console.ReadLine();
        Queue<int> k1 = new Queue<int>(cardNumbers[0] + 1), k2 = new Queue<int>(cardNumbers[0] + 1);

        string[] k1CardsInput = Console.ReadLine().Split(' ');
        string[] k2CardsInput = Console.ReadLine().Split(' ');
        
        for (int i = 1; i <= int.Parse(k1CardsInput[0]); i++)
        {
            k1.Enqueue(int.Parse(k1CardsInput[i]));
        }

        for (int i = 1; i <= int.Parse(k2CardsInput[0]); i++)
        {
            k2.Enqueue(int.Parse(k2CardsInput[i]));
        }

        for (int i = 1; ; i++)
        {
            int k1Top = k1.Peek();
            int k2Top = k2.Peek();

            if (k1Top > k2Top)
            {
                k1.Enqueue(k2Top);
                k1.Enqueue(k1Top);
                k1.Dequeue();
                k2.Dequeue();
            }
            else
            {
                k2.Enqueue(k1Top);
                k2.Enqueue(k2Top);
                k1.Dequeue();
                k2.Dequeue();
            }

            if (k1.Count == 0)
            {
                Console.WriteLine(i + " 2");
                return;
            }
            else if (k2.Count == 0)
            {
                Console.WriteLine(i + " 1");
                return;
            }

            if (i > 1000)
            {
                Console.WriteLine("-1");
                return;
            }
        }
    }
}