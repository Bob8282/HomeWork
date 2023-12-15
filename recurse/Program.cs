using System.Linq.Expressions;
using Recursive_00;
// Задача 1: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

// Console.WriteLine ("Введите начальное число M: ");
// int start = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите начальное число N: ");
// int end = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Recursive.PrintNumbers (start, end));

// Задача 2: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// Console.WriteLine ("Введите начальное число M: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите начальное число N: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());
// int accermanFunc = Recursive.AkkermanFunction(firstNumber, secondNumber);
// Console.WriteLine(accermanFunc);


// Задача 3: Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.


Console.WriteLine ("Введите длину массива");
int arrayLen = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите минимальное значение массива");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите максимальное значение массива");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[] array = Recursive.GenerateArray(arrayLen, minValue, maxValue);
Console.WriteLine(String.Join("; ", array));
Recursive.ArrayReverseRecursive(array);
//  public static void ArrayReverseRecursive(int[] array, int i = 0)
//         {
//             if (i < array.Length - 1)
//                 Console.WriteLine(array[array.Length - i]);
//                 ArrayReverseRecursive(array, i++);
//         }
