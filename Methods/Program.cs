// Задача 1: Напишите программу, которая бесконечно 
// запрашивает целые числа с консоли. Программа 
// завершается при вводе символа ‘q’ или при вводе числа, 
// сумма цифр которого чётная.

// Проверка на четность суммы
using System.ComponentModel;

// int SumCheck(string? number)
// {
//     int sum = 0;
//     bool isNum = int.TryParse(number, out int check);
//     if (isNum)
//     {
//         for (int i = 0; i < number.Length; i++)
//         {
//             sum = sum + int.Parse(number[i].ToString());
//         }
//         return sum;
//     }
//     else
//         return 0;
// }

// int SumCheck(string? number)
// {
//     int sum = 0;
//     bool isNum = int.TryParse(number, out int check);
//     if (isNum)
//     {
//         for (int i = 0; i < number.Length; i++)
//         {
//             sum = sum + int.Parse(number[i].ToString());
//         }
//         return sum;
//     }
//     else
//         return 0;
// }

// // Цикл
//  while (true)
//  {
//     Console.WriteLine("Введите число: ");
//     string? number = Console.ReadLine ();
//     int sum = SumCheck(number);
//     bool isNum = int.TryParse(number, out int check);
//     if (isNum)
//     {
//         if (sum % 2 == 0)
//         {
//             Console.WriteLine($"Сумма числа {number} - четная {sum}, программа завершена!");
//             break;
//         }
//     }
//     else if (number == "q")
//         {
//             Console.WriteLine("Программа завершена!");
//             break;
//         }
//     else 
//     {
//         Console.WriteLine("Введеное значение не является числом!\nВведите корректное значение!");
//     }
//  }

// Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

using arrays_00; // попробовал подключить метод из другого класса
// int[] ArrayCreation(int size)
// {
//     int[] array = new int [size];
    
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//     }
//     return array;
// }

// int EvenCounting(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//             count ++;
//     }
//     return count;
// }

// while (true)
// Console.WriteLine("Введите размер массива: ");
// int size;
// bool isNum = int.TryParse(Console.ReadLine(), out size);
// int[] array = arrays.ArrayCreation(size);
// if (isNum)
// {
//     Console.WriteLine($"Массив: [{string.Join("; ", array)}]");
//     Console.WriteLine($"Количество четных чисел: {arrays.EvenCounting(array)}");
//     break;  
// }
// else 
//     Console.WriteLine("Введенно некорректное значение или 0!\nВведите корректные данные!");


// Задача 3: Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

// while (true)
// {
//     Console.WriteLine("Введите размер массива: ");
//     int size;
//     bool isNum = int.TryParse(Console.ReadLine(), out size);
//     int[] array = arrays.ArrayCreation(size);
//     if (isNum && size != 0)
//     {
//         Console.WriteLine($"Исходный массив: [{string.Join("; ", array)}]");
//         Console.WriteLine($"Исходный массив: [{string.Join("; ", arrays.ArrRev(array))}]");
//         break;
//     }
//     else 
//         Console.WriteLine("Введенно некорректное значение или 0!\nВведите корректные данные!");
// }

while (true)
{
    Console.WriteLine("Введите размер массива: ");
    int size;
    bool isNum = int.TryParse(Console.ReadLine(), out size);
    int[] array = arrays.ArrayCreation(size);
    if (isNum && size != 0)
    {
        Console.WriteLine($"Исходный массив: [{string.Join("; ", array)}]");
        Console.WriteLine($"Исходный массив: [{string.Join("; ", arrays.RevPair(array))}]");
        break;
    }
    else 
        Console.WriteLine("Введенно некорректное значение или 0!\nВведите корректные данные!");
}