namespace lab2t22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите четырёхзначное число: ");
            int num = int.Parse(Console.ReadLine());
            int dgt1 = num / 1000;
            int dgt2 = (num / 100) % 10;
            int dgt3 = (num / 10) % 10;
            int dgt4 = num % 10;
            int summ = dgt1 + dgt2 + dgt3 + dgt4;
            int x = dgt1 * dgt2 * dgt3 * dgt4;
            Console.WriteLine($"Сумма цифр: {summ}");
            Console.WriteLine($"Произведение цифр: {x}");
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
