//Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.


Console.WriteLine("Введите количество строк в массиве: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов в массиве: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("------------------");

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

void SelectionSort(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, j] < array[i, k])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;

                }
            }
        }

    }
}

// PrintArray(Mass);

FillArray(Mass);
PrintArray(Mass);

SelectionSort(Mass);
PrintArray(Mass);


