namespace Recursive_00
{
    public class Recursive
    {

        public static string PrintNumbers (int start, int end)
        {
            if (start == end) return start.ToString();
            return start + " " + PrintNumbers(start + 1, end);
        }

        public static int AkkermanFunction(int firstNumber, int secondNumber)
        {
            if (firstNumber == 0) return secondNumber + 1;
            else if (secondNumber == 0) return AkkermanFunction(firstNumber - 1, 1);
            else return AkkermanFunction(firstNumber-1, AkkermanFunction(firstNumber, secondNumber - 1));
        }

        public static int[] GenerateArray(int arrayLen, int minValue, int maxValue)
        {
            int[] array = new int[arrayLen];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = rand.Next(minValue, maxValue);
            return array;
        } 

        public static void ArrayReverseRecursive(int[] array, int i=1)
        {
            if (i > array.Length) return;

            else
            {
                Console.WriteLine($"Элемент №{i}: {array[array.Length - i]}");
                ArrayReverseRecursive(array, i += 1);
            }
        }
    }
}

