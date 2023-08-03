// See https://aka.ms/new-console-template for more information

double[,] tabel = new double[new Random().Next(1, 11), new Random().Next(1, 11)];

void FillTabel()
{
    for (int i = 0; i < tabel.GetLength(0); i++)
    {
        for (int j = 0; j < tabel.GetLength(1); j++)
        {
            tabel[i, j] = new Random().Next(1, 9);
        }
    }
}

void PrintTabel()
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

double[,] reverse_tabel = new double[tabel.GetLength(1), tabel.GetLength(0)];

void ReverseTabel()
{
    for (int i = 0; i < reverse_tabel.GetLength(0); i++)
    {
        for (int j = 0; j < reverse_tabel.GetLength(1); j++)
        {
            reverse_tabel[i, j] = tabel[j, i];
        }
    }
}

void PrintReverseTabel()
{
    for (int i = 0; i < reverse_tabel.GetLength(0); i++)
    {
        for (int j = 0; j < reverse_tabel.GetLength(1); j++)

        {
            Console.Write(reverse_tabel[i, j] + " ");
        }
        Console.WriteLine();
    }
}

FillTabel();
PrintTabel();
Console.WriteLine("");
ReverseTabel();
PrintReverseTabel();