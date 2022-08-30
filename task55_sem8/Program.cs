// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

Console.WriteLine("Введите число строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] mtx = CreateMatrixRandomInt(m, n, -9, 9);

Console.WriteLine("Исходная матрица:");
PrintMatrix(mtx);

Console.WriteLine("Способ 1: Новая перевёрнутая:");

int[,]? transposedMtx = Transpose(mtx);
if (transposedMtx != null)
{
	PrintMatrix(transposedMtx);
}
else
{
	Console.WriteLine("Невозможно заменить столбцы на строки");
}

Console.WriteLine("Способ 2: Транспонированная исходная:");
if (TransposeV2(mtx))
{
	PrintMatrix(mtx);
}
else
{
	Console.WriteLine("Невозможно перевернуть исходную.");
}

static int[,]? Transpose(int[,] matrix)
{
	int rowsCount = matrix.GetLength(0);
	int colsCount = matrix.GetLength(1);

	if (rowsCount != colsCount)
		return null;

	int[,] transposed = new int[colsCount, rowsCount];

	for (int i = 0; i < rowsCount; ++i)
	{
		for (int j = 0; j < colsCount; ++j)
		{
			transposed[j, i] = matrix[i, j];
		}
	}

	return transposed;
}

static bool TransposeV2(int[,] matrix)
{
	int rowsCount = matrix.GetLength(0);
	int colsCount = matrix.GetLength(1);

	if (rowsCount != colsCount)
		return false;


	for (int i = 0; i < rowsCount; ++i)
	{
		for (int j = i + 1; j < colsCount; ++j)
		{
			SwapElements(matrix, i, j);
		}
	}

	return true;
}

static void SwapElements(int[,] matrix, int row, int col)
{
	var tmpItem = matrix[row, col];
	matrix[row, col] = matrix[col, row];
	matrix[col, row] = tmpItem;
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
