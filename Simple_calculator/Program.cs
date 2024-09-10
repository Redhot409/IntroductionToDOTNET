//#define SWITCH
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Simple_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float first, second, result;
            char arsign;
            Console.WriteLine(" Введите первое число, затем знак действия(+,-,*,/), и второе число.");

            Console.Write("Введите первое число: ");
            first = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите знак действия : ");
            arsign = Convert.ToChar(Console.ReadLine());
            Console.Write("Введите Второе число: ");
            second = Convert.ToSingle(Console.ReadLine());

            if (arsign == '+')
            {
                result = first + second;
                Console.WriteLine("Сумма чисел равна " + result);
                Console.WriteLine("Для выхода нажмите любую клавишу...");
                Console.ReadKey();
            }
            else if (arsign == '-')
            {
                result = first - second;
                Console.WriteLine("Разность чисел равна " + result);
                Console.WriteLine("Для выхода нажмите любую клавишу...");
                Console.ReadKey();
            }
            else if (arsign == '*')
            {
                result = first * second;
                Console.WriteLine("Произведение чисел равно " + result);
                Console.WriteLine("Для выхода нажмите любую клавишу...");
                Console.ReadKey();
            }
            else if (arsign == '/')
            {
                if (second == 0)
                {
                    Console.WriteLine("Ошибка. Делитель не может быть равным нулю.");
                    Console.WriteLine("Для выхода нажмите любую клавишу...");
                    Console.ReadKey();
                }
                else
                {
                    result = first / second;
                    Console.WriteLine("Частное ваших чисел равна " + result);
                    Console.WriteLine("Для выхода нажмите любую клавишу...");
                    Console.ReadKey();
                }
            }
                else
                {
                    Console.WriteLine("Неизвестный оператор.");
                    Console.WriteLine("Для выхода нажмите любую клавишу...");
                    Console.ReadKey();
                }

            // var 2 (switch)
#if SWITCH
            switch (arsign)
            {
                case '+': result = first + second; Console.WriteLine("Сумма чисел равна " + result); break;
                case '-': result = first - second; Console.WriteLine("Разность чисел равна " + result); break;
                case '*': result = first * second; Console.WriteLine("Произведение чисел равно " + result); break;
                case '/': result = first / second; Console.WriteLine("Частное ваших чисел равна " + result); break;
                default: Console.WriteLine("Неизвестный оператор."); break;
            } 
#endif
        }
    }
}