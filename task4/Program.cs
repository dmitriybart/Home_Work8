// Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента

void FillMatrixRandom (int[,,] matrix, int min, int max)
{
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (min <= max)
                {
                    matrix[i,j,k] = min;
                    min++;
                }
            }   
        }
    }
}
void PrintMatrix(int[,,] matrix)
{
   for (int i = 0; i < matrix.GetLength(0); i++)
    {   
        Console.WriteLine($"{i+1}-я плоскость трёхмерного массива: ");
        Console.WriteLine(" ");  
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.WriteLine($"Элемент на позиции [{i}, {j}, {k}]: {matrix[i,j,k]}");

            }
        Console.WriteLine(" ");
        }
    Console.WriteLine(" ");
    }
}
Console.Write("Введите число строк матрицы: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число столбцов матрицы: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число рядов матрицы: ");
int z = int.Parse(Console.ReadLine() ?? "0");


Console.WriteLine(" ");

if(m*n*z < 100)
{
    int[,,] tripleArray = new int [m,n,z];
    FillMatrixRandom(tripleArray, 10, 99);
    PrintMatrix(tripleArray);
}
else Console.WriteLine($"Количество ячеек которое вы задали равно: {m*n*z}, что больше возможнности заполнить " 
+"трехмерный массив неповторяющимися элементами в интервале от 10 до 99, что являются двузначными числами ");