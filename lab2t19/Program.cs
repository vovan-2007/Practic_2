﻿namespace lab2t19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину первой стороны: ");
            string a = Console.ReadLine();
            Console.Write("Введите длину второй стороны: ");
            string b = Console.ReadLine();
            Console.Write("Введите длину третьей стороны: ");
            string c = Console.ReadLine();
            float P = float.Parse(a) + float.Parse(b) + float.Parse(c);
            Console.WriteLine("Периметр равен: " + P);
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
