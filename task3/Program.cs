//В прямоугольной матрице найти строку с наименьшей суммой элементов.

Console.WriteLine("Введите количество строк в массиве: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов в массиве: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("------------------");

if (a == b) Console.Write("Матрица квадратная! А нам нужна прямоугольная!");
else
{

    int[,] Mass = new int[a, b];

    void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    void FillArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(1, 10);
            }
        }
    }

    FillArray(Mass);
    PrintArray(Mass);

    int min = 100;
    int sum = 0;
    int st = 0;

    for (int i = 0; i < Mass.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < Mass.GetLength(1); j++)

        {
            sum = sum + Mass[i, j];
        }

        if (sum < min)
        {
            min = sum;
            st = i + 1;
        }
        Console.WriteLine(sum);
    }
    Console.WriteLine($"минимальное сумма элементов находится в строке {st}");
}
