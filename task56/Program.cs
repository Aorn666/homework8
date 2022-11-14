// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

void OrderMatrix(int[,] matrix)
{
    int min =1;
    int c = 0;
    int a = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            a+= matrix[i,j];
        }
        break;
    }
    int b = a;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        a = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           a+= matrix[i,j];
           
        }
        
        if (b>a)
        {
            b = a;
            c = min ;
        }
        min++;
    }
Console.Write(c);
}

Console.Clear();
Console.Write("Введите кол-во строк и столбцов: ");
string[] num = Console.ReadLine().Split(' ');
int n = int.Parse(num[0]);
int m = int.Parse(num[1]);
int[,] matrix = new int[n, m];
Console.WriteLine("Начальный массив: \n");
InputMatrix(matrix);
Console.WriteLine("Страка с наименьшей суммой элементов: \n");
OrderMatrix(matrix);
