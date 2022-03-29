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
bool Is3Power(int n) // Метод учитывает, что 3 в 0 степени равно 1 => 1 - степень тройки
{
    bool result = true;
    bool temp;
    if (n == 1) return result; 
    if (n % 3 != 0) return false;
    if (n > 1) 
    {
        temp = Is3Power(n / 3);
        result = result && temp;

    }
    return result;
}
Console.Clear();
Console.WriteLine("==========Дополнительная задача № 3==========");
Console.WriteLine("Дано число N. Используя рекурсию, определите, что оно является степенью числа 3.");
int n = 0;

Console.Write("Введите число больше либо равно 3: ");
do
{
    n = GetNaturalNumber();
    if (n < 3) Console.Write("Ошибка, число должно быть больше либо равно 3. Введите число: ");
} while (n < 3);
Console.Write ($"Число {n} ");
if (!Is3Power(n)) Console.Write("НЕ ");
Console.WriteLine("является степенью числа 3");
