// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

    Console.Write("Укажите длину трехмерного массива 1 (введите натуральное число): ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Укажите длину трехмерного массива 2 (введите натуральное число): ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Укажите длину трехмерного массива 3 (введите натуральное число): ");
    int o = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int[,,] matrix = new int[m, n, o];

    void FillArrayRandom(int[,,] matr)
    {
        int[] temp = new int[matr.GetLength(0) * matr.GetLength(1) * matr.GetLength(2)];
        int a;
        for (int b = 0; b < temp.GetLength(0); b++)
        {
            temp[b] = new Random().Next(10, 100);
            a = temp[b];
            if (b >= 1)
            {
                for (int c = 0; c < b; c++)
                {
                    while (temp[b] == temp[c])
                    {
                        temp[b] = new Random().Next(10, 100);
                        c = 0;
                        a = temp[b];
                    }
                    a = temp[b];
                }
            }
        }
        int count = 0;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                for (int k = 0; k < matr.GetLength(2); k++)
                {
                    matr[i, j, k] = temp[count];
                    count++;
                }
            }
        }
    }

    void PrintArrayIndexes(int[,,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                for (int k = 0; k < matr.GetLength(1); k++)
            {
                Console.Write($"{matr[i, j, k]} ({i},{j},{k}) \t");
            }
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }


    FillArrayRandom(matrix);
    Console.WriteLine("Задан массив");
    PrintArrayIndexes(matrix);
    Console.WriteLine();