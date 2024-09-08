//#define NUMERIC_TYPES
//#define LITERALS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Program
    {
        static readonly string delimeter1 = "\n----------------------------\n";
        static readonly string delimeter2 = "\n============================\n";
        static void Main(string[] args)
        {
#if NUMERIC_TYPES
            #region Boolean
            Console.WriteLine("C# DataTypes");

            Console.WriteLine(bool.TrueString);
            Console.WriteLine(Convert.ToBoolean(1));
            Console.WriteLine(bool.Parse("falsE"));
            #endregion

            #region Char
            //Uniocode char-это спецификатор типа или ключевое слово
            Console.WriteLine(char.MinValue);
            Console.WriteLine(char.ConvertFromUtf32(6));
            #endregion

            #region Integral types
            Console.Write($"Переменная типа 'short' занимает {sizeof(short)} байта памяти,");
            Console.WriteLine($" и принимает значения в диапазоне : {short.MinValue} ...{short.MaxValue}");
            Console.Write($" диапазон принимаемых значений 'ushort' : {ushort.MinValue}....{ushort.MaxValue}");
            Console.WriteLine(delimeter1);
            Console.Write($"Переменная типа 'Int16' занимает {sizeof(Int16)} байта памяти,");
            Console.WriteLine($" и принимает значения в диапазоне : {Int16.MinValue} ...{Int16.MaxValue}");
            Console.Write($" диапазон принимаемых значений 'UInt16' : {UInt16.MinValue}....{UInt16.MaxValue}");
            //Convert.ToInt16();

            Console.WriteLine(delimeter2);

            Console.WriteLine();

            Console.Write($"Переменная типа 'short' занимает {sizeof(int)} байта памяти,");
            Console.WriteLine($" и принимает значения в диапазоне : {int.MinValue} ...{int.MaxValue}");
            Console.Write($" диапазон принимаемых значений 'uint' : {uint.MinValue}....{uint.MaxValue}");
            Console.WriteLine(delimeter1);
            Console.Write($"Переменная типа 'Int32' занимает {sizeof(Int32)} байта памяти,");
            Console.WriteLine($" и принимает значения в диапазоне : {Int32.MinValue} ...{Int32.MaxValue}");
            Console.Write($" диапазон принимаемых значений 'UInt32' : {UInt32.MinValue}....{UInt32.MaxValue}");

            Console.WriteLine(delimeter2);

            Console.WriteLine();

            Console.Write($"Переменная типа 'long' занимает {sizeof(long)} байта памяти,");
            Console.WriteLine($" и принимает значения в диапазоне : {long.MinValue} ...{long.MaxValue}");
            Console.Write($" диапазон принимаемых значений 'ulong' : {ulong.MinValue}....{ulong.MaxValue}");
            Console.WriteLine(delimeter1);
            Console.Write($"Переменная типа 'Int64' занимает {sizeof(Int64)} байта памяти,");
            Console.WriteLine($" и принимает значения в диапазоне : {Int64.MinValue} ...{Int64.MaxValue}");
            Console.Write($" диапазон принимаемых значений 'UInt64' : {UInt64.MinValue}....{UInt64.MaxValue}");

            Console.WriteLine(delimeter2);

            Console.WriteLine();
            #endregion

            double a = 12.56;
            Console.WriteLine(a * 100000);

#endif
#if LITERALS

            Console.WriteLine(123.4m.GetType());
            Console.WriteLine('+'.GetType());
            Console.WriteLine("Hello".GetType()); 
#endif
            //Type conversion
            #region Conversions1
            //Console.WriteLine(((byte)5).GetType().Name);//clike notation (type)value
            //Console.WriteLine(((byte)5).GetType().Name);//functional notation 
            // int a = 2;
            //byte a = 2;
            // uint b = uint.MaxValue;
            //Console.WriteLine(a +'\t'+b );
            //a = b;
            // a = (byte)b;// Truncation -усечение. Уркзается либо дробная часть при записи
            //либо старшие байты целого числа при записи его в меньшую целочисленную переменную
            #endregion

            try
            {
                int a = int.MaxValue;
                uint b = uint.MaxValue;
                Console.WriteLine((a + b).GetType().Name);
                long c = long.MaxValue;
                Console.WriteLine((b + c).GetType().Name);
                Console.WriteLine(b + c);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("bye");
        }
    }
}
