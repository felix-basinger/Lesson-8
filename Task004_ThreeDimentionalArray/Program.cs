//  Задайте две матрицы. Напишите программу, 
//  которая будет находить произведение двух матриц.
 
int Read(string arg)
{
    System.Console.Write($"Enter {arg}: ");
    int a = int.Parse(Console.ReadLine());
    return a;
}

int[,,] CreateArray()
{
    System.Console.WriteLine("Enter the size of matrix: ");
    int m = Read("the first measurement of matrix");
    int n = Read("the second measurement of matrix");
    int s = Read("the third measurement of matrix");
    int[,,] matrix = new int[m, n, s];
     
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < s; k++)
            {
                 matrix[i, j, k] = new Random().Next(1, 10);
            }
        }
    }
    System.Console.WriteLine();
    return matrix;
}

void PrintArray(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                System.Console.Write(matrix[i, j, k] + $"({i},{j},{k})" + " ");
            }
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int[,,] array = CreateArray();
PrintArray(array);