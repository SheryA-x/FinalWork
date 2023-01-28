﻿/*
1 - Создать репозиторий на GitHub
2 - Нарисовать блок схему алгоритма
3 - Снабдить репозиторий оформаленным текстовым описанием решения (файл README.md)
4 - Написать программу, решающую задачу
5 - Использовать контроль версий в работе над этим проектом (2-4 этапа)

Задача

Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
исключительно массивами.

Примеры:

["Hello", "2", "world", *:-)"] > ["2", "5-)*]
['1234", "1567", "-2", "computer science"] -> ["-2"]
['Russia", "Denmark", "Kazan"] -> []

*/

using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите слово");
        string x = Console.ReadLine();      //Вводим слово с клавиатуры


        if (x.Length <= 3)                  //Проверяем условие
        {
            Console.WriteLine($"[{x}]");    //Выводим на экран если условие верно
        }
        else { Console.WriteLine($"[]"); }  //Выводим на экран если условие НЕ верно
    }

}