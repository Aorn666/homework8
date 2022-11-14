// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


void InputMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = new Random().Next(10, 100);
                Console.Write(matrix[i, j , k] + " (" + i + "," + j + "," + k + ") " );

            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
Console.Clear();
Console.Write("Введите кол-во строк, столбцов и глубины: ");
string[] num = Console.ReadLine().Split(' ');
int n = int.Parse(num[0]);
int m = int.Parse(num[1]);
int w = int.Parse(num[2]);
int[,,] matrix = new int[n, m, w];
Console.WriteLine("Начальный массив: \n");
InputMatrix(matrix);