using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // прямоугольник из звезд
            int size = 5;
            for (int i = 0;(i < size); i++)
            {
                for (int j = 0; j < size; j++) Console.Write(" *");
                Console.WriteLine();
            }

            //Треугольник #1
            for (int i = 0; i < size; i++) 
            { for (int j = 0;j<=i;j++) Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine();

            //Треугольник #2
            for (int i = 0; i < size; i++)
            { 
                for(int j = 0;j<size-i;j++) Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine();

            //Треугольник #3
            for (int i = 0; i < size; i++) 
            {
                for (int j = 0; j <size; j++)
                {
                    if (j < i) Console.Write(" "); 
                    else Console.Write("*");
                }
                Console.WriteLine();
            }

            //Треугольник #4
            for (int i = 0; i < size; i++) 
            {
                for (int j = 0; j < size; j++)
                {
                    if(j<size-1-i) Console.Write(" ");
                    else Console.Write("*");
                }
                Console.WriteLine();
            }

            //ромб 
            size = 10;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                   if (j==size/2 - 1 - i || j==size-1-(i-size/2)) Console.Write("/");
                   else if(i==size/2+j || j==size/2+i) Console.Write("\\");
                   else Console.Write(" ");
                }
                Console.WriteLine();
            }

            //шахматная доска
            size = 5;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                   if (i%2==0 && j%2==0 || i%2==1 && j%2==1) Console.Write("+ ");
                   else Console.Write("- ");
                }
                Console.WriteLine();
            }

            Console.Write("Введите размер шахматной доски: ");
            size=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("┏");
            for (int i = 0;i < size;i++) Console.Write("-");
            Console.Write("┓");
            Console.WriteLine();
            for (int i = 0; i < size; i++) 
            {
                Console.Write("| ");
               
                for (int j = 0; j < size; j++)
                {
                    if (i % 2 == 0 && j % 2 == 0 || i % 2 == 1 && j % 2 == 1)
                    { 
                        Console.BackgroundColor=ConsoleColor.Green;
                        Console.BackgroundColor=ConsoleColor.White;
                    }
                    else Console.ResetColor();
                    Console.Write(" ");
                }
                Console.ResetColor();
                Console.Write(" |");
                Console.WriteLine();
            }
            Console.Write("┗");
            for(int i = 0;i<size ; i++) Console.Write("-");
            Console.Write("┛");
            Console.WriteLine();
            Console.ResetColor();

            Console.Write("Введите размер шахматной доски: ");
            size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            
            int square_size = 5;
            Console.WriteLine();

            for (int i = 0; i < size; i++)
            {
                for (int ik = 0; ik < square_size; ik++)

                {
                    for (int j = 0; j < size; j++)
                    {
                        for (int jk = 0; jk < square_size; jk++)
                        { 
                            if(i%2==0 &&j%2==0 ||i%2==1 &&j%2==1) Console.Write("* ");
                            else Console.Write("  ");
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
