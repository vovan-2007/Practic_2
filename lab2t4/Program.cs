namespace lab2t4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            double b = 2.6;
            b = a + b;
            Console.WriteLine("Сумма: " + b);
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
