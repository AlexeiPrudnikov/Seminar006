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
Console.Clear();
Console.WriteLine("==========Задача № 41==========");
Console.WriteLine("Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
int countNumbers = 0;
Console.WriteLine();
Console.Write("Введите количество вводимых чисел: ");
countNumbers = GetNaturalNumber();
int countPosNum = 0;
for (int i = 1; i <= countNumbers; i++)
{
    Console.Write($"Введите {i}-е число: ");
    if (GetNumber() > 0) countPosNum++;
}
Console.WriteLine();
Console.WriteLine($"Введите количество положительных введенных чисел {countPosNum}");