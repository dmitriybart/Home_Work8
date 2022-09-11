// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.

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
Console.Write("Введите число строк массива: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число столбцов массива: ");
int n = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine(" ");

int[,] doubleArray = new int [m,n];
FillMatrixRandom(doubleArray, 0, 30);
PrintMatrix(doubleArray);

Console.WriteLine(" ");

int minNumber = doubleArray[0,0];
int minColumns = 0;
int minRows = 0;
for (int k = 0; k < doubleArray.GetLength(0); k++)
    {
        for (int l = 0; l < doubleArray.GetLength(1); l++)
        {
            if (doubleArray[k,l] < minNumber)
            {
                minNumber = doubleArray[k,l];
                minRows = k;
                minColumns = l;
            }
        }
    }
Console.WriteLine($"{minRows} {minColumns} {minNumber} ");
int[,] newDoubleArray = new int [m-1,n-1];
for (int z = 0; z < newDoubleArray.GetLength(0); z++)
    {
        for (int q = 0; q < newDoubleArray.GetLength(1); q++)
        {
            if (z == minRows) 
            { 
                newDoubleArray[z,q] = doubleArray[z+1,q];
            }
            if (q == minColumns) 
            {   
                newDoubleArray[z,q] = doubleArray[z,q+1];
            }
            else newDoubleArray[z,q] = doubleArray[z,q];
            
        }
    }
PrintMatrix(newDoubleArray);