// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void NewRandomMatrix (int[,] matr)
{
    Random rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(1, 15);
            System.Console.Write($"{matr[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}


void ArrangeMatrix (int[,] matr1)
{
    for (int str = 0; str < matr1.GetLength(0); str++)
    {
        for (int col = 0; col < matr1.GetLength(1); col++)
        {
            int minPos = col;
            for (int j = col + 1; j < matr1.GetLength(1); j++)
            {
                if (matr1[str, j] < matr1[str, minPos])
                {
                    minPos = j;
                }
            }
            int temporary = matr1[str, col];
            matr1[str, col] = matr1[str, minPos];
            matr1[str, minPos] = temporary;
            System.Console.Write($"{matr1[str, col]}\t");
        }
        System.Console.WriteLine();
    }
}

int[,] matrix = new int[3,3];
NewRandomMatrix(matrix);
System.Console.WriteLine();
ArrangeMatrix(matrix);