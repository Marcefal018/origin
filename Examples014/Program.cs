// string[,] table = new string[2, 3]; (массив строк) пример как задаются двумерные массивы
//( "," означает , что у нас будет 2 размерности : 1 размерность - это строки, 2 размерность - столбцы)
// int[,] matrix = new int [5, 8]; (прямоугольная таблица чисел("Матрица"))


string[,] table = new string[2, 5];

// String.Empty
//table[0, 0]  table[0, 1]  table[0, 2]  .... table[0, 4]
//table[1, 0]  table[1, 1]  table[1, 2]  .... table[1, 4]


/*table[1, 2] = "слово";

for (int rows = 0; rows < 2; rows++)
{
    for (int colums = 0; colums < 5; colums++)
    {
        Console.Write($"-{table[rows, colums]}-");
    }
    System.Console.WriteLine();
}*/

int[,] matrix = new int[3, 4];

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // matr.GetLength(0) - строки.
    {
        for (int j = 0; j < matr.GetLength(1); j++) // matr.GetLength(1) - столбцы.
        {
            System.Console.Write($"{matr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

void FillArray(int[, ] matr) // Дополнительный метод, который заполняет нашу матрицу случайными числами.
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for( int j = 0; j <matr.GetLength(1); j++)
        {
            matr[i, j] =new Random().Next(1, 10); // [1, 10) - полуинтервал.
        }
    }
}


PrintArray(matrix);
FillArray(matrix);
PrintArray(matrix);