// Напишите программу, которая заполнит спирально массив 4 на 4.

void SpiralMatrix(int[,] matrix)
{
    int a = 1 , i = 0, j = 0 ;
    while (a <= matrix.GetLength(0) * matrix.GetLength(1))
    {
        matrix[i,j] = a;
        a++;
        if (i<=j+1 && i+j < matrix.GetLength(1)-1)
        j++;
        else if ( i<j && i+j >= matrix.GetLength(0)-1)
        i++;
        else if ( i>=j && i+j > matrix.GetLength(1)-1)
        j--;
        else 
        i--;
    }
    for ( i = 0; i < matrix.GetLength(0); i++)
    {
        for ( j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " \t");
        }
        Console.WriteLine();
    }
}



Console.Clear();
Console.Write("Введите кол-во строк и столбцов: ");
string[] num = Console.ReadLine().Split(' ');
int n = int.Parse(num[0]);
int m = int.Parse(num[1]);
int[,] matrix = new int[n, m];
Console.WriteLine("массив: \n");
SpiralMatrix(matrix);