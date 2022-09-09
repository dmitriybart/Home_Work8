// В матрице чисел найти сумму элементов главной диагонали
int[,] CreateMatrix(int length, int width, int minimum, int maximum)
{
    int[,] matrix = new int[length, width];
    Random random = new Random();
    for(int i=0;i<matrix.GetLength(0);i++)
        for(int j=0;j<matrix.GetLength(1);j++)
            matrix[i,j] = random.Next(minimum,maximum);
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for(int i=0;i<matrix.GetLength(0);i++)
    {
        for(int j=0;j<matrix.GetLength(1);j++)
            Console.Write($"{matrix[i,j]}\t");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }

}
Console.Write("Enter amount of rows(строки) in matrix: ");
int rows = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Enter amount of columns(столбцы) in matrix: ");
int columns = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = CreateMatrix(rows,columns,0,10);
PrintMatrix(matrix);

if(rows == columns)
{
int sum = 0;
for(int k=0;k<matrix.GetLength(0);k++)
    {
        sum = sum + matrix[k,k];
    }
Console.WriteLine($"Сумма чисел главной диагонали равна: {sum}");
}
else Console.WriteLine("Главной диагонали нет в матрице !");
