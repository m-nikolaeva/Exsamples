// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

Console.WriteLine("Введите число строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] mtx = CreateMatrixRandomInt(m, n, -9, 9);

Console.WriteLine("Исходная матрица:");
PrintMatrix(mtx);

Console.WriteLine("Модифицированная матрица:");
SwapFirstLastRows(mtx);
PrintMatrix(mtx);

Console.WriteLine();

static void SwapFirstLastRows(int[,] matrix)
{
	int lastRowIndex = matrix.GetLength(0) - 1;
	int colsCount = matrix.GetLength(1);

	for (int i = 0; i < colsCount; ++i)
	{
		int tmpItem = matrix[0, i];
		matrix[0, i] = matrix[lastRowIndex, i];
		matrix[lastRowIndex, i] = tmpItem;
	}
}

static int[,] CreateMatrixRandomInt(int rows, int cols, int min, int max)
{
	int[,] matrix = new int[rows, cols];

	Random rnd = new Random();
	max = max + 1;
	for (int row = 0; row < rows; ++row)
	{
		for (int col = 0; col < cols; ++col)
		{
			matrix[row, col] = rnd.Next(min, max);
		}
	}
	return matrix;
}

static T[,] PrintMatrix<T>(T[,] matrix, string format = "0") where T : struct, IFormattable
{
	int rowsLastIndex = matrix.GetLength(0) - 1;
	int colsLastIndex = matrix.GetLength(1) - 1;
	for (int row = 0; row <= rowsLastIndex; ++row)
	{
		Console.Write("[");
		for (int col = 0; col < colsLastIndex; ++col)
		{
			Console.Write($"{matrix[row, col].ToString(format, null),4}, ");
		}
		Console.WriteLine($"{matrix[row, colsLastIndex].ToString(format, null),4}]");
	}
	return matrix;
}