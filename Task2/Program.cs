﻿// Задача 2: 
// Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.


using System;

class Program
{
    static void Main()
    {
        // Задаем строку, содержащую латинские буквы в обоих регистрах
        string inputString = "HeLlO WoRlD";

        // Вызываем метод, который заменит все заглавные буквы на строчные
        string resultString = ConvertToUpperToLower(inputString);

        // Выводим исходную и полученную строки для проверки результата
        Console.WriteLine("Исходная строка: " + inputString);
        Console.WriteLine("Результат: " + resultString);
    }

    static string ConvertToUpperToLower(string input)
    {
        // Создаем пустую строку, в которую будем добавлять преобразованные символы
        string result = "";

        // Проходим по каждому символу входной строки
        foreach (char c in input) //(char c in input) - это объявление переменной цикла и 
                                //указание типа элемента в коллекции (в данном случае, символ).
        {
            // Проверяем, является ли текущий символ заглавной буквой
            if (char.IsUpper(c))
            {
                // Если да, то добавляем в результат эту букву, преобразованную в строчную
                result += char.ToLower(c);
            }
            else
            {
                // Если символ не является заглавной буквой, то добавляем его без изменений
                result += c;
            }
        }

        // Возвращаем полученную строку
        return result;
    }
}
