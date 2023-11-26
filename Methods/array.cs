
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
    }
}