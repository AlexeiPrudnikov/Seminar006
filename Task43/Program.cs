int GetNumber()
{
    try
    {
        int number = Convert.ToInt32(Console.ReadLine());
        return number;
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
        Console.WriteLine("Ввод произведен с ошибкой. Используется число по умолчанию -> 0");
        return 0;
    }
}
Dot GetIntersectPoint(Line l1, Line l2)
{
    Dot intersectPoint = new Dot();
    try
    {
        intersectPoint.X = (float)(l1.B - l2.B) / (l2.K - l1.K);
        intersectPoint.Y = l1.K * intersectPoint.X + l1.B;
        return intersectPoint;
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        return intersectPoint;
    }
}
Console.Clear();
Console.WriteLine("==========Задача № 43==========");
Console.WriteLine("Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.");
Line[] lines = new Line[2];
for (int i = 0; i < lines.Length; i++)
{
    Console.Write($"Введите коэффициент K {i+1}-й прямой: ");
    lines[i].K = GetNumber();
    Console.Write($"Введите коэффициент B {i+1}-й прямой: ");
    lines[i].B = GetNumber();
}
Console.WriteLine();
if (lines[0].K == lines[1].K)
{
    if (lines[0].B == lines[1].B)
    {
        Console.WriteLine("Прямые совпадают");
    }
    else
    {
        Console.WriteLine("Прямые параллельные, не пересекаются");
    }
}
else
{
    Dot interPoint = GetIntersectPoint(lines[0], lines[1]);
    Console.WriteLine($"Координата точки пересечения (x; y) прямых -> ({interPoint.X}; {interPoint.Y})");
}
struct Line
{
    public int K {get; set;}
    public int B {get; set;}
}
struct Dot
{
    public float X {get; set;}
    public float Y {get; set;}
}