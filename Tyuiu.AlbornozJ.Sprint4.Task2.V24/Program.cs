using Tyuiu.AlbornozJ.Sprint4.Task2.V24.Lib;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Random rnd = new Random();
DataService ds = new DataService();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите количество элементов массива: ");
int len = Convert.ToInt32(Console.ReadLine());

int[] numsArray = new int[len];
for (int i = 0; i <= len - 1; i++)
{
    numsArray[i] = rnd.Next(4, 9);
}

Console.WriteLine("Массив: ");
for (int i = 0; i <= len - 1; i++)
{
    Console.Write(numsArray[i] + "\t");
}

Console.WriteLine();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

int res = ds.Calculate(numsArray);

Console.WriteLine("Сумма нечетных элементов массива = " + res);
Console.ReadKey();