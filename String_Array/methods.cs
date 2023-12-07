using System.Linq.Expressions;
using System.Runtime.Serialization.Formatters;

namespace CharArray_00
{
    class CharArray
    {
        // Создание массива из рандомных символов
    public static char[,] CreateCharMatrix(int rows, int columns)
        {
            char[,] result = new char[rows, columns];
            int number = 0;
            char[] letters = "abcdefghijklmnoparstuvwxyz".ToCharArray(); // Эту строку подсмотрел)))
            for (int i = 0; i< result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    number = new Random().Next(0, letters.Length - 1);
                    result[i, j] = letters[number];
                }
                number = 0;
            }
            return result;
        }
    // перевод массива в строку символов
    public static string StringFromMatrix(char[,] chars)
        {
            string resultString = string.Empty;
            char sign;
            for (int i = 0; i < chars.GetLength(0); i++)
            {
                for (int j = 0; j < chars.GetLength(1); j++)
                {
                    sign = chars [i, j];
                    resultString = resultString + sign;
                }
            }
            return resultString;
        }
    
    //Приведение символов к нижнему регистру
    public static string LowerString (string sourceString)
        {
            string result = string.Empty;
            char sign;
            foreach (var symbol in sourceString)
            {
                if (char.IsUpper(symbol))
                    sign = char.ToLower(symbol);
                else
                   sign = symbol;     
            result = result + sign;  
            }
            return result;     
        }

     public static void PrintMatrix (char[,] matr)
        {
                for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    Console.Write($"{matr[i, j]}\t");
                }
                Console.WriteLine();
            }
        }

        //Проверка на палиндром
    public static void PalindromCheck(string str)
        {
            string rts = string.Empty;
            for (int i = str.Length - 1; i >= 0; i--)
                {
                    rts = rts + str[i];
                }
            if (rts == str)
                Console.WriteLine($"Строка {str} является палиндромом");
            else
                Console.WriteLine($"Строка {str} не является палиндромом");
        }
    }
}