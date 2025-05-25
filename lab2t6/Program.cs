namespace lab2t6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вывод числа с точностью до сотых"); 
            Console.Write("Введите дробное число через запятую: ");
            string c = Console.ReadLine();
            int n = 2;
            Console.WriteLine("Результат=" + Math.Round(float.Parse(c), n));
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
