Console.Clear();
string[,] table = new string[2, 5]; // Создаём таблицу в которой будет 2 строки и 5 столбцов
// // table[0, 0] Первый столбик, table[0, 1] второй столбик, table[0, 2] третий столбик ... table[0, 4]
// // table[0, 0] это строки, тут всё аналогочно, только меняется индекс строки. table[1, 1], table[1, 2]
// // String.Empty

// table[1, 2] = "слово"; 
// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }
int[,] matrix = new int[3, 4];
void PrintArray(int[,] mat)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            Console.Write($"{mat[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] mat)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            mat[i, j] = new Random().Next(1, 10);
        }
    }
}


PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
