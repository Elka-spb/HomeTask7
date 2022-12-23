// Task 50 Напишите программу, которая на вход принимает позиции элемента в двумерном массиве 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11); 
            Console.Write($"{matrix[i, j]} \t");
            
        }
        Console.WriteLine();
    }
}
Console.Clear();
Console.Write("Введите m - число строк матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n - число столбцов матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
InputMatrix(matrix);
Console.Write("Введите a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b: ");
int b = Convert.ToInt32(Console.ReadLine());
    if (a < m && b < n)
Console.Write("Значение элемента c указанными позициями: " + matrix[a, b]);
else 
Console.Write("Элемента с такими позициями нет в заданном массиве");