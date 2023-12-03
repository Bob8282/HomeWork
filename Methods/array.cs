
using System.Reflection.Metadata.Ecma335;

namespace arrays_00
{
    public class arrays
    {
        
        public static int[] ArrayCreation(int size)
        {
            int[] array = new int [size];
            for (int i = 0; i < size; i++)
                 array[i] = new Random().Next(100, 1000);
            return array;
        }

        public static int EvenCounting(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                    count ++;
            }
            return count;
        }

        public static int[] ArrRev(int[] array)
        {   
            int[] arrRev = new int [array.Length];
            for(int j = 0, i = array.Length - 1; i >= 0; i--, j++)
                {
                    arrRev[j] = array [i];
                }
                return arrRev;
        }
        
        public static int[] RevPair(int[] array)
        {   
            int temp = 0;
            int[] arrRev = new int [array.Length];
            for(int j = 0, i = array.Length - 1; j < array.Length / 2; i--, j++)
                {
                    temp = array[j];
                    array[j] = array[i];
                    array[i] = temp;
                }
                return array;
        }
    }
}