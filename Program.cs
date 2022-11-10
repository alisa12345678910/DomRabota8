// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
// каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Console.WriteLine("Введите количество строк");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] FillArray(int m, int n)
// {
//     int[,] array = new int[m,n];
//     for (int i=0; i<array.GetLength(0); i++)
// {
//     for (int j=0; j<array.GetLength(1); j++)
//     array[i, j] = new Random().Next(0, 30);
// }
//     return array;
// }

// void PrintArray(int[,] image)
// {
// for (int i = 0; i < image.GetLength(0); i++)
// {
// for (int j = 0; j < image.GetLength(1); j++)
// {
// Console.Write($"{image[i, j]} \t");
// }
// Console.WriteLine();
// }
// }


// int[,] Descending(int[,] array)
// {
//         int temp = 0;
//         for (int i = 0; i < array.GetLength(1) - 1; i++)
//         {
//             for (int j = array.GetLength(1) - 1; j > 0; j--)
//             {
//                  for (int k = 0; k < j; k++)
//                     {
//                         if (array[i, k] < array[i, k + 1])
//                         {
//                             temp = array[i, k];
//                             array[i, k] = array[i, k + 1];
//                             array[i, k + 1] = temp;
//                         }
//                     }
//             }           
//         }
// return array;
// }

// int[,] mas = FillArray(m,n);
// PrintArray(mas);
// Console.WriteLine();
// Descending(mas);
// PrintArray(mas);


// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
// суммой элементов: 1 строка


// Console.WriteLine("Введите количество строк");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] FillArray(int m, int n)
// {
//     int[,] array = new int[m,n];
//     for (int i=0; i<array.GetLength(0); i++)
// {
//     for (int j=0; j<array.GetLength(1); j++)
//     array[i, j] = new Random().Next(0, 30);
// }
//     return array;
// }

// void PrintArray(int[,] image)
// {
//     for (int i = 0; i < image.GetLength(0); i++)
//     {
//         for (int j = 0; j < image.GetLength(1); j++)
//         {
//             Console.Write($"{image[i, j]} \t");
//         }
//     Console.WriteLine();
//     }
// }

// void TheBiggestLine(int[,] array)
// {
//     int temp = 0;
//     int lineNum = 1;
//     int final = 1000000;
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 temp = temp + array[i,j];           
//             }
            
//         if (temp < final) 
//         { 
//             final = temp; 
//             lineNum = i + 1;
//         }  
//         temp = 0;             
//         }
// Console.WriteLine($"Наименьшая сумма {final} в строке {lineNum}");
// }

// int[,] mas = FillArray(m,n);
// PrintArray(mas);
// Console.WriteLine();
// TheBiggestLine(mas);


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Console.WriteLine("Введите количество строк");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int n = Convert.ToInt32(Console.ReadLine());



// int[,] FillArray(int m, int n)
// {
//     int[,] array = new int[m,n];
//     for (int i=0; i<array.GetLength(0); i++)
// {
//     for (int j=0; j<array.GetLength(1); j++)
//     array[i, j] = new Random().Next(0, 30);
// }
//     return array;
// }

// void PrintArray(int[,] image)
// {
//     for (int i = 0; i < image.GetLength(0); i++)
//     {
//         for (int j = 0; j < image.GetLength(1); j++)
//         {
//             Console.Write($"{image[i, j]} \t");
//         }
//     Console.WriteLine();
//     }
//      Console.WriteLine("");
// }

// int[,] MultiplyMatrix(int[,] A, int[,] B)
// {
//         int rA = A.GetLength(0);
//         int cA = A.GetLength(1);
//         int rB = B.GetLength(0);
//         int cB = B.GetLength(1);

// int[,] result = new int[rA, cB];

//         if (cA != rB)
//         {
//             Console.WriteLine("Матрицы не могут быть перемножены");
//         }
//         else
//         {
//             int temp = 0;

//             for (int i = 0; i < rA; i++)
//             {
//                 for (int j = 0; j < cB; j++)
//                 {
//                     temp = 0;
//                     for (int k = 0; k < cA; k++)
//                     {
//                         temp += A[i, k] * B[k, j];
//                     }
//                     result[i, j] = temp;
//                 }
//             }


//         }
// return result;
// }


// int[,] mat1 = FillArray(m,n);
// PrintArray(mat1);
// int[,] mat2 = FillArray(m,n);
// PrintArray(mat2);
// int[,] mat3 = MultiplyMatrix(mat1, mat2);
// PrintArray(mat3);


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Console.WriteLine("Введите X: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Y: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Z: ");
// int c = Convert.ToInt32(Console.ReadLine());


// int[,,] Fill3DArray(int a, int b, int c)
// {

// int[,,] array3D = new int[a, b, c];

//   int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
//   int  number;
//   for (int i = 0; i < temp.GetLength(0); i++)
//   {
//     temp[i] = new Random().Next(10, 100);
//     number = temp[i];
//     if (i >= 1)
//     {
//       for (int j = 0; j < i; j++)
//       {
//         while (temp[i] == temp[j])
//         {
//           temp[i] = new Random().Next(10, 100);
//           j = 0;
//           number = temp[i];
//         }
//           number = temp[i];
//       }
//     }
//   }
//   int count = 0; 
//   for (int x = 0; x < array3D.GetLength(0); x++)
//   {
//     for (int y = 0; y < array3D.GetLength(1); y++)
//     {
//       for (int z = 0; z < array3D.GetLength(2); z++)
//       {
//         array3D[x, y, z] = temp[count];
//         count++;
//       }
//     }
//   }
// return array3D;
// }

// void Print3DArray(int[,,] array3D)
// {
//   for (int i = 0; i < array3D.GetLength(0); i++)
//   {
//     for (int j = 0; j < array3D.GetLength(1); j++)
//     {
//       for (int k = 0; k < array3D.GetLength(2); k++)
//       {
//         Console.Write( $"{array3D[i,j,k]}({i},{j},{k}) ");
//       }
//       Console.WriteLine();
//     }
//   }
// }


// int[,,] test = Fill3DArray(a, b, c);
// Print3DArray(test);

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


// int[,] FillAsSpiralMatrix(int n)
// {

// int[,] matrix = new int[n, n];
// int temp = 1;
// int i = 0;
// int j = 0;

// while (temp <= matrix.GetLength(0) * matrix.GetLength(1))
// {
//   matrix[i, j] = temp;
//   temp++;
//   if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
//     j++;
//   else if (i < j && i + j >= matrix.GetLength(0) - 1)
//     i++;
//   else if (i >= j && i + j > matrix.GetLength(1) - 1)
//     j--;
//   else
//     i--;
// }
// return matrix;
// }

// void PrintMatrixArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       if (array[i,j] / 10 <= 0)
//       Console.Write($" {array[i,j]} ");

//       else Console.Write($"{array[i,j]} ");
//     }
//     Console.WriteLine();
//   }
// }

// int[,] test = FillAsSpiralMatrix(4);
// PrintMatrixArray(test);
