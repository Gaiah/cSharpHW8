// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


void PrintM (int[,] array1)
{
    int numbers = 1;
    int verticalLine = 0;
    int horizLine = 0;

    for (int motor = 0; motor < 5; motor++)
    {
        while ( verticalLine < array1.GetLength(0))
        {
            for (horizLine = 0; horizLine < array1.GetLength(1); horizLine++)
            {
                array1[verticalLine, horizLine] = numbers;
                System.Console.Write(array1[verticalLine, horizLine]); 
                numbers++;               
            }
            System.Console.WriteLine();
        }
        while (horizLine < array1.GetLength(1))
        {
            for (horizLine = 0; horizLine < array1.GetLength(1); horizLine++)
            {
                array1[verticalLine, horizLine] = numbers;
                System.Console.Write(array1[verticalLine, horizLine]); 
                numbers++;               
            }
            System.Console.WriteLine();
        }
    }
}


//vertical = i = string = строка
//horizLine = j = column = столбец



// usNum = 9
// 001 _ _ _ _ _ _ _009             1    2     3     4     5     6     7     8     9                       
// *35 _ _ _ _ _ _ 42  _            32   33    34    35    36    37    38    39    10
// _ _ _ _ _ _ _ _    _             31    56   57    58    59    60    61    40    11
// _ _ _ _ _ _ _ _    _             30    55                           62    41    12                  
// _ _ _ _ _ _ _ _    _             29    54                           63    42    13        
// _ _ _ _ _ _ _ _    _             28    53                           64    43    14           
// _ _ _ _ _ _ _ _    _             27    52          68    67    66   65    44    15         
// _ _ _ _ _ _ _ _    _             26    51    50    49    48    47   46    45    16                 
// 027 _ _ _ _ _ _ _ 018            25    24    23    22    21    20   19    18    17   



int usNum = 3;
int matrixElements = usNum * usNum;
int[,] matrix = new int[usNum, usNum];
PrintM(matrix);



// // Напишите программу, которая заполнит спирально массив 4 на 4.
// // размер массива
// int leni = 7, lenj=9; 

// int d=1, i=0, j=0, maxj=lenj-1, maxi=leni-1, minj=0, mini=1;
// int[,] a = new int [leni,lenj];
// for (int counter = 0; counter < leni*lenj; counter ++) {
//     Console.WriteLine(i+ " "+j+ " counter=" + counter +" d=" + d);
//     a[i,j] = counter;
//     if (j==maxj && d==1) 
//     {
//         d=2;
//         maxj=maxj-1;
//     }
//     if (i==maxi && d==2) 
//     {
//         d=3;
//         maxi=maxi-1;
//     }
//     if (j==minj && d==3) 
//     {
//         d=4;
//         minj=minj+1;
//     }
//     if (i==mini && d==4) 
//     {
//         d=1;
//         mini=mini+1;
//     }
//     if (d==1) j=j+1;
//     if (d==2) i=i+1;
//     if (d==3) j=j-1;
//     if (d==4) i=i-1;
// }
// for (int k =0; k < a.GetLength(0); k++)
// {
//     for (int l = 0; l < a.GetLength(1); l++)
//     {
//         Console.Write(a[k,l]+ " ");
//         if (a[k,l] < 10) Console.Write(" ");
//     }
//     Console.WriteLine();    
// }