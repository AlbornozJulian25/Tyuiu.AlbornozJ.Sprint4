using Tyuiu.AlbornozJ.Sprint4.Task0.V8.Lib;
Console.OutputEncoding = System.Text.Encoding.UTF8;

DataService ds = new DataService();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");


int[] numsArray = { 1, 6, 3, 7, 5, 4, 2, 7, 8, 9 };

Console.WriteLine("Исходный массив: ");
for (int i = 0; i <= numsArray.Length - 1; i++)
{
    Console.WriteLine(numsArray[i]);
}

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");


int result = ds.GetMultEvenArrEl(numsArray);
Console.WriteLine("Произведение четных элементов массива = " + result);

Console.WriteLine();
Console.ReadKey();
