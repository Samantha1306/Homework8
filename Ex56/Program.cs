// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

try
{
    Console.Write("Укажите, сколько строк будет в массиве (введите натуральное число): ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Укажите, сколько столбцов будет в массиве (введите натуральное число, количество столбцов не должно равняться количеству строк): ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    if (m == n)
        Console.WriteLine("Ошибка! Количество столбцов не должно равняться количеству строк.");
    else
    {
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

        int FindMinSumRow(int[,] matr)
        {
            int row = 0;
            int minsum = 0;
            for (int i = 0; i < matr.GetLength(1); i++)
            {
                minsum = minsum + matr[0, i];
            }

            for (int i = 1; i < matr.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    sum = sum + matr[i, j];
                }
                if (minsum > sum)
                {
                    minsum = sum;
                    row = i;
                }
            }
            return row;
        }
        FillArray(matrix);
        Console.WriteLine("Задан массив");
        PrintArray(matrix);
        Console.WriteLine();
        Console.Write($"Строка с наименьшей суммой элементов: {FindMinSumRow(matrix)}");
    }
}
catch
{
    Console.WriteLine("Ошибка! Введите натуральное число.");
}
