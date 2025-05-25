namespace lab2t2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует рандомайзер, для продолжения введите диапазон выбора");
            Console.Write("Введите начальное число диапазона: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите конечное число диапазона: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            Console.WriteLine(rnd.Next(a, b));
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
