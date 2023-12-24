// Задача 4*(не обязательная): 
// Задайте строку, состоящую из слов, разделенных пробелами. 
// Сформировать строку, в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.

using System;

class Program
{
    static void Main()
    {
        // Задаем исходную строку, состоящую из слов, разделенных пробелами
        string originalString = "Привет мир, это задача на языке C#, использующая функцию ReverseWordsInString";

        // Вызываем функцию, которая меняет порядок слов в строке
        string reversedString = ReverseWordsInString(originalString);

        // Выводим исходную и полученную строки на экран
        Console.WriteLine("Исходная строка: " + originalString);
        Console.WriteLine("Результат: " + reversedString);
    }

    // Функция для изменения порядка слов в строке
    static string ReverseWordsInString(string input)
    {
        // Разделяем исходную строку на слова с использованием пробела в качестве разделителя
        string[] words = input.Split(' '); //Метод Split является членом класса string в C#. 
                                          //Он позволяет разбивать строку на подстроки с использованием заданного разделителя.

        // Создаем новый массив для хранения слов в обратном порядке
        string[] reversedWordsArray = new string[words.Length]; //Length - это свойство, предоставляющее длину строки, 
                                                               //массива или коллекции в C#.

        // Индекс для записи слов в обратном порядке в новый массив
        int currentReversedIndex = 0;

        // Идем от последнего слова к первому в исходном массиве
        for (int i = words.Length - 1; i >= 0; i--)
        {
            // Записываем слово в новый массив
            reversedWordsArray[currentReversedIndex] = words[i];

            // Увеличиваем индекс для записи следующего слова
            currentReversedIndex++;
        }

        // Используем метод Join для объединения слов в новой строке с использованием пробела в качестве разделителя
        string result = string.Join(" ", reversedWordsArray); //Метод Join является статическим методом класса string в C#. 
                                                             //Он используется для объединения элементов коллекции 
                                                            //(например, массива строк) в одну строку, разделяя элементы указанным разделителем.

        // Возвращаем полученную строку
        return result;
    }
}




//РЕШЕНИЕ 2
// с использованием существующих методов string.Split и LINQ строк и массивов в C#

/* using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string originalString = "Привет мир, это задача на языке C#";

        // Разбиваем строку на слова, переворачиваем порядок и объединяем обратно
        string reversedString = string.Join(" ", originalString.Split(' ').Reverse());

        Console.WriteLine("Исходная строка: " + originalString);
        Console.WriteLine("Результат: " + reversedString);
    }
} */


//РЕШЕНИЕ 3
// так же с использованием существующих методов string.Split и string.Join.
//Array.Reverse делает операцию явной и легкой для понимания, но не такой краткой, как с LINQ


/* using System;

class Program
{
    static void Main()
    {
        string originalString = "Привет мир, это задача на языке C#";

        // Разбиваем строку на слова
        string[] words = originalString.Split(' ');

        // Переворачиваем порядок слов
        Array.Reverse(words);

        // Объединяем слова обратно в строку
        string reversedString = string.Join(" ", words);

        Console.WriteLine("Исходная строка: " + originalString);
        Console.WriteLine("Результат: " + reversedString);
    }
} */




