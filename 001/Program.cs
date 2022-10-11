//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
//m = 3, n = 4.
//1 7 -2 -85
//1 -3 8 -9
//8 7 -7 9

Console.WriteLine("Add numbers rows");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Add numbers colums");
int columns = int.Parse(Console.ReadLine()!);

int[,] Array = GetArray (rows, columns);
PrintArray(Array);






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
   