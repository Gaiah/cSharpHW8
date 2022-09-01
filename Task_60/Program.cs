// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2


void ThreeDimensArray (int[,,] cube)
{
    int num = 10;
    for (int k = 0; k < cube.GetLength(0); k++)
    {
        num += 5;
        for (int j = 0; j < cube.GetLength(1); j++)
        {
            num += 3;
            for (int i = 0; i < cube.GetLength(2); i++)
            {   
                num += 9;
                cube[k, i, j] = num;     
                System.Console.Write($"{k}, {i}, {j} - {cube[k, i, j]}\t");                 
            }
            System.Console.WriteLine();
        }
    }
}


int[,,] array = new int[2, 2, 2];
ThreeDimensArray(array);
