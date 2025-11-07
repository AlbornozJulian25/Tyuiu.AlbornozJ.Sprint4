using Tyuiu.AlbornozJ.Sprint4.Task7.V9.Lib;
Console.OutputEncoding = System.Text.Encoding.UTF8;

int rows = 3;
int columns = 3;
int[,] matrix = new int[rows, columns];
string str = "864299753";

DataService ds = new DataService();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int index = 0;
Console.WriteLine("\nМассив: ");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{str[index]} \t");
        index++;
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

int res = ds.Calculate(rows, columns, str);
Console.WriteLine("Количество четных чисел = " + res);
Console.ReadKey();