// Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника

int factorial(int a)
{
  int i, b =1 ;
  for (i = 1 ; i<= a;i++ )
      b*=i;
      return b;
}
Console.Clear();
Console.Write("Введите число в основании треугольника Паскаля: ");
int a = Convert.ToInt32(Console.ReadLine());
int i,c;

for ( i = 0; i < a; i++)
{
    for ( c = 0; c <= (a-i); c++)
    {
        Console.Write(" ");
    }
    for ( c = 0; c <=i; c++)
    {
        Console.Write(" ");
        Console.Write(factorial(i) / (factorial(c) * factorial(i-c)));
    }
    Console.WriteLine();
}