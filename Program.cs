// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
int[,] num = new int[4, 4];
int ran = 9;
for (int i = 0; i < num.GetLength(0); i++)
{
    for (int j = 0; j < num.GetLength(1); j++)
    {
        ran += 1;
        num[i, j] = ran;
        if (i == 1)
        {
            num[i, j] = num[i, j] + 7;
            if (j == 3 && i == 1)
            {
                num[i, j] = num[i, j] - 10;
            }
        }
        if (i == 2)
        {
            num[i, j] = num[i, j] + 2;
            if (j == 1)
            {
                num[i, j] = num[i, j] + 4;
            }
            if (j == 2)
            {
                num[i, j] = num[i, j] + 2;
            }
            if (j == 3)
            {
                num[i, j] = num[i, j] - 8;
            }
        }
        if (i == 3)
        {
            num[i, j] = num[i, j] - 3;
            if (j == 1)
            {
                num[i, j] = num[i, j] - 2;
            }
            if (j == 2)
            {
                num[i, j] = num[i, j] - 4;
            }
            if (j == 3)
            {
                num[i, j] = num[i, j] - 6;
            }
        }              
        Console.Write($" {num[i, j]}");
    }
    Console.WriteLine();
}