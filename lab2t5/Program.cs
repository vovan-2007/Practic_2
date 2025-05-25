namespace lab2t5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            string a = Console.ReadLine();
            int b = Convert.ToInt32(a) * Convert.ToInt32(a);
            Console.WriteLine("Квадарат числа: " + b);
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
