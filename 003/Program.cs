//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.WriteLine("Add numbers rows");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Add numbers colums");
int columns = int.Parse(Console.ReadLine()!);

int[,] Array = GetArray (rows, columns);
PrintArray(Array);
SredneArray(Array);

int [,] SredneArray (int [,] Array)
{   
    for (int i = 0; i < Array.GetLength(0); i++)
    {
       int srednee = 0;
        for (int e = 0; e < Array.GetLength(1); e++)
        {
            srednee += Array[e, i];
        }
        Console.WriteLine($"Ваше среднеарифметическое значение в столбе :{i + 1} = {(double)srednee/Array.GetLength(1)}");
    }
    return Array;
}

int [,] GetArray (int Stroki, int Stolb)
    {
        int [,] result = new int[Stroki, Stolb];
        for (int i = 0; i < Stroki; i++)
        {
            for (int y = 0; y < Stolb; y++)
            {
                result[i, y] = new Random().Next(1, 10);
            }
        }
        return result;
    }

    void PrintArray (int[,] Array)
        {
           for (int i = 0; i < Array.GetLength(0); i++)
        {
              Console.Write("[");
            for (int y = 0; y < Array.GetLength(1); y++)
            {
                Console.Write($"{Array[i,y]} ");
        }  
        Console.WriteLine("]");
        }
        }