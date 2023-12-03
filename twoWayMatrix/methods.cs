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
        // public static int RowsChange(int[,] matr)
        // {
            
        //     if ()
        //         Console.Write (matr[row, column]);
        //     else 
        //         Console.Write ("Такого элемента не существует");

        // }
    }
    
}