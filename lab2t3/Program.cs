﻿namespace lab2t3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a = 3.2f;
            decimal b = 2.6m;
            double c = 4.5;
            c = c + Convert.ToDouble(a) + Convert.ToDouble(b);
            Console.WriteLine("Сумма чисел:");
            Console.WriteLine("float a = 3.2f");
            Console.WriteLine("decimal b = 2.6m");
            Console.WriteLine("double c = 4.5");
            Console.WriteLine("Результат: " + c);
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
