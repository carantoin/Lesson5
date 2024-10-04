try
{
    Console.Write("Введите a:");
    double a = double.Parse(Console.ReadLine());
    Console.Write("Введите b:");
    double b = double.Parse(Console.ReadLine());
    double x = (a + b) * (a + b);
    double y = a * a + b * b;
    if (x > y)
    {
        Console.WriteLine("Квадрат суммы больше");
    }
    else if (x < y)

    {
        Console.WriteLine("Сумма квадратов больше");
    }
}
catch
{
    Console.WriteLine("Введите правильные данные");
}