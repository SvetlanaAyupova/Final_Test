/*Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*/

string[] GetArray(string[] sourceArr)
{
    string[] finalArr = new string[sourceArr.Length];
    int count = 0;
    for (var i = 0; i < sourceArr.Length; i++)
    {
        if (sourceArr[i].Length <= 3)
        {
            finalArr[count] = sourceArr[i];
            count++;
        }
    }
    return finalArr;
}

void PrintArray(string[] array)
{
    foreach (var item in array)
    {
        Console.Write($"{item} ");
    }
}

string[] sourceArr = { "Сегодня", "6", "апреля", "и", "за", "окном", "светит", "солнце", "!" };
Console.WriteLine("Исходный массив:");
PrintArray(sourceArr);
Console.WriteLine();
string[] finalArr = GetArray(sourceArr);
Console.WriteLine("Конечный массив:");
PrintArray(finalArr);
