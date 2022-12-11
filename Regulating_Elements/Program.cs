/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/


int[,] array = GetArray(3, 4);
PrintArray(array);
System.Console.WriteLine();

Console.WriteLine(RegulatingElements(array));

int [,] GetArray(int row, int col)
{
    int[,] array = new int[row,col];
    var rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(1,10);
        }
    }

    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] RegulatingElements(int [,] arr)
{
    for (int k = 0; k < arr.GetLength(0); k ++)
    {
         for (int i = 0; i <arr.GetLength(1) - 1; i++)
        {
    
            for (int j = 1; j < arr.GetLength(1)- 1 -i; i++)
            {
            if (arr[i,j] > arr[i+1,j+1]) 
            {
                int temp = arr[i,j];
                arr[i,j] = arr[i+1,j+1];
                arr[i+1,j+1] = temp;
            } 
            }    
        }
    
    }
    
   return arr;
}
