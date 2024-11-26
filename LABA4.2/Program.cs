int N = 4;
int[,] matrix = new int[N, N];

Console.WriteLine("Введите элементы матрицы:");
for (int i = 0; i < N; i++)
    for (int j = 0; j < N; j++)
        matrix[i, j] = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < N; i++)
    for (int j = 0; j < N; j++)
        if (i + j < N - 1)
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[N - 1 - j, N - 1 - i];
            matrix[N - 1 - j, N - 1 - i] = temp;
        }

Console.WriteLine("Зеркально отраженная матрица:");
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
        Console.Write(matrix[i, j] + " ");
    Console.WriteLine();
}