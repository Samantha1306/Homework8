// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

try
{
    Console.WriteLine("Укажите, сколько строк будет в массиве (введите натуральное число): ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Укажите, сколько столбцов будет в массиве (введите натуральное число): ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int[,] matrix = new int[m, n];

    void FillArray(int[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                matr[i, j] = new Random().Next(0, 10);
            }
        }
    }

    void PrintArray(int[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                Console.Write($"{matr[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    void SortToMinimal(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(1) - 1; k++)
                {
                    if (array[i, k] < array[i, k + 1])
                    {
                        int temp = array[i, k + 1];
                        array[i, k + 1] = array[i, k];
                        array[i, k] = temp;
                    }
                }
            }
        }
    }

    FillArray(matrix);
    Console.WriteLine("Задан массив");
    PrintArray(matrix);
    Console.WriteLine();
    Console.WriteLine("После построчной сортировки чисел от макисмального к минимальному получился следующий массив");
    SortToMinimal(matrix);
    PrintArray(matrix);
}
catch
{
    Console.WriteLine("Ошибка! Введите натуральное число.");
}
