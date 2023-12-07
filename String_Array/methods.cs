using System.Linq.Expressions;
using System.Runtime.Serialization.Formatters;

namespace CharArray_00
{
    class CharArray
    {
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
    public static string StringReverse(string stringSource)
        {
            //string[] array = stringSource.Split(" ");
            string revStr = string.Empty;
            int count = 0;
            for (int i = 0; i < stringSource.Length; i++)
            {
                if (stringSource[i] == ' ')
                {
                    count +=1;
                }
            }
            string[] strArr = new string[count];
            
            string sign = string.Empty;
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < stringSource.Length; j++)
                    if (stringSource[j] != ' ')
                        sign = sign + stringSource[j];
                    else 
                        continue;
                strArr[i] = sign;
            }

            
            return revStr;
        }      
    }
}