// 3D array from non recurring 2 digital numbers 
// print array line by line showing indices of all elements

double[,,] array = new double[2, 2, 2];

double[] check = new double[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];

void CreateNumbers()
{
    for (int i = 0; i < check.GetLength(0); i++)
    {
        double number = new Random().Next(10, 100);

        bool answer = true;

        while (answer == true)
        {
            if (check.Contains(number))
            {
                answer = true;
                number = new Random().Next(1, 10);
            }
            else
            {
                answer = false;
            }

        }
        check[i] = number;
    }
}

void PrintCheck()
{
    for (int i = 0; i < check.GetLength(0); i++)
    {
        Console.Write(check[i] + " ");
    }
    Console.WriteLine();
}

void FillArray(double[,,] array)
{
    int m = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = check[m];
                m++;
            }
        }
    }
}

void PrintArray(double[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

CreateNumbers();
PrintCheck();
FillArray(array);
Console.WriteLine();
PrintArray(array);
