//#define ARRAYS_1
//#define ARRAYS_2
//#define JAGGED_ARRAYS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if ARRAYS_1
            //int[] arr=new int[] { 3,5,8,13,21};
            //int[] arr= {3,5,8,13,21};
            Console.Write("ВВедите количество элементов: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];


            //Заполнение массива случайными числами

            //Random rand = new Random();
            Random rand = new Random(0);//0-seed
            for (int i = 0; i < arr.Length; i++)
            {
                // arr[i] = rand.Next();
                arr[i] = rand.Next(50, 100);

            }

            //bool[] arr = new bool[n];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine();

            //Range based for
            //foreach (int i in arr)
            //{
            //    Console.Write(i + "\t");
            //}
            //Console.WriteLine(); 

           Console.WriteLine($"Сумма элементов массива:{arr.Sum()}");
           Console.WriteLine($"Среднее арифметическое элементов массива:{arr.Average()}");
           Console.WriteLine($"Минимальное значение элементов массива:{arr.Min()}");
           Console.WriteLine($"Мксимальное значение элементов массива:{arr.Max()}");
#endif
#if ARRAYS_2
            //Двумерный массив
            //int[,] i_arr_2 = new int[3, 4];
            int[,] i_arr_2 = new int[,]
            {
                { 3,5,8,13},
                { 21,34,55,89},
                { 144,233,377,610}
            };
            //Console.WriteLine(new int[5].Rank);
            //Console.WriteLine(i_arr_2.Rank);
            //Console.WriteLine(new int[5, 2, 4, 7, 9].Rank);
            Console.WriteLine($"Количество измерений массива: {i_arr_2.Rank}");
            Console.WriteLine($"Количество элементов в нулевом измерении(количество строк): {i_arr_2.GetLength(0)}");
            Console.WriteLine($"Количество элементов в первом измерении(количество столбцов): {i_arr_2.GetLength(1)}");
            for ( int i = 0; i < i_arr_2.GetLength(0);i++ ) 
            {
                for (int j = 0; j < i_arr_2.GetLength(1); j++)
                {
                    Console.Write(i_arr_2[i,j]+"\t");
                }
            }
                Console.WriteLine();
            //foreach (int i in i_arr_2)
            //{
            //    Console.Write(i+"\t");
            //}
            //Console.WriteLine();

            Console.WriteLine($"Сумма элементов массива: {i_arr_2.Cast<int>().Sum()}");
            Console.WriteLine($"Среднее арифметическое элементов массива:{i_arr_2.Cast<int>().Average()}");
            Console.WriteLine($"Минимальное значение элементов массива:{i_arr_2.Cast<int>().Min()}");
            Console.WriteLine($"Максимальное значение элементов массива:{i_arr_2.Cast<int>().Max()}");
#endif
#if JAGGED_ARRAYS
            int[][] j_arr = new int[][]
                {
                    new int[]{0,5,56,2},
                    new int[]{111,134,16,2,45,54},
                    new int[]{0,1,18,111,456,23,345,67},
                    new int[]{0,1,1,333,556,890},

                };
            for (int i = 0; i < j_arr.Length; i++)
            
            {
                for (int j = 0; j < j_arr[i].Length; j++) 
                {
                    Console.Write(j_arr[i][j]+"\t");
                }
                Console.WriteLine();
            }
            int sum = 0;
            //Console.WriteLine($"Сумма элементов массива: {j_arr.Sum()}");
            //Console.WriteLine($"Сумма элементов массива: {j_arr.Cast<int>().Sum()}");
            int count = 0;
            int min,max;
            min = max = j_arr[0][0];
            for (int i = 0; i < j_arr.Length; i++)
            {
                sum += j_arr[i].Sum();
                count += j_arr[i].Length;
                if (j_arr[i].Min() < min) min = j_arr[i].Min();
                if (j_arr[i].Max() > max) max = j_arr[i].Max();
            }
            Console.WriteLine($"Сумма элементов массива: {sum}");
            Console.WriteLine($"Cредне-арифметическое значение элементов: {(double)sum/count}");
            Console.WriteLine($"Минимальное значение элементов: {min}");
            Console.WriteLine($"Максимальное значение элементов: {max}");
#endif
        }
    }
}
