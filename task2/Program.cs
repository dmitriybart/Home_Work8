// Найти произведение двух матриц
void FillMatrixRandom (int[,] matrix, int min, int max)
{
    var random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = random.Next(min,max+1);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}\t");

        }
        Console.WriteLine(" ");
        Console.WriteLine(" ");
    }
    
}

Console.Write("Введите число строк 1-ой матрицы: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число столбцов 1-ой матрицы: ");
int n = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine(" ");

int[,] firstDoubleArray = new int [m,n];
FillMatrixRandom(firstDoubleArray, 1, 10);
PrintMatrix(firstDoubleArray);
Console.WriteLine(" ");

Console.Write("Введите число строк 2-ой матрицы: ");
int p = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число столбцов 2-ой матрицы: ");
int t = int.Parse(Console.ReadLine() ?? "0");

int[,] secondDoubleArray = new int [p,t];
FillMatrixRandom(secondDoubleArray, 1, 10);
PrintMatrix(secondDoubleArray);
Console.WriteLine(" ");
int sum = 0;
int[,] sumMatrix = new int [m,n];
if (m == t && n == t)
{
    for (int z = 0; z < secondDoubleArray.GetLength(0); z++)

        for (int k = 0; k < firstDoubleArray.GetLength(0); k++)
        {
            for (int l = 0; l < firstDoubleArray.GetLength(1); l++)
            {
                sum += firstDoubleArray[k,l] * secondDoubleArray[l,z];
            }
        sumMatrix[k,z] = sum;
        sum = 0;
        }
Console.WriteLine("Произведенеие 1-ой матрицы на 2-ую: ");
PrintMatrix(sumMatrix);
}
else Console.WriteLine("Введите одинаковое количество столбцов и строчек !");

