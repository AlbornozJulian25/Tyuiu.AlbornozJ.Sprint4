using Tyuiu.AlbornozJ.Sprint4.Task6.V7.Lib;
Console.OutputEncoding = System.Text.Encoding.UTF8;

DataService ds = new DataService();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");


var subjects = new string[] { "Математика", "Физика", "Химия", "Биология", "География", "История", "Экономика" };

Console.WriteLine("Исходный массив: ");
for (int i = 0; i <= subjects.Length - 1; i++)
{
    Console.WriteLine(subjects[i]);
}

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Количество элементов длинна которых > 8: ");
int nums = ds.Calculate(subjects);

Console.WriteLine(nums);
Console.ReadKey();