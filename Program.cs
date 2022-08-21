// показать двумерный массив размером mxn заполненный вещественными числами
Console.WriteLine("введите m строк");
int m = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("введите n столбцов");
int n= int.Parse(Console.ReadLine()??"0");
double[,]matrix=new double[m,n];

Random random = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = random.NextDouble() * 100; // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
        Console.Write("{0,6:F2}", matrix[i, j]);
    }
    Console.WriteLine();
}