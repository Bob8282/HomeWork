using Matrix_00;

// Задача 1: Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

int[,] matrix = Matrix.CreateMatrix (3, 4, 0, 100);
int row = Convert.ToInt32(Console.ReadLine());
int column = Convert.ToInt32(Console.ReadLine());
Console.Write (Matrix.ElementNumber(row, column, matrix));

// Задача 2: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.
