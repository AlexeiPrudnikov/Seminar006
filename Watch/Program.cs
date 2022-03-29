string[][,] digits = new string[10][,];
digits[0] = new string[,]    
{
            {"@", "@", "@", "@"},
            {"@", " ", " ", "@"},
            {"@", " ", " ", "@"},
            {"@", " ", " ", "@"},
            {"@", " ", " ", "@"},
            {"@", "@", "@", "@"}
};
digits[1] = new string[,]    
{
            {" ", " ", " ", "@"},
            {" ", " ", "@", "@"},
            {" ", "@", " ", "@"},
            {" ", " ", " ", "@"},
            {" ", " ", " ", "@"},
            {" ", " ", " ", "@"}
};
digits[2] = new string[,]    
{
            {" ", "@", "@", " "},
            {"@", " ", " ", "@"},
            {" ", " ", " ", "@"},
            {" ", " ", "@", " "},
            {" ", "@", " ", "@"},
            {"@", "@", "@", "@"}
};
digits[3] = new string[,]    
{
            {"@", "@", "@", "@"},
            {" ", " ", " ", "@"},
            {"@", "@", "@", "@"},
            {" ", " ", " ", "@"},
            {" ", " ", " ", "@"},
            {"@", "@", "@", "@"}
};
digits[4] = new string[,]    
{
            {"@", " ", " ", "@"},
            {"@", " ", " ", "@"},
            {"@", "@", "@", "@"},
            {" ", " ", " ", "@"},
            {" ", " ", " ", "@"},
            {" ", " ", " ", "@"}
};
digits[5] = new string[,]    
{
            {"@", "@", "@", "@"},
            {"@", " ", " ", " "},
            {"@", "@", "@", "@"},
            {" ", " ", " ", "@"},
            {" ", " ", " ", "@"},
            {"@", "@", "@", "@"}
};
digits[6] = new string[,]    
{
            {"@", "@", "@", "@"},
            {"@", " ", " ", " "},
            {"@", "@", "@", "@"},
            {"@", " ", " ", "@"},
            {"@", " ", " ", "@"},
            {"@", "@", "@", "@"}
};
digits[7] = new string[,]    
{
            {"@", "@", "@", "@"},
            {" ", " ", " ", "@"},
            {" ", " ", " ", "@"},
            {" ", " ", "@", " "},
            {" ", "@", " ", " "},
            {" ", "@", " ", " "}
};
digits[8] = new string[,]    
{
            {"@", "@", "@", "@"},
            {"@", " ", " ", "@"},
            {"@", "@", "@", "@"},
            {"@", " ", " ", "@"},
            {"@", " ", " ", "@"},
            {"@", "@", "@", "@"}
};
digits[9] = new string[,]    
{
            {"@", "@", "@", "@"},
            {"@", " ", " ", "@"},
            {"@", "@", "@", "@"},
            {" ", " ", " ", "@"},
            {" ", " ", " ", "@"},
            {"@", "@", "@", "@"}
};

void FillEmptyWatch(string[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = " ";
        }
    }
    array[1, 10] = "@";
    array[4, 10] = "@";
    array[1, 22] = "@";
    array[4, 22] = "@";
}
void PrintArray(string[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
        }
        Console.WriteLine();
    }
}
void PutDigit (string[,] watch, string [,] digitView, int place)
{
    int start = 0;
    switch (place)
    {
        case 1:
                start = 0;
                break;
        case 2:
                start = 5;
                break;
        case 3:
                start = 12;
                break;
        case 4:
                start = 17;
                break;
        case 5:
                start = 24;
                break;
        case 6:
                start = 29;
                break;

    }
    for (int i = 0; i < digitView.GetLength(0); i++)
    {
        for (int j = start; j < digitView.GetLength(1) + start; j++)
        {
            watch[i, j] = digitView[i, j - start];
        }
    }   
}
void GetTimeDigits(int[] timeDigits)
{
    DateTime time = DateTime.Now;
    string timeStr = time.ToLongTimeString();
    timeDigits[0] = Convert.ToInt32(timeStr[0].ToString());
    timeDigits[1] = Convert.ToInt32(timeStr[1].ToString());
    timeDigits[2] = Convert.ToInt32(timeStr[3].ToString());
    timeDigits[3] = Convert.ToInt32(timeStr[4].ToString());
    timeDigits[4] = Convert.ToInt32(timeStr[6].ToString());
    timeDigits[5] = Convert.ToInt32(timeStr[7].ToString());
    return;
}
Console.Clear();
string[,] watch = new string[6, 33]; 
FillEmptyWatch(watch);
PrintArray(watch);
string[,] digit = new string[6,4];
Console.Clear();
int[] timeDigits = new int[6];
do
{
    GetTimeDigits(timeDigits);
    for (int i = 0; i < timeDigits.Length; i++)
    {
        PutDigit(watch, digits[timeDigits[i]], i+1);
    }
    Console.Clear();
    PrintArray(watch);
    Console.WriteLine();
    Thread.Sleep(1000);
}
while(1==1);
