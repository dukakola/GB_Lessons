using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

// 1. Создать программу, которая будет проверять корректность ввода логина.Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
//    а) без использования регулярных выражений;
//    б) с использованием регулярных выражений.

// Трифонов Александр

namespace Work_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //С использованием регулярных выражений
            try
            {
                do
                {
                    Console.Write("Введите логин: ");
                    string login = Console.ReadLine();
                    Regex regex = new Regex(@"\b[A-Za-z][A-Za-z0-9]{2,10}");
                    if (regex.IsMatch(login)) Console.WriteLine("Логин введен правильно.");
                    else Console.WriteLine("Логин введен не правильно.");

                } while (true);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Вызвано исключение: {ex}");
            }

            // Без использования регулярных выражений
            //TODO: Доделать проверку на вводт только латинских букв.
            try
            {
                do
                {
                    Console.Write("Введите логин:");
                    string logininput = Console.ReadLine();

                    if ((logininput[0] >= '0' && logininput[0] <= '9') || (logininput.Length < 2 || logininput.Length > 10))
                    {
                        Console.WriteLine($"Логин введен не правильно.");
                    }
                    else
                    {
                        Console.WriteLine($"Логин введен корректно.");
                    }
                } while (true);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Вызвано исключение: {ex}");
            }
        }
    }
}
