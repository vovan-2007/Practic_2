﻿namespace lab2t1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine(rnd.Next());
            Console.WriteLine(rnd.Next(5));
            Console.WriteLine(rnd.Next(-5, 5));
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
