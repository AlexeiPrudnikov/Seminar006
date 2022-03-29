int GetNaturalNumber()
{
    try
    {
        int number = 0; 
        do
        {
            number = Convert.ToInt32(Console.ReadLine());
            if (number <= 0) Console.Write("Ошибка, число не натуральное, повторите ввод: ");
        }
        while (number <= 0);
        return number;
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
        Console.WriteLine("Ввод произведен с ошибкой. Используется число по умолчанию -> 1");
        return 1;
    }
}
void GetBinCode(int n)
{
    
    int div = n / 2;
    int mod = n % 2;
    if ((div == 0) && (mod == 0)) return;
    if (div == 1)
    {
        Console.Write(div);
    }
    else
    {
        GetBinCode(div);
    }
    Console.Write(n % 2);

}
Console.Clear();
Console.WriteLine("==========Дополнительная задача № 1==========");
Console.WriteLine("Написать перевод десятичного числа в двоичное, используя рекурсию.");


Console.Write("Введите натуральное число: ");
int n = GetNaturalNumber();
Console.Write($"Двоичный код числа {n} -> ");
GetBinCode(n);
Console.WriteLine();

