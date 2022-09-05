int size = 3;
int[,] matrix = new int[size, size];
//elements = size * size;
Fill_Zero_Matrix(matrix);
GoNumeric(0, 0);
Print_Zero_Matrix(matrix);

void Fill_Zero_Matrix(int[,] matrix1)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            matrix1[i, j] = 0;
        }
        System.Console.WriteLine();
    }
}


void Print_Zero_Matrix(int[,] matrix2)
{
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j]);
        }
        System.Console.WriteLine();
    }
}



void GoNumeric(int rows, int cols)
{
    int num = 0;
    if (matrix[rows, cols] == 0)
    {
        matrix[0, 0] = num + 1;
        GoNumeric(rows, cols + 1);                 // ->                
        GoNumeric(rows + 1, cols);                 // down
        GoNumeric(rows, cols - 1);                 // <-     
        GoNumeric(rows - 1, cols);                 // up  
    }
}
