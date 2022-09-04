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
static void SelectionSort(int [,] array)
{
	for(int i = 0; i < array.GetLength(0); i++)
	{ 
			for(int k= 0; k < array.GetLength(1); k++)
		{
			int maxPosition = 0;
			for(int j = k+1; j < array.GetLength(1); j++)
			{
				if(array[i,j] > array[i,k])
				{
				maxPosition = j;
				int temporary = array[i,j];	
				array[i,j] = array[i,k];
				array[i, k] = temporary;
				}	
			}	
		}
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
		
	Console.WriteLine("Упорядочены по убыванию элементы каждой строки двумерного массива: ");
	SelectionSort(matrix);
	PrintArray(matrix);
}
}
