namespace Matrix_00
{
    public class Matrix
    {
        public static int[,] CreateMatrix(int rows, int columns, int min, int max)
        {
            int[,] matrix = new int[rows, columns];
            Random rand = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix [i, j] = rand.Next(min, max+1);
                }
            }
            return matrix;
        }

        public static void PrintMatrix (int[,] matr)
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


        public static int ElementNumber(int row, int column, int[,] matr)
        {
            int result = 0;
            if (row < matr.GetLength(0) && column < matr.GetLength(1))
            {
                result = matr[row, column];
                return result;
            }
            else 
                Console.Write ("Такого элемента не существует");
            return matr[row, column];

        }
        public static int[,] RowsChange(int[,] matr)
        {
            // int [,] newMatrix = new int[matr.GetLength(0), matr.GetLength(1)];
            int temp;
        for (int j = 0; j < matr.GetLength(1); j++)
            {
              temp = matr[0, j];
              matr[0,j]= matr[matr.GetLength(0)-1, j];
              matr[matr.GetLength(0)-1, j] = temp;
            }
        return matr;
        }

        // public static int MinSum(int[,] matr)
        // {   int sum = 0;
        //     int minSum = 0;
        //     for (int i = 0; i < matr.GetLength(0); i++)
        //     {
        //         for (int j = 0; j < matr.GetLength(0); j++)
        //         {
        //             sum[i]+=matr[i, j];
        //         }
        //     }
        // }

        public static int[] minIndexSearch(int[,] matr)
        {
            int[] resMatrix = new int[2];
            int min = matr[0, 0];
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for(int j = 0; j < matr.GetLength(1); j++)
                {
                    if (min > matr[i, j])
                        min = matr[i, j];
                        resMatrix[0] = i;
                        resMatrix[1] = j;
                }
                
            }
            return resMatrix;
        }

        public static int[,] StringDel(int[,] matr, int[] resMatrix)
        {
            int[,] result = new int[matr.GetLength(0)-1, matr.GetLength(1)-1];
            int row = 0;
            int column = 0;
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                if (i == resMatrix[0]) continue;
                for (int j = 0; j < matr.GetLength(1); j++)
                {                   
                    if (j == resMatrix[1]) continue;
                    result[row, column] = matr [i, j];
                    column ++;
                }
                column = 0;
                row ++;

            }
            return result;
        }
    }
    
}