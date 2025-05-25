namespace lab2t7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double c = Math.E;
            int n = 1;
            Console.WriteLine("Число Е с точностью до десятых: " + Math.Round(c, n));
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
