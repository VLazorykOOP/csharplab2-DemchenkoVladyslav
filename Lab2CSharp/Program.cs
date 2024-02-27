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
        static void Main(string[] args)
        {
            
        }
    }
}
