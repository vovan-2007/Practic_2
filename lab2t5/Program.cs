﻿namespace lab2t5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            string a = Console.ReadLine();
            int b = int.Parse(a) * int.Parse(a);
            Console.WriteLine("Результат: " + b);
            Console.WriteLine("Нажмите на любую клавишу для выхода");
            Console.ReadKey();
        }
    }
}
