//#define OUTPUT_TO_SCREEN
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToDOTNET
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if OUTPUT_TO_SCREEN
            Console.Title = "Introduction to .NET";
            Console.WriteLine("\t\tHello .NET");

            Console.BackgroundColor = ConsoleColor.Yellow;//цвет фона
            Console.ForegroundColor = ConsoleColor.Red;//цвет текста

            //Console.CursorLeft = 36;//коорд курсора по оси Х
            //Console.CursorTop = 6;//коорд курсора по оси Y
            //Console.SetCursorPosition(16, 5);


            Console.WriteLine("Вот так задаются координаты");
            Console.ResetColor();//применяет цветовую схему по умолчанию

            //Задаем размер окна консоли:
            //Console.WindowWidth = 64;
            //Console.WindowHeight=16;
            Console.SetWindowSize(64, 16);

            // Для того, чтобы свернуть часть кода, этот код нужно поместить в #region... #endregion:
            #region CodeSnippet
            //Задаем положение окна на экране:
            //Console.WindowLeft = 20;
            // Console.WindowTop = 100;
            #endregion
            //Задаем размер буфера консоли:
            Console.BufferWidth = Console.WindowWidth;
            Console.BufferHeight = Console.WindowHeight;


#endif
            Console.Write("Введите Ваше имя: ");
            string first_name = Console.ReadLine();//Метод REadLine  читаетс клавиатуры до нажатия "Enter"  и возвращает прочитанную строку
            //Console.Write(first_name);

            Console.Write("Введите Вашу фамилию : ");
            string last_name = Console.ReadLine();
            //Console.WriteLine(last_name);

            Console.Write("Введите ваш возраст:");
            int age = Convert.ToInt32(Console.ReadLine());

            /*
             Класс Convert предст собой набор статических методов для преобр-ния типов
            Этот тип, какправило, используется в том случае, когда другие преобраз-ния не работают
              
             */
            //Console.WriteLine(a);
            Console.WriteLine(last_name + " " + first_name + " " + age+ " years"); //Конкатенация
            
            //Кроме конкатенации строк С# поддерживает форматирование строк
            Console.WriteLine(String.Format("{0} {1} {2} years", last_name,first_name,age));

            //Самая удобная операция - Интерполяция строк
            Console.WriteLine($"{last_name} {first_name} {age} years");// 


        }
    }
}
