int GetCountVowel(string str)
{
    int countVowel = 0;
    if (str.Length == 0) return 0;
    if (str.Length > 1)
    {
        countVowel += GetCountVowel(str.Substring(1,str.Length - 1));
    }
    switch (str[0])
    {
        case 'а':
        case 'я':
        case 'о':
        case 'ё':
        case 'у':
        case 'ю':
        case 'ы':
        case 'и':
        case 'э':
        case 'е':
        case 'А':
        case 'Я':
        case 'О':
        case 'Ë':
        case 'У':
        case 'Ю':
        case 'Ы':
        case 'И':
        case 'Э':
        case 'Е':
                countVowel++;
                break;
    }
    return countVowel;
}
Console.Clear();
Console.WriteLine("==========Дополнительная задача № 2==========");
Console.WriteLine("На вход подаётся поговорка “без труда не выловишь и рыбку из пруда”. Используя рекурсию, подсчитайте, сколько в поговорке гласных букв");
string str = "без труда не выловишь и рыбку из пруда";
Console.WriteLine($"Исходная строка: {str}");
Console.WriteLine($"Количесво гласных в исходной строке -> {GetCountVowel(str)}");