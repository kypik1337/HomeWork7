//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 //и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//i = 4, j = 2 -> такого числа в массиве нет
//i = 1, j = 2 -> 2



Console.WriteLine("Add numbers rows");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Add numbers colums");
int columns = int.Parse(Console.ReadLine()!);
Console.WriteLine("Add index FIND");
int numbers = int.Parse(Console.ReadLine()!);
Console.WriteLine("Add index 2 FIND");
int numbers1 = int.Parse(Console.ReadLine()!);


int[,] Array = GetArray (rows, columns);
PrintArray(Array);
FndArray(Array);

int FndArray (int[,] Array)
    {    
        int result = 0;
        for (int i = 0; i < Array.GetLength(0); i++)
        {
           for (int e = 0; e < Array.GetLength(1); e++)
           {
                while (i != numbers && e != numbers1)
                    {
                      Console.WriteLine($"I dount NOOOOO!");
                      return result;  
                    }   
           } 
        }
          Console.WriteLine($"Ваше число :-> {Array.GetValue(numbers,numbers1)}");
        return result;
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