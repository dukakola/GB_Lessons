using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
// 2.   а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). Требуется подсчитать сумму всех нечетных положительных чисел.Сами числа и сумму вывести на экран, используя tryParse;
//      б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.При возникновении ошибки вывести сообщение.Напишите соответствующую функцию;
//
//      Трифонов Александр
//
namespace CalcNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int result = 0;
            bool flag;
            Console.WriteLine("Введите число: ");

            do
            {
                flag = int.TryParse(Console.ReadLine(), out x);

                if (x > 0 & x % 2 == 1) result += x;
                else if (x < 0) throw new ArgumentException("Число должно быть положительным");
                else if (!flag) throw new ArgumentException("Необходимо ввести число (целое)");
            }
            while (!flag | x != 0);
            Console.WriteLine($"Сумма всех нечетных положительных чисел = {result}");
            Console.ReadKey();
        }
    }

}
