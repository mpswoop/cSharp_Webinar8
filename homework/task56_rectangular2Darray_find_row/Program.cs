// create2D array; find row No with lowest sum

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

void FindMin(double[,] tabel)
{
    double[] sums = new double[tabel.GetLength(0)];


    for (int i = 0; i < tabel.GetLength(0); i++)
    {
        double sum = 0;

        for (int j = 0; j < tabel.GetLength(1); j++)
        {
            sum += tabel[i, j];

            // double sum = 0;
            // sums[i] = sum + tabel[i, j];
            // Console.WriteLine(sum);
        }
        sums[i] = sum;
    }
    Console.WriteLine();
    for (int i = 0; i < sums.GetLength(0); i++)
    {
        {
            Console.WriteLine($"sum {i} = {sums[i]}");
        }
    }
    Console.WriteLine();

    int min = 0;

    for (int i = 1; i < sums.GetLength(0); i++)
    {

        if (sums[i] < sums[min]) min = i;
    }
    Console.WriteLine($"minimal row is row No. {min}");

    for (int i = 1; i < sums.GetLength(0); i++)
    {
        if (sums[i] == sums[min] && i != min)
        {
            Console.WriteLine($"and row No. {i}");
        }
    }
}





FillTabel();
PrintTabel(tabel);
Console.WriteLine();
FindMin(tabel);
