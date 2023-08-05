// create2D array; find row No with lowest sum

// double[,] matrixA = new double[,] { { 2, 4 }, { 3, 2 } };
// double[,] matrixB = new double[,] { { 3, 4 }, { 3, 3 } };

// double[,] matrixA = new double[,] { { 2, 1 }, { 1, 2 }, { 3, 0 } };
// double[,] matrixB = new double[,] { { 1, 0, 1 }, { 2, 1, 0 } };

double[,] matrixA = new double[new Random().Next(2,10), new Random().Next(2, 10)];
double[,] matrixB = new double[matrixA.GetLength(1),matrixA.GetLength(0)];

void FillMatrix(double[,] matrixA)
{
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixA.GetLength(1); j++)
        {
            matrixA[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintTabel(double[,] matrixA)

{
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixA.GetLength(1); j++)

        {
            Console.Write(matrixA[i, j] + " ");
        }
        Console.WriteLine();
    }
}


double[,] matrixC = new double[matrixA.GetLength(0), matrixB.GetLength(1)];


void MatrixMultiplication()
{
    for (int i = 0; i < matrixC.GetLength(0); i++)
    {
        for (int j = 0; j < matrixC.GetLength(1); j++)
        {
            double sum = 0;
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                sum += matrixA[i, k] * matrixB[k, j];
                // Console.Write(sum + " ");
            }
            matrixC[i, j] = sum;
        }
    }
}


Console.WriteLine();
Console.WriteLine("Matrix A:");
FillMatrix(matrixA);
PrintTabel(matrixA);
Console.WriteLine();
Console.WriteLine("Matrix B:");
FillMatrix(matrixB);
PrintTabel(matrixB);
Console.WriteLine();
MatrixMultiplication();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Matrix C:");
PrintTabel(matrixC);
