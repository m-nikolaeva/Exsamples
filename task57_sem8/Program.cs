// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных

Console.WriteLine("Введите число строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] mtx = CreateMatrixRandomInt(m, n, -9, 9);

Console.WriteLine("Исходная матрица:");
PrintMatrix(mtx);

int[,] frequencies = GetFreq(mtx, out int uniqCount);
Console.WriteLine($"Таблица: значения - частота (количество уникальных = {uniqCount}):");
PrintMatrix(frequencies);

static int[] ToSortedArray(int[,] matrix)
{
	int rowsCount = matrix.GetLength(0);
	int colsCount = matrix.GetLength(1);
	int num = rowsCount * colsCount;
	int[] array = new int[num];

	int n = 0;
	for (int row = 0; row < rowsCount; ++row)
	{
		for (int col = 0; col < colsCount; ++col)
		{
			array[n++] = matrix[row, col];
		}
	}

	Array.Sort(array);
	return array;
}



static int[,] GetFreq(int[,] matrix, out int uniqueItemsCount)
{
	int[] array = ToSortedArray(matrix);
	uniqueItemsCount = array.Distinct().Count();

	int[,] freq = new int[2, uniqueItemsCount];

	int currentIdx = 0;
	freq[0, currentIdx] = array[0];

	for (int i = 0; i < array.Length; ++i)
	{
		if (array[i] == freq[0, currentIdx])
			freq[1, currentIdx]++;
		else
		{
			currentIdx++;
			freq[0, currentIdx] = array[i];
			freq[1, currentIdx] = 1;
		}
	}

	return freq;
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
