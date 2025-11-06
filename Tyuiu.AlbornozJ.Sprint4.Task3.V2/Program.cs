using Tyuiu.AlbornozJ.Sprint4.Task3.V2.Lib;
Console.OutputEncoding = System.Text.Encoding.UTF8;

int[,] matrix = new int[5, 5] { { 4, 3, 2, 8, 7 },
                                { 4, 6, 5, 5, 7 },
                                { 3, 8, 8, 3, 5 },
                                { 5, 7, 5, 4, 4 },
                                { 8, 8, 3, 7, 6 } };

int rows = matrix.GetUpperBound(0) + 1;
int columns = matrix.Length / rows;

DataService ds = new DataService();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Массив: ");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{matrix[i, j]} \t");
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
int res = ds.Calculate(matrix);

Console.WriteLine("Максимальный элемент в первой строке = " + res);
Console.ReadKey();
