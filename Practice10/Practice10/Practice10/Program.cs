using System;

namespace Practice10
{
    class Program
    {
        static void PrintDArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("{0} ", arr[i, j]);
                }
                Console.WriteLine();
            }
        }

        // Number 10

        static void GetArrayCol(int m, int n, int k)
        {
            if (1 <= k && k <= m)
            {
                int[,] arr = new int[m, n];

                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        try
                        {
                            Console.Write($"Введите элемент {j+1} столбца {i+1}: ");
                            arr[i, j] = int.Parse(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Элемент массива должен быть числом!");
                            Environment.Exit(0);
                        }
                    }
                }

                Console.WriteLine("Массив: ");
                PrintDArray(arr);

                int elSum = 0;
                int elMult = 1;

                for (int i = 0; i < arr.GetLength(1); i++)
                {
                    elSum += arr[k, i];
                    elMult *= arr[k, i];
                }

                Console.WriteLine($"Сумма всех элементов подмассива {k}: {elSum}");
                Console.WriteLine($"Произведение всех элементов подмассива {k}: {elMult}");

            } 
            else
            {
                Console.WriteLine("k долдно находится в промежутке: 1 <= k <= m!");
                Environment.Exit(0);
            }

        }

        //

        // Number 14

        static void SeatsCount(int m, int n)
        {

            int[,] arr = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    try
                    {
                        Console.Write($"В вагоне {i + 1} место {j + 1}: ");
                        int value = int.Parse(Console.ReadLine());

                        if (value == 0 || value == 1)
                        {
                            arr[i, j] = value;
                        }
                        else 
                        {
                            Console.WriteLine("Принимаются занчения только 1 и 0!");
                            Environment.Exit(0);
                        }

                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Элемент массива должен быть числом!");
                        Environment.Exit(0);
                    }
                }
            }

            Console.WriteLine("Места: ");
            PrintDArray(arr);

            try
            {
                Console.Write("Введиет вагон (1 <= railway <= m): ");
                int railway = int.Parse(Console.ReadLine());
                int railwayCount = 0;

                if (0 <= railway && railway <= m)
                {
                    for (int i = 0; i < arr.GetLength(1); i++)
                    {
                        if (arr[railway, i] == 0) railwayCount++;
                    }

                    Console.WriteLine($"Количество свободных мест: {railwayCount}");
                }
                else
                {
                    Console.WriteLine("k долдно находится в промежутке: 1 <= k <= m!");
                    Environment.Exit(0);
                }

            }
            catch (Exception)
            {

                Console.WriteLine("Элемент массива должен быть числом!");
                Environment.Exit(0);
            }
        }

        static void Main(string[] args)
        {
            // Number 10
/*            try
            {
                Console.Write("Введиет число m: ");
                int m = int.Parse(Console.ReadLine());

                Console.Write("Введиет число n: ");
                int n = int.Parse(Console.ReadLine());

                Console.Write("Введиет число k (1 <= k <= m): ");
                int k = int.Parse(Console.ReadLine());

                GetArrayCol(m, n, k);
            }
            catch (FormatException)
            {

                Console.WriteLine("Числ не может быть буквой!");
                Environment.Exit(0);
            }*/
            //

            // Number 14
            try
            {
                Console.Write("Введиет число m: ");
                int m = int.Parse(Console.ReadLine());

                Console.Write("Введиет число n: ");
                int n = int.Parse(Console.ReadLine());

                SeatsCount(m, n);
            }
            catch (FormatException)
            {

                Console.WriteLine("Числ не может быть буквой!");
                Environment.Exit(0);
            }
            //
        }
    }
}
