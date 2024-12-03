using System.ComponentModel;
using System.Data;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

internal class Program
{
    public static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.WriteLine();
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write("{0}  ", array[i, j]);
            }
        }
    }

    public static void PrintResultArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Press any key!");
        Console.ReadKey();
        Console.WriteLine();
    }

    private static void Main(string[] args)
    {
        Console.Write("Put number of rows: ");
        int row = int.Parse(Console.ReadLine());
        Console.Write("Put number of columns: ");
        int col = int.Parse(Console.ReadLine());
        int[,] array = new int[row, col];

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                Console.Write($"Element [{i}, {j}]: ");
                int a = array[i, j] = int.Parse(Console.ReadLine());
            }
        }
        Console.Clear();
        Console.Write("Your array looks like:");
        PrintArray(array);
      
        Console.WriteLine("\nЧто вы хотите сделать с массивом? Выберите действие:" +
            "\n1 - Find the number of positive numbers in a matrix" +
            "\n2 - Find the number of negative numbers in a matrix" +
            "\n3 - Sorting matrix elements row by row (descending)" +
            "\n4 - Sorting matrix elements row by row (ascending)" +
            "\n5 - Inverting matrix elements row by row" +
            "\n6 - Exit programm");



        var operation = int.Parse(Console.ReadLine());
        switch (operation)
        {
            case 1:
                int countPos = 0;
                Console.Write("Positive elements:");
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        if (array[i, j] >= 0)
                        {
                            Console.Write(" " + array[i, j]);
                            countPos++;
                        }
                    }
                }
                Console.WriteLine("\nNumber of positive matrix elements is: " + countPos);
                break;
            case 2:
                int countNeg = 0;
                Console.Write("Negative elements:");
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        if (array[i, j] < 0)
                        {
                            Console.Write(" " + array[i, j]);
                            countNeg++;
                        }
                    }
                }
                Console.WriteLine("Number of negative matrix elements is: " + countNeg);
                Console.WriteLine("Press any key!");
                Console.ReadKey();
                Console.WriteLine();
                break;
            case 3:
                Console.WriteLine();
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        for (int k = 0; k < array.GetLength(1) - j - 1; k++)
                        {
                            if (array[i, k] < array[i, k + 1])
                            {
                                int t = array[i, k];
                                array[i, k] = array[i, k + 1];
                                array[i, k + 1] = t;
                            }
                        }
                    }
                }
                Console.WriteLine("Sorting matrix elements row by row (descending)");
                PrintResultArray(array);
                break;
            case 4:
                Console.WriteLine();
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        for (int k = 0; k < array.GetLength(1) - j - 1; k++)
                        {
                            if (array[i, k] > array[i, k + 1])
                            {
                                int tempArray = array[i, k];
                                array[i, k] = array[i, k + 1];
                                array[i, k + 1] = tempArray;
                            }
                        }
                    }
                }
                Console.WriteLine("Sorting matrix elements row by row (ascending)");
                PrintResultArray(array);
                break;
            case 5:
                int newRow = array.GetLength(0);
                int newCol = array.GetLength(1);

                for (int i = 0; i < newRow; i++)
                {
                    int start = 0;
                    int end = newCol - 1;
                    while (start < end)
                    {
                        int tempArray = array[i, start];
                        array[i, start] = array[i, end];
                        array[i, end] = tempArray;
                        start++;
                        end--;
                    }
                }
                Console.WriteLine("Inverting matrix elements row by row");
                PrintResultArray(array);               
                break;
            case 6:
                Console.WriteLine("Good bye! Press any key!");
                Console.ReadKey();
                break;
            default:
                break;
        }
    }
}