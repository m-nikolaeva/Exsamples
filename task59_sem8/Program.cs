// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.

Console.WriteLine("Введите число строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] mtx = CreateMatrixRandomInt(m, n, -9, 9);

Console.WriteLine("Исходная матрица:");
PrintMatrix(mtx);

Console.WriteLine(" матрица:");
int[,] newMtx = RemoveMinCrossover(mtx);

PrintMatrix(newMtx);

static int[,] RemoveMinCrossover(int[,] matrix)
{
	(int rowOfMin, int colOfMin) = FindMin(matrix);

	int rowsCount = matrix.GetLength(0);
	int colsCount = matrix.GetLength(1);
	int[,] result = new int[rowsCount - 1, colsCount - 1];

	for (int row = 0; row < rowsCount; ++row)
	{
		for (int col = 0; col < colsCount; ++col)
		{
			if (row == rowOfMin || col == colOfMin)
				continue;

			int newRow = row < rowOfMin ? row : row - 1;
			int newCol = col < colOfMin ? col : col - 1;
			result[newRow, newCol] = matrix[row, col];
		}
	}

	return result;
}

static (int row, int col) FindMin(int[,] matrix)
{
	int rowsCount = matrix.GetLength(0);
	int colsCount = matrix.GetLength(1);

	int rowOfMin = 0;
	int colOfMin = 0;
	int minValue = matrix[0, 0];

	for (int row = 0; row < rowsCount; ++row)
	{
		for (int col = 0; col < colsCount; ++col)
		{
			int currentValue = matrix[row, col];
			if (currentValue < minValue)
			{
				rowOfMin = row;
				colOfMin = col;
				minValue = currentValue;
			}
		}
	}

	return (rowOfMin, colOfMin);
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