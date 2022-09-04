/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов: 1 строка/
*/

using System;
class Program
{
static void FillArray(int[,] matr)
{
	for(int i = 0; i < matr.GetLength(0); i++)  
	{
		for(int j = 0; j < matr.GetLength(1); j++) 
		{
			matr[i, j]= new Random().Next(1, 11); 
		}
	}
}
static void PrintArray(int[,] matr)
{
		for(int i = 0; i < matr.GetLength(0); i++)  
	{
			for(int j = 0; j < matr.GetLength(1); j++) 
		{
			Console.Write($"{matr[i, j]} " + "\t ");
		}
		Console.WriteLine();
	}
}
static void Main(string[] args)
{
	Console.WriteLine();
	Console.Write("Введите количество строк двумерной матрицы: m = ");
	int m = Convert.ToInt32(Console.ReadLine()); 
	Console.Write("Введите количество столбиков двумерной матрицы: n = ");
	int n = Convert.ToInt32(Console.ReadLine());

	int[,] matrix = new int [m, n];
	Console.WriteLine();
	Console.WriteLine("Задан массив: ");
	FillArray(matrix);
	PrintArray(matrix);

	int [] sum = new int [m];
	int index = 0;
	int min = sum[0];
	
	for(int i = 0; i < m; i++)
	{ 
		for(int j = 0; j < n; j++)
		{
			sum [i] += matrix[i,j];	
		}	
		Console.WriteLine($"Сумма элементов в {i+1} строке = {sum [i]}.");
		if (sum[i] < min) index = i; min = sum[index];
		
	}
	Console.WriteLine("Номер строки с наименьшей суммой элементов: {0} строка. ", index+1);
	Console.WriteLine();
}
}