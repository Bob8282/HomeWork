using CharArray_00;
using TryTo_00;

// // Задача 1: Задайте двумерный массив символов (тип char [,]). 
// // Создать строку из символов этого массива.
// Console.WriteLine ("Введите количество строк: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите количество столбцов: ");
// int column = Convert.ToInt32(Console.ReadLine());
// char[,] chars = CharArray.CreateCharMatrix(row, column);
// CharArray.PrintMatrix(chars);
// Console.WriteLine($"Итоговая строка: {CharArray.StringFromMatrix(chars)}");

// Задача 2: Задайте строку, содержащую латинские 
// буквы в обоих регистрах. Сформируйте строку, 
// в которой все заглавные буквы заменены на строчные.
// Console.WriteLine("Введите строку: ");
// string source = Console.ReadLine();
// Console.WriteLine($"Результат: {CharArray.LowerString(source)}");

// // Задача 3: Задайте произвольную строку. 
// // Выясните, является ли она палиндромом.
// Console.WriteLine("Введите строку: ");
// string source = Console.ReadLine();
// CharArray.PalindromCheck(source);

// Задача 4*(не обязательная): Задайте строку, состоящую из слов, 
// разделенных пробелами. Сформировать строку, 
// в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.


// Вариант 1
// string stringSource = Console.ReadLine();
// string result = TryTo.StringReverse(stringSource);
// Console.WriteLine($"{String.Join(" ", result)}");


string stringSource = Console.ReadLine(); 
// int count = Count(stringSource);
string[] res = TryTo.Str(stringSource);
Console.WriteLine($"{String.Join("; ", res)}");
// Console.WriteLine(count);
