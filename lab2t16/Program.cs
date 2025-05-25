namespace lab2t16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("уравнение вида ax^2+bx+c=0, вычислить корни");
            Console.Write("Введите значение a:");
            string a = Console.ReadLine();
            Console.Write("Введите значение b:");
            string b = Console.ReadLine();
            Console.Write("Введите значение с:");
            string с = Console.ReadLine();
            int D = int.Parse(b) * int.Parse(b) - 4 * int.Parse(a) * int.Parse(с);
            double x1 = (-int.Parse(b) - float.RootN((D), 2)) / 2 * int.Parse(a);
            double x2 = (-int.Parse(b) + float.RootN(D, 2)) / 2 * int.Parse(a);
            Console.WriteLine("ax^2+bx+c=0, x1=" + x1);
            Console.WriteLine("ax^2+bx+c=0, x2=" + x2);
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
