/*
Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] array1 = new int[,] {{2,4},
                            {3,2}};

int[,] array2 = new int[,] {{3,4},
                            {3,3}};

int [,] CompositionOfArrays(int[,] arr1, int[,] arr2)
{
    int [,] arr3 = new int[arr1.GetLength(0),arr2.GetLength(1)];

    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            for (int k = 0; k < arr2.GetLength(1); k++)
            {
               arr3[i,j] += arr1[i,k]*arr2[k,j];
            }
        }
    }
    return arr3;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

PrintArray(array1);
System.Console.WriteLine();
PrintArray(array2);
System.Console.WriteLine();

int[,] array3 = CompositionOfArrays( array1,array2);
PrintArray(array3);