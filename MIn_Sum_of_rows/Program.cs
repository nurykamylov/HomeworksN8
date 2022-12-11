/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] array = new int[,] {{1, 4, 7, 2},
                           {5, 9, 2, 3},
                           {8, 4, 2, 4},
                           {5, 2, 6, 7}};

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

int MinSumofRowsOfArry(int[,] arr)
{
    int sum1 = 0;
    int sum2 = 0;
    int sum3 = 0;
    int sum4 = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        
         sum1 =+ arr[0,j];
    }

      for (int j = 0; j < arr.GetLength(1); j++)
    {
        
         sum2 =+ arr[1,j];
    }
      for (int j = 0; j < arr.GetLength(1); j++)
    {
        
         sum3=+ arr[2,j];
    }
      for (int j = 0; j < arr.GetLength(1); j++)
    {
        
         sum4=+ arr[3,j];
    }

    if(sum1<sum2 && sum1<sum2 && sum1<sum4) return 1;
    if(sum2<sum1 && sum2<sum3 && sum2<sum4) return 2;
    if(sum3<sum1 && sum3<sum2 && sum2<sum4) return 3;
    if(sum4<sum1 && sum4<sum2 && sum4<sum3) return 4;
    return-1;
}

PrintArray(array);

int a = MinSumofRowsOfArry(array);
System.Console.WriteLine("min row:"+a);