//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void NewRandomMatrix (int[,] matr)
{
    Random rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(1, 20);
            System.Console.Write($"{matr[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}


void FindMinSumString (int[,] matrix1)
{   
    int sum = 0;   
    int minSum = 2147483647; //максимальное возможное значение инт
    int minString = 0;

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            sum += matrix1[i, j];            
        }
        
        if (sum < minSum)
        {
            minSum = sum;
            minString = i + 1;
        }
        sum = 0;
    }
    System.Console.WriteLine($"The lowest element sum string is the string #{minString} and its sum = {minSum} ");     
}


int[,] matrix = new int[6,3];
NewRandomMatrix(matrix);
FindMinSumString(matrix);