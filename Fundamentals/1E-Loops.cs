using System;
class LearnLoops

{
    public void IncPattern()
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 1; j < i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    public void DecPattern()
    {
        for (int i = 7; i > 0; i--)
        {
            for (int j = 0; i > j; j++)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    public void HashPattern()
    {
        for (int i = 0; i < 7; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("#");

            }
            Console.WriteLine();
        }
    }

    class Loop
    {
        public void LearnLoops()
        {
            // for (byte counter = 1; counter <= 100; counter++)
            // {
            //     Console.Write($"{counter}\t");
            // }

            // char input = 'y';
            // while (input == 'y')
            // {
            //     Console.Write("I am running again");

            //     Console.Write("Run again?");
            //     input = Console.ReadKey().KeyChar;
            // }

            byte[] ages = { 2, 45, 67, 12, 33, 90 };

            byte youngest = byte.MaxValue;
            foreach (var age in ages)
            {
                if (age < youngest)
                {
                    youngest = age;
                }
            }
            Console.WriteLine(youngest);

        }
    }

}