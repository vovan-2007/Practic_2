namespace lab2t20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 4, b = -5;
            double avg = Convert.ToDouble(Math.Abs(a) + Math.Abs(b)) / 2;
            float Geomet = float.RootN((Math.Abs(a) * Math.Abs(b)), 2);
            Console.WriteLine("Среднее арифметическое: " + avg);
            Console.WriteLine("Среднее геометрическое: " + Geomet);
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
