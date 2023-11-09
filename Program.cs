class Program
{
    static void Main(string[] args)
    {
        double x1 = 2, y1 = 5;
        double x2 = 2, y2 = -4;
        double x3 = 5, y3 = 1;

        Console.WriteLine("Введите координаты точки:");
        Console.Write("x = ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("y = ");
        double y = double.Parse(Console.ReadLine());

        double triangleArea = Area(x1, y1, x2, y2, x3, y3);

        double Area1 = Area(x, y, x1, y1, x2, y2);
        double Area2 = Area(x, y, x1, y1, x3, y3);
        double Area3 = Area(x, y, x2, y2, x3, y3);

        bool FullArea = Math.Abs(Area1 + Area2 + Area3 - triangleArea) < 0.000001;

        Console.WriteLine(FullArea);
    }

    static double Area(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        return Math.Abs((x1 - x3) * (y2 - y3) - (x2 - x3) * (y1 - y3)) / 2;
    }
}
