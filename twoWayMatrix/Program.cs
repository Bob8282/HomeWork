using Matrix_00;

// //Задача 1: Напишите программу, которая на вход 
// //принимает позиции элемента в двумерном массиве, 
// //и возвращает значение этого элемента или же указание, 
// //что такого элемента нет.

// int[,] matrix = Matrix.CreateMatrix (3, 4, 0, 100);
// Matrix.PrintMatrix(matrix);
// Console.WriteLine("Введите номер строки: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите номер столбца: ");
// int column = Convert.ToInt32(Console.ReadLine());
// Console.Write (Matrix.ElementNumber(row, column, matrix));

// //Задача 2: Задайте двумерный массив. Напишите программу, 
// //которая поменяет местами первую и последнюю строку массива.

// Console.WriteLine("Введите количество строк: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов: ");
// int column = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Максимальное значение: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = Matrix.CreateMatrix (row, column, minValue, maxValue);
// Matrix.PrintMatrix(matrix);
// Matrix.RowsChange(matrix);
// Console.WriteLine("Результат: ");
// Matrix.PrintMatrix(matrix);
// Console.WriteLine($"{matrix[matrix.GetLength(0)-1, matrix.GetLength(1)-1]}");

// Задача 3: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
Console.WriteLine("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Максимальное значение: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[,] matrix = Matrix.CreateMatrix (row, column, minValue, maxValue);
Matrix.PrintMatrix(matrix);
Console.WriteLine($"Номер строки с минимальной суммой: {Matrix.MinimalSum(matrix)}");

// // Задача 4*(не обязательная): Задайте двумерный массив из целых чисел. 
// // Напишите программу, которая удалит строку и столбец, на пересечении 
// // которых расположен наименьший элемент массива. 
// // Под удалением понимается создание нового двумерного массива без строки и столбца

// int[,] matrix = Matrix.CreateMatrix (4, 4, 0, 10);
// Matrix.PrintMatrix(matrix);
// Console.WriteLine($"Минимум [{String.Join(", ", Matrix.minIndexSearch(matrix))}]");
// Matrix.PrintMatrix(Matrix.StringDel (matrix, Matrix.minIndexSearch(matrix)));
