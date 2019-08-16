using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
// 1.   а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.Продемонстрировать работу структуры;
//  
//      Трифонов Александр
//
namespace ComplexStruct
{
    class Program
    {
        //
        // Структура Complex
        //
        struct Complex
        {
            public double im;
            public double re;
            //
            // Сложение комплексных чисел
            //
            public Complex Plus(Complex x)
            {
                Complex y;
                y.im = im + x.im;
                y.re = re + x.re;
                return y;
            }
            //
            // Умножение комплексных чисел
            //
            public Complex Mult(Complex x)
            {
                Complex y;
                y.im = re * x.im + im * x.re;
                y.re = re * x.re - im * x.im;
                return y;
            }

            //
            // Вычитание комплексных чисел
            //
            public Complex Substrac(Complex x)
            {
                Complex y = new Complex();

                y.im = x.im - im;
                y.re = x.re - im;
                return y;
            }

            public string ToString()
            {
                return re + "+" + im + "i";
            }
        }

        static void Main(string[] args)
        {
            Complex complex1;
            complex1.im = 1;
            complex1.re = 1;

            Complex complex2;
            complex2.im = 2;
            complex2.re = 2;

            //
            // Демонстрация сложения
            //
            Console.WriteLine("Демонстрация сложения");
            Complex result = complex1.Plus(complex2);
            Console.WriteLine(result.ToString());
            Console.ReadKey();

            //
            // Демонстрация умножения
            //
            Console.WriteLine("Демонстрация умножения");
            result = complex1.Mult(complex2);
            Console.WriteLine(result.ToString());
            Console.ReadKey();

            //
            // Демонстрация вычитания
            //
            Console.WriteLine("Демонстрация вычитания");
            result = complex1.Substrac(complex2);
            Console.WriteLine(result.ToString());
            Console.ReadKey();
        }
    }
}
