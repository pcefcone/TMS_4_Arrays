using System.ComponentModel;
using System.Data;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

internal class Program
{
    /*static void BubbleSort(int[] inArray)
    {
        for (int i = 0; i < inArray.Length; i++)
            for (int j = 0; j < inArray.Length - i - 1; j++)
            {
                if (inArray[j] > inArray[j + 1])
                {
                    int temp = inArray[j];
                    inArray[j] = inArray[j + 1];
                    inArray[j + 1] = temp;
                }
            }
    }*/
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

        Console.Write("Ваш массив имеет вид:");

        for (int i = 0; i < row; i++)
        {
            Console.WriteLine();
            for (int j = 0; j < col; j++)
            {
                Console.Write("{0}  ", array[i, j]);
            }
        }
        Console.WriteLine("\nЧто вы хотите сделать с массивом? Выберите действие:" +
            "\n1 - Найти количество положительных чисел в матрице" +
            "\n2 - Найти количество отрицательных чисел в матрице" +
            "\n3 - Сортировка элементов матрицы построчно (по убыванию)" +
            "\n4 - Сортировка элементов матрицы построчно (по возрастанию)" +
            "\n5 - Инверсия элементов матрицы построчно" +
            "\n6 - Exit programm");



        var operation = int.Parse(Console.ReadLine());
        switch (operation)
        {
            case 1:
                int countPos = 0;
                Console.Write("Положительные элементы:");
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
                Console.WriteLine("\nКоличество положительных элементов матрицы: " + countPos);
                break;
            case 2:
                int countNeg = 0;
                Console.Write("Отрицательные элементы:");
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
                Console.WriteLine("Количество отрицательных элементов матрицы: " + countNeg);
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
                Console.WriteLine("Сортировка элементов матрицы построчно (по убыванию)");
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("To countinue press any key!");
                Console.ReadKey();
                Console.WriteLine();
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
                                int t = array[i, k];
                                array[i, k] = array[i, k + 1];
                                array[i, k + 1] = t;
                            }
                        }
                    }
                }
                Console.WriteLine("Сортировка элементов матрицы построчно (по возрастанию)");
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("To countinue press any key!");
                Console.ReadKey();
                Console.WriteLine();
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
                Console.WriteLine("Симметричное инвертирование");
                for (int i = 0; i < newCol; i++)
                {
                    for (int j = 0; j < newRow; j++)
                    {
                        Console.Write(array[i, j] + " ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("Press any key!");
                Console.ReadKey();
                Console.WriteLine();
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