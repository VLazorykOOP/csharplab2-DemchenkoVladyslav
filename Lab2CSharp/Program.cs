using System.Globalization;

namespace Lab2CSharp
{
    internal class Program
    {

        static Random r = new Random();
        static void Task1()
        {
            Console.WriteLine("Enter size of array: ");
            int n = int.Parse(Console.ReadLine());
            double[] mas1 = new double[n];
            Console.WriteLine("Array: ");
            for (int i = 0; i < n; i++)
                Console.Write((mas1[i] = Math.Round(r.NextDouble() * 100, 2)) + " ");
            Console.WriteLine("\nEnter filter number: ");
            double f = double.Parse(Console.ReadLine());
            Console.WriteLine("Updated array:");
            for (int i = 0; i < n; i++)
            {
                mas1[i] = mas1[i] < f ? mas1[i] * 2 : mas1[i];
                Console.Write(mas1[i] + " ");
            }
            Console.WriteLine("\n Same work with matrix:");
            double[][] mas2 = new double[n][];
            for (int i = 0; i < n; i++)
            {
                mas2[i] = new double[n];
                for (int j = 0; j < n; j++)
                {
                    mas2[i][j] = Math.Round(r.NextDouble() * 100, 2);
                    Console.Write(mas2[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mas2[i][j] < f)
                        mas2[i][j] *= 2;
                    Console.Write(mas2[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Task2()
        {
            Console.Write("Enter array size: ");
            int n = int.Parse(Console.ReadLine());

            double[] numbers = new double[n];

            Console.WriteLine("Array:");
            for (int i = 0; i < n; i++)
            {
                numbers[i] = Math.Round(r.NextDouble() * 100, 2);
                Console.Write(numbers[i] + " ");
            }

            int maxIndex = 0;
            for (int i = 1; i < n; i++)
            {
                if (numbers[i] > numbers[maxIndex])
                {
                    maxIndex = i;
                }
            }
            (numbers[0], numbers[maxIndex]) = (numbers[maxIndex], numbers[0]);
            Console.WriteLine("\nSwap result:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
        static void Task3()
        {
            Console.WriteLine("Enter size of matrix: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Your matrix:");
            int[][] mas2 = new int[n][];
            for (int i = 0; i < n; i++)
            {
                mas2[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    mas2[i][j] = r.Next() % 101 - 50;
                    if ((n - 1 - i) == j)
                        Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(mas2[i][j] + " ");
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
            double sum = 0;
            Console.WriteLine("Elements under the secondary diagonal:");
            for (int i = 0; i < n; i++)
            {
                for (int j = n - i; j < n; j++)
                {
                    Console.Write(mas2[i][j] + " ");
                    sum += mas2[i][j];
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Their avg: {sum / (n * n - n) / 2}");

        }
        static void Task4()
        {
            Console.Write("Enter number of rows: ");
            int n = int.Parse(Console.ReadLine());

            int[][] array = new int[n][];

            Console.WriteLine("Array:");
            for (int i = 0; i < n; i++)
            {
                array[i] = new int[i + 1];
                for (int j = 0; j <= i; j++)
                {
                    array[i][j] = r.Next() % 101 - 50;
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }

            int[] columnSums = new int[n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {

                    if (array[i][j] > 0 && array[i][j] % 2 == 0)
                    {
                        columnSums[j] += array[i][j];
                    }
                }
            }

            Console.WriteLine("Sums for columns:");
            for (int j = 0; j < n; j++)
            {
                Console.Write(columnSums[j] + " ");
            }
        }
        static void Main(string[] args)
        {
            //Task1();
            // Task2();
            Task3();
            //Task4();
        }
    }
}
