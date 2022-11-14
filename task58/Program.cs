// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}
void OrderMatrix(int[,] matrixA , int[,] matrixB)
{
    int [,] matrixSum = new int [matrixA.GetLength(0),matrixA.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixA.GetLength(1); j++)
        {
            matrixSum[i,j] = matrixA[i,j] * matrixB[i,j];
            Console.Write($"{matrixSum[i, j]} \t");
        }
        Console.WriteLine();
    }
}


Console.Clear();
Console.Write("Введите кол-во строк и столбцов: ");
string[] num = Console.ReadLine().Split(' ');
int n = int.Parse(num[0]);
int m = int.Parse(num[1]);
int[,] matrixA = new int[n, m];
int[,] matrixB = new int[n, m];
Console.WriteLine("Начальный массив 1: \n");
InputMatrix(matrixA);
Console.WriteLine("Начальный массив 2: \n");
InputMatrix(matrixB);
Console.WriteLine("Произведение матриц: \n");
OrderMatrix(matrixA , matrixB);
