﻿//Написать программу, которая из имеющегоcя массива строк 
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



