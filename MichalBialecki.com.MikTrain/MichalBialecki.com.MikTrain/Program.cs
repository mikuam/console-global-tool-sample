﻿using System;
using System.Threading;

namespace MichalBialecki.com.MikTrain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();

            MultiLineAnimation();

            Console.ReadKey();
        }

        static void MultiLineAnimation()
        {
            var counter = 0;
            for (int i = 0; i < 30; i++)
            {
                Console.Clear();

                switch (counter % 4)
                {
                    case 0:
                    {
                        Console.WriteLine("╔════╤╤╤╤════╗");
                        Console.WriteLine("║    │││ \\   ║");
                        Console.WriteLine("║    │││  O  ║");
                        Console.WriteLine("║    OOO     ║");
                        break;
                    };
                    case 1:
                    {
                        Console.WriteLine("╔════╤╤╤╤════╗");
                        Console.WriteLine("║    ││││    ║");
                        Console.WriteLine("║    ││││    ║");
                        Console.WriteLine("║    OOOO    ║");
                        break;
                    };
                    case 2:
                    {
                        Console.WriteLine("╔════╤╤╤╤════╗");
                        Console.WriteLine("║   / │││    ║");
                        Console.WriteLine("║  O  │││    ║");
                        Console.WriteLine("║     OOO    ║");
                        break;
                    };
                    case 3:
                    {
                        Console.WriteLine("╔════╤╤╤╤════╗");
                        Console.WriteLine("║    ││││    ║");
                        Console.WriteLine("║    ││││    ║");
                        Console.WriteLine("║    OOOO    ║");
                        break;
                    };
                }

                counter++;
                Thread.Sleep(200);
            }
        }
    }
}
