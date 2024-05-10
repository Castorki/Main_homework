// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []



string CountOfElementsLength(string[] FirstArray)
{
    string Result = string.Empty;
    foreach (string str in FirstArray)
    {
        if (str.Length <= 3)
        {
            Result += str + " ";
        }
    }
    return Result;
}


string[] StringsToArray(string str)
{

    string[] SecondArray = new string[str.Length];
    for (int i = 0; i < str.Length; i++)
    {
        SecondArray[i] = str[i].ToString();
    }
    return str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
}



void PrintArray(string[] FirstArray)
{
    for (int i = 0; i < FirstArray.Length; i++)
    {
        if (i != FirstArray.Length - 1)
        {
            Console.Write(FirstArray[i] + ", ");
        }
        else
        {
            Console.Write(FirstArray[i]);
        }
    }
    Console.WriteLine();
}

string[] FirstArray = { "Hello", "World", "2", ":-)" };
string str = CountOfElementsLength(FirstArray);
PrintArray(FirstArray);
PrintArray(StringsToArray(str));





