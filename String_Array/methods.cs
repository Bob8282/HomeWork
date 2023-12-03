using System.Linq.Expressions;

namespace CharArray_00
{
    class CharArray
    {
    public static char[,] CreateCharMatrix(int rows, int columns)
        {
            char[,] result = new char[rows, columns];
            int number = 0;
            char[] letters = "abcdefghijklmnoparstuvwxyz".ToCharArray();
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



    }
}