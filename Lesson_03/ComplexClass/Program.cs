using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
// 1.   б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса;
//
//      Трифонов Александр
//
namespace ComplexClass
{
    //
    // Класс Complex
    //
    class Complex
    {
        double im;
        double re;

        public Complex()
        {
            im = 0;
            re = 0;
        }

        public Complex (double im, double re)
        {
            this.im = im;
            this.re = re;
        }
        //
        // Сложение комплексных чисел
        //
        public Complex Plus(Complex x)
        {
            Complex y = new Complex();

            y.im = x.im + im;
            y.re = x.re + re;
            return y;
        }

        //
        // Вычитание комплексных чисел
        //
        public Complex Substrac (Complex x)
        {
            Complex y = new Complex();

            y.im = x.im - im;
            y.re = x.re - im;
            return y;
        }

        //
        // Умножение комплексных чисел
        //
        public Complex Mult(Complex x)
        {
            Complex y = new Complex();
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }

        public double Im
        {
            get { return im; }
            set { if (value > 0) im = value; }
        }

        public string ToString()
        {
            return re + "+" + im + "i";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Complex complex1 = new Complex (1, 1);

            Complex complex2 = new Complex (3, 3);

            complex2.Im = 3;

            //
            // Демонстрация сложения
            //
            Console.WriteLine("Демонстрация сложения");
            Complex result = complex1.Plus(complex2);
            Console.WriteLine(result.ToString());
            Console.ReadKey();

            //
            // Демонстрация вычитания
            //
            Console.WriteLine("Демонстрация вычитания");
            result = complex1.Substrac(complex2);
            Console.WriteLine(result.ToString());
            Console.ReadKey();

            //
            // Демонстрация умножения
            //
            Console.WriteLine("Демонстрация умножения");
            result = complex1.Mult(complex2);
            Console.WriteLine(result.ToString());
            Console.ReadKey();
        }
    }
}
