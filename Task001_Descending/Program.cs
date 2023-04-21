// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива

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
    int[] sum = new int[n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}
    
void PrintArray(int[,] matrix)
{
    System.Console.WriteLine();
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

void SortString(int[,] matrix, int num)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int maxPosition;
        for (int j = i + 1; j < matrix.GetLength(1); j++)
        {
            if(matrix[num, i] < matrix[num, j])
            {
                maxPosition = matrix[num, i];
                matrix[num, i] = matrix[num, j];
                matrix[num, j] = maxPosition;
            }
        }
    }
}

void PrintDescending(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        SortString(matrix, i);
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + " ");
         
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();    
}

int[,] array = CreateArray();
PrintArray(array);
PrintDescending(array);
 