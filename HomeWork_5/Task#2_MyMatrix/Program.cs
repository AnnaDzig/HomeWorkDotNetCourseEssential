using System.Text;

class MyMatrix
{
    private int[,] matrix;

    public MyMatrix(int rows, int columns)

    { 
        matrix = new int[rows, columns]; 
    
    }

    public void Resize(int newRows, int newColumns)
    {
        int[,] newMatrix = new int[newRows, newColumns];

        for (int i = 0; i < Math.Min(matrix.GetLength(0), newRows); i++) {
            for (int j = 0; j < Math.Min(matrix.GetLength(1), newColumns); j++)
            {
                newMatrix[i, j] = matrix[i, j];
            }
        }

        matrix = newMatrix;
    }

    public void Display()
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
        public int[,] GetSubMatrix(int subRows, int subColumns)
        {
            int[,] subMatrix = new int[subRows, subColumns];

            for (int i = 0; i < subRows; i++)
            {
                for (int j = 0; j < subColumns; j++)
                {
                    if (i < matrix.GetLength(0) && j < matrix.GetLength(1))
                    {
                        subMatrix[i, j] = matrix[i, j];
                    }
                    else
                    {
                        subMatrix[i, j] = 0; 
                    }
                }
            }

            return subMatrix;
        }

        public void DisplaySubMatrix(int subRows, int subColumns)
        {
            int[,] subMatrix = GetSubMatrix(subRows, subColumns);

            for (int i = 0; i < subRows; i++)
            {
                for (int j = 0; j < subColumns; j++)
                {
                    Console.Write(subMatrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        private void FillMatrix()
        {
            Random random = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(1, 101); 
            }
        }
    }

    class Program
    {
        static void Main()
        {

            Console.OutputEncoding = Encoding.UTF8;
            // 4x5
            MyMatrix myMatrix = new MyMatrix(4, 5);
            Console.WriteLine("Початкова матриця:");
            myMatrix.Display();

            // 2. Зміна розміру матриці
            Console.WriteLine("\nМатриця після зміни розміру на 3x3:");
            myMatrix.Resize(3, 3);
            myMatrix.Display();

            //  2x2
            Console.WriteLine("\nПідматриця 2x2:");
            myMatrix.DisplaySubMatrix(2, 2);

            // 4.  5x5 
            Console.WriteLine("\nПідматриця 5x5 (розмір більший за матрицю):");
            myMatrix.DisplaySubMatrix(5, 5);

            Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
            Console.ReadKey();
        }


    }



}