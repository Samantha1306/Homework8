// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

try
{
    Console.Write("Укажите, сколько строк будет в матрице 1 (введите натуральное число): ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Укажите, сколько столбцов будет в матрице 1 (введите натуральное число): ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Укажите, сколько строк будет в матрице 2 (введите натуральное число): ");
    int o = Convert.ToInt32(Console.ReadLine());
    Console.Write("Укажите, сколько столбцов будет в матрице 2 (введите натуральное число): ");
    int p = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    if (n == o)
    {
        int[,] matrix1 = new int[m, n];
        int[,] matrix2 = new int[o, p];
        int[,] multmatrix = new int[m, p];
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
                    Console.Write($"{matr[i, j]} \t");
                }
                Console.WriteLine();
            }
        }

        void MatrixMultiplication(int[,] matrix1, int[,] matrix2)
        {
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    int sum = 0;
                    for (int k = 0; k < matrix1.GetLength(1); k++)
                    {
                        sum = sum + matrix1[i, k] * matrix2[k, j];
                    }
                    multmatrix[i, j] = sum;
                }
            }
        }
 
 
        FillArray(matrix1);
        Console.WriteLine("Матрица 1");
        PrintArray(matrix1);
        Console.WriteLine();
        FillArray(matrix2);
        Console.WriteLine("Матрица 2");
        PrintArray(matrix2);
        Console.WriteLine();
        MatrixMultiplication(matrix1, matrix2);
        Console.WriteLine($"Произведение матрицы 1 и матрицы 2");
        PrintArray(multmatrix);
    }
    else
        Console.WriteLine(
            "Ошибка! Количество столбцов матрицы 1 должно равняться количеству строк матрицы 2."
        );
}
catch
{
    Console.WriteLine("Ошибка! Введите натуральное число.");
}
