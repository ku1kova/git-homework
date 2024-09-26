using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * сложение с другой матрицей;
 * умножение на число;
 * вывод на печать;
 * умножение матриц.
 */

namespace gublaze
{
    internal class main
    {
        static void Main(string[] args)
        {
            double val = 2; int rows = 0, cols = 0;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("МАССИВЫ ЗАПОЛНЯЮТСЯ АВТОМАТИЧЕСКИ!");
            Console.ForegroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Введите колличество столбцоы: ");
            Console.ForegroundColor = ConsoleColor.White;
            rows = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Введите колличество строк: ");
            Console.ForegroundColor = ConsoleColor.White;
            cols = Convert.ToInt32(Console.ReadLine());

            two_dimensional_array sum1 = new two_dimensional_array();
            two_dimensional_array mult1 = new two_dimensional_array();
            two_dimensional_array mult2 = new two_dimensional_array();
            two_dimensional_array arrmult = new two_dimensional_array();


            double[,] arr = new double[rows, cols], arr2 = new double[rows, cols];
            Random r = new Random();

            // Заполнение первого массива
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = r.NextDouble();
                }
            }

            // Заполнение второго массива
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    arr2[i, j] = r.NextDouble();
                }
            }

            // Вывод первого массива
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Первый массив: ");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine(arr[i, j]);
                }
                Console.WriteLine();
            }

            // Вывод второго массива
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Второй массив: ");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    Console.WriteLine(arr2[i, j]);
                }
                Console.WriteLine();
            }

            // Вывод суммы массивов
            double[,] result_sum = sum1.sum(arr, arr2);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Сумма массивов:");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < result_sum.GetLength(0); i++)
            {
                for (int j = 0; j < result_sum.GetLength(1); j++)
                {
                    Console.Write(result_sum[i, j] + " \n");
                }
                Console.WriteLine();
            }

            // Вывод первого умноженного на число массива
            double[,] result_mult_1 = mult1.numult1(arr, val);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Умноженный первый массив на число {val}: ");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < result_mult_1.GetLength(0); i++)
            {
                for (int j = 0; j < result_mult_1.GetLength(1); j++)
                {
                    Console.Write(result_mult_1[i, j] + " \n");
                }
                Console.WriteLine();
            }
            // Вывод второго умноженного на число массива
            double[,] result_mult_2 = mult2.numult1(arr2, val);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Умноженный второй массив на число {val}: ");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < result_mult_2.GetLength(0); i++)
            {
                for (int j = 0; j < result_mult_2.GetLength(1); j++)
                {
                    Console.Write(result_mult_2[i, j] + " \n");
                }
                Console.WriteLine();
            }

            // Вывод умноженных массивов
            double[,] result = arrmult.arrmult(arr, arr2);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Умноженные массивы: ");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    Console.Write(result[i, j] + " \n");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }

    public class two_dimensional_array
    {
        public double[,] sum(double[,] arr, double[,] arr2)
        {
            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);
            double[,] result = new double[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = arr[i, j] + arr2[i, j];
                }
            }
            return result;
        }

        public double[,] numult1(double[,] arr, double val)
        {
            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);
            double[,] result = new double[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = arr[i, j] * val;
                }
            }
            return result;
        }
        public double[,] numult2(double[,] arr, double val)
        {
            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);
            double[,] result = new double[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = arr[i, j] * val;
                }
            }
            return result;
        }
        public double[,] arrmult(double[,] arr, double[,] arr2)
        {
            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);
            double[,] result = new double[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = arr[i, j] * arr2[i, j];
                }
            }
            return result;
        }
    }
}