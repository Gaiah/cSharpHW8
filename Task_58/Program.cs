// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


void NewRandomMatrix (int[,]matrix)
{
    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {            
            matrix[i, j] = rand.Next(1, 6);
            System.Console.Write($"{matrix[i, j]}\t");                  
        }
        System.Console.WriteLine();
    }
}

void TwoMatrixProduct (int[,] matrix1, int[,] matrix2)                     // 1стрЭл1*1столбЭл1 + 1стрЭл2*1столбЭлем2....
{                                                                          // 1(1строка * 1 столбец),2(1строка * 2 столбец)... 
    int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)]; // допустим матрица1(4, 2)
    for (int i = 0; i < matrix1.GetLength(0); i++)                        // тогда цикл для 4
    {
        for (int ji = 0; ji < matrix2.GetLength(1); ji++)                 // ещё один цикл 4 для матрицы 3 
        {
            for (int ka = 0; ka < matrix2.GetLength(0); ka++)             // и цикл для 2
            {
                matrix3[i, ji] += matrix1[i, ka] * matrix2[ka, ji];                
            }System.Console.Write($"{matrix3[i, ji]}\t");
        }System.Console.WriteLine();
    }
}


System.Console.WriteLine("How many strings should there be in the first matrix?");
int str = int.Parse(Console.ReadLine()!);

System.Console.WriteLine("How many columns should there be in the first matrix?");
int col = int.Parse(Console.ReadLine()!);


int[,] firstMatrix = new int[str, col];
int[,] secondMatrix = new int[col, str];

System.Console.WriteLine("First matrix:");
NewRandomMatrix(firstMatrix);
System.Console.WriteLine("Second matrix:");
NewRandomMatrix(secondMatrix);
System.Console.WriteLine("Product of two matrix: ");
TwoMatrixProduct(firstMatrix, secondMatrix);