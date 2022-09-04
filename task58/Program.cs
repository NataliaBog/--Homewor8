/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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
			matr[i, j]= new Random().Next(1, 6); 
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
static int[,] ResultArray(int[,] matr1, int[,] matr2)
{
	int [,] result = new int [matr1.GetLength(0), matr2.GetLength(1)];

	for(int i = 0; i < matr1.GetLength(0); i++)  
	{
		for(int j = 0; j < matr2.GetLength(1); j++) 
		{
			for(int k = 0; k < matr2.GetLength(0); k++) 
			{
				result[i,j] += matr1[i, k] * matr2[k,j];
			}
			Console.Write($"{result[i, j]} " + "\t ");
		}
		Console.WriteLine();
	}
	return result;
}
static void Main(string[] args)
{
	Console.WriteLine();
	Console.Write("Введите число n = ");
	int n = int.Parse(Console.ReadLine());
	int[,] matrix1 = new int [n, n];
	int[,] matrix2 = new int [n, n];
		
	Console.WriteLine("Даны две матрицы: ");
	Console.WriteLine("Первая матрица = ");
	FillArray(matrix1);
	PrintArray(matrix1);
	Console.WriteLine("Вторая матрица = ");
	FillArray(matrix2);
	PrintArray(matrix2);	

	Console.WriteLine("Произведение двух матриц, результирующая матрица будет следующей:  ");
	ResultArray(matrix1, matrix2);
	Console.WriteLine();
}
}