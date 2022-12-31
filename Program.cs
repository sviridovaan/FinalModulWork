//Написать программу, которая из имеющегоcя массива строк 
//формирует массив из строк, длина которых меньше либо равна 3 символа
Console.Clear();

string[] array = new string[4] { "hello", "2", "world", ":-)" };

Console.WriteLine($"Заданный массив: ");
Console.Write($"[");
ShowArray(array);
Console.WriteLine($"]");

Console.WriteLine("Элементы, длина которых меньше либо равна 3 символам: ");
Console.Write($"[");
PrintArray(array);
Console.Write($"]");

void ShowArray(string[] arr1)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(" '{1}'  ", i, arr1[i]);
    }
}

void PrintArray(string[] arr1)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            Console.Write(" '{1}'  ", i, arr1[i]);
        }
    }
}