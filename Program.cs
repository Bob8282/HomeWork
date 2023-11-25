// // Задание №1
// // Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// // Найдите количество элементов массива, 
// // значения которых лежат в отрезке [20,90].
// //не очень понял включительно ли 90, сделал включительно
// using System.Collections;

// int[] array = new int [10];
// int searchNumber = 0;
// for (int i = 0; i < 10; i++)
// {
//     array[i]= new Random().Next(1, 101);
//     if (array[i] >= 20 && array[i] <= 90)
//     searchNumber +=1;
// }
// Console.WriteLine ($"Заданный массив: [{string.Join("; ", array)}]");
// Console.WriteLine (searchNumber);

// //Задание №2
// // Задайте массив на 10 целых чисел. Напишите программу, 
// // которая определяет количество чётных чисел в массиве.
// int[] array = new int[10];
// int counter = 0;
// for (int i = 0; i < 10; i++)
// {
//     array[i] = new Random().Next(101);
    
//     if (array[i] % 2 == 0)
//         counter += 1;
// }
// Console.WriteLine($"Заданный массив: [{string.Join("; ", array)}]");
// Console.WriteLine(counter);

// // //Задание №3
// // Задайте массив из вещественных чисел с ненулевой дробной частью. 
// // Найдите разницу между максимальным и минимальным элементов массива.
// Console.Write ("Введите размер массива: ");
// int size = Convert.ToInt32 (Console.ReadLine());
// double[] array = new double[size];
// double max;
// double min;
// for (int i = 0; i < size; i++)
// {
//     // array[i] = Convert.ToDouble(new Random().Next(11, 101) / 10.0);
//     array[i] = Math.Round(new Random().NextDouble() * new Random().Next(1001), 2);
// }
// max = array[0];
// min = array[0];
// for (int i = 0; i<size; i++)
// {
//         if (array[i] > max)
//             max = array[i];
//         else if (array[i] < min)
//             min = array[i];
// }
// Console.WriteLine($"Заданный массив: [{string.Join("; ", array)}]");
// Console.WriteLine($"Максимум: {max}, минимум: {min}");
// Console.WriteLine($"Разница: {max - min}");