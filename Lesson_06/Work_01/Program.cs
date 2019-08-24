using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. Изменить программу вывода функции так, чтобы можно было передавать функции типа double (double, double). Продемонстрировать работу на функции с функцией a* x^2 и функцией a* sin(x).

// Трифонов Александр

// Задачу выполнил не совсем по описанию, т.к. школьный курс по математике успешно забыт, но идею с делегатами осознал.
// Вынес для себя слабые свои слабые стороны - буду развивать.

namespace DoubleBinary
{
    delegate double F(double x, double y);
    class Program
    {
        F f;

        public Program(F f)
        {
            this.f = f;
        }
        public double F(double x, double y)
        {
            return f.Invoke(x, y);
        }

        public void SaveFunc(string fileName, double x, double b, double h, double y)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            while (x <= b)
            {
                bw.Write(f(x,y));
                x += h;
            }
            bw.Close();
            fs.Close();
        }
        public static double Load(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return min;
        }
        static void Main(string[] args)
        {
            Program program = new Program(Math.Max);
            Console.WriteLine(program.F(3,10)); //Нахождение максимального числа

            program = new Program(Math.Pow);
            Console.WriteLine(program.F(3, 2)); //Возведение в степень

            program.SaveFunc("data.bin", 110, 100, 0.5, 5);
            Console.WriteLine(Load("data.bin"));
            Console.ReadKey();
        }
    }
}

