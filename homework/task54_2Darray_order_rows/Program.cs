// 2D array; order elements of each row from max to min

double[,] tabel = new double[new Random().Next(1, 11), new Random().Next(1, 11)];

void FillTabel()
{
    for (int i = 0; i < tabel.GetLength(0); i++)
    {
        for (int j = 0; j < tabel.GetLength(1); j++)
        {
            tabel[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintTabel(double[,] tabel)

{
    for (int i = 0; i < tabel.GetLength(0); i++)
    {
        for (int j = 0; j < tabel.GetLength(1); j++)

        {
            Console.Write(tabel[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void OrderRow()
{
    for (int i = 0; i < tabel.GetLength(0); i++)
    {
        for (int j = 0; j < tabel.GetLength(1)-1; j++)
        {
            for (int k = 0; k < tabel.GetLength(1) - 1; k++)
            {
                if (tabel[i, k] < tabel[i, k + 1])
                {
                    double temp = tabel[i, k];
                    tabel[i, k] = tabel[i, k + 1];
                    tabel[i, k + 1] = temp;
                }
            }
        }
    }
}




FillTabel();
PrintTabel(tabel);
Console.WriteLine();
OrderRow();
PrintTabel(tabel);





