using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть число: ");
        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("Число парне.");
        }
        else
        {
            Console.WriteLine("Число непарне.");
        }

        if (number % 3 == 0)
        {
            Console.WriteLine("Число ділиться на 3.");
        }
        else
        {
            Console.WriteLine("Число не ділиться на 3.");
        }
    }
}

