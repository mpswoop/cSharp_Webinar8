// 2D array 4x4 spiral fill
string[,] array = new string[4, 4];

double[] numbers = new double[100];

string[] strings = new string[numbers.GetLength(0)];

void CreateNumbers()
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        numbers[i] = i + 1;
    }
}

void NumbersToString()

{
    for (int i = 0; i < numbers.GetLength(0) - 1; i++)
    {
        if (numbers[i + 1] < 11)
        {
            strings[i] = Convert.ToString("0" + (i + 1));
        }
        else
        {
            strings[i] = Convert.ToString(i + 1);
        }
    }
}

void FillArray()
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[0, i] = strings[count];
        count++;
    }

    for (int i = 1; i < array.GetLength(0); i++)
    {
        array[i, 3] = strings[count];
        count++;

    }

    for (int i = 0; i < 3; i++)
    {
        array[3, i] = strings[9 - i];
        count++;
    }

    for (int i = 0; i < 2; i++)
    {
        array[i + 1, 0] = strings[11 - i];
        count++;
    }

    for (int i = 1; i < 3; i++)
    {
        array[1, i] = strings[count];
        count++;
    }

    for (int i = 0; i < 2; i++)
    {
        array[2, i+1] = strings[15 - i];
        count++;
    }
}



void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}


CreateNumbers();
Console.WriteLine();
NumbersToString();
FillArray();
PrintArray();