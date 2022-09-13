// Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника
int Factorial(int n)
{
    int i, x = 1;
    for (i = 1; i <= n; i++)
    {
        x *= i;
    }
    return x;
}

Console.Write("Введите число строк: ");
int n = int.Parse(Console.ReadLine() ?? "0");
for (int i = 0; i < n; i++)
{
    for (int c = 0; c <= (n - i); c++) 
    {
        Console.Write(" "); 
    }
    for (int k = 0; k <= i; k++)
    {
        Console.Write(" "); 
        Console.Write(Factorial(i) / (Factorial(k) * Factorial(i - k))); 
    }
    Console.WriteLine();
    Console.WriteLine(); 
}
