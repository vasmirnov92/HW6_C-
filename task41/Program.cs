// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


string[] ConsToString(string inMass)
{
    string[] delimiterStrings = {" ", ", ", ", ,", ",", " ," , ".", ". ", ". .", " ."};
    string[] outMass = inMass.Split(delimiterStrings, System.StringSplitOptions.RemoveEmptyEntries);
    return outMass;    
}

int[] StringToInt (string[] outMass)
{
    int[] outInteger = new int[outMass.Length];
    for (int i=0; i < outMass.Length; i++)
    {
        try
        {    
            outInteger[i] = Int32.Parse(outMass[i]);
        }
        catch (FormatException)
        {
            Console.WriteLine();
        }
        catch (OverflowException)
        {
            Console.WriteLine();
        }
    }
    return outInteger;    
}

int HowManyPositive(int[] massInt)
{
    int count = 0;
    for (int i=0; i<massInt.Length; i++)
    {
        if (massInt[i] > 0)
        count = count +1;
    }
    return count;
}

Console.Clear();
Console.WriteLine("Введите числа: ");
string inString = Console.ReadLine();
string[] outString = ConsToString(inString);
Console.WriteLine($"[{String.Join(", ", outString)}] массив string");   //добавлено для наглядности, можно не выводить
int[] outInt = StringToInt(outString);
Console.WriteLine($"[{String.Join(", ", outInt)}] массив int");         //добавлено для наглядности, можно не выводить
int positive = HowManyPositive(outInt);
Console.WriteLine($"Положительных чисел: {positive}");

