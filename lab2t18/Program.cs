namespace lab2t18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите внешний радиус R");
            string R = Console.ReadLine();
            Console.Write("Введите внутренний радиус r=");
            string r = Console.ReadLine();
            double S = Math.PI * (int.Parse(R) * int.Parse(R) - int.Parse(r) * int.Parse(r));
            Console.WriteLine("Площадь равна: " + S);
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
