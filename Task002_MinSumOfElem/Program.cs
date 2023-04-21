//  Задайте прямоугольный двумерный массив. Напишите программу, 
//  которая будет находить строку с наименьшей суммой элементов.

int Read(string arg)
{
    System.Console.Write($"Enter {arg}: ");
    int a = int.Parse(Console.ReadLine());
    return a;
}

int[,] CreateArray()
{
    System.Console.WriteLine("Enter the size of matrix: ");
    int m = Read("count of strings in the matrix");
    int n = Read("count of columns in the matrix");
    int[,] matrix = new int[m, n];
     
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
    System.Console.WriteLine();
    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + " ");
         
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

void SumOfElems(int[,] matrix)
{
    int[] sum = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum[i] += matrix[i, j];
        }
    }

    int count = 1;
    int min = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int summ = 0;
        System.Console.Write($"Result of sum in the {count} string = ");
        count++;
        System.Console.WriteLine(summ += sum[i]);
        if(min == 0) min = summ;
        else
        {
            if(min > summ) min = summ;
        }
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"Min sum of elements in your strings = {min}");
}

int[,] array = CreateArray();
PrintArray(array);
SumOfElems(array);
