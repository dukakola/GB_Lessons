using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
// Трифонов Александр dukenukem2d@gmail.com
//
namespace Lesson_2
{
    
    class Program
    {
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("1. Задача №1");
            Console.WriteLine("2. Задача №2");
            Console.WriteLine("3. Задача №3");
            Console.WriteLine("4. Задача №4");
            Console.WriteLine("5. Задача №5");
            Console.WriteLine("6. Задача №6");
            Console.WriteLine("7. Задача №7");
            Console.WriteLine("0. Выход.");
            Console.WriteLine("----------------------");
            Console.Write("Введите номер задачи: ");
        }

        static void MenuReturn()
        {
            Console.WriteLine("----------------------");
            Console.Write("Для возврата в меню нажмите любую кнопку.");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            string menunum;

            do
            {
                Menu();
                menunum = Console.ReadLine();

                switch (menunum)
                {
                    case "1":
                        Task1();
                        break;

                    case "2":
                        Task2();
                        break;

                    case "3":
                        Task3();
                        break;

                    case "4":
                        Task4();
                        break;

                    case "5":
                        Task5();
                        break;

                    case "6":
                        Task6();
                        break;

                    case "7":
                        Task7();
                        break;

                    case "0":
                        Console.WriteLine("Завершение работы.");
                        break;

                    default:
                        Console.WriteLine("Что-то пошло не так...");
                        break;
                }
            }
            while (menunum != "0");
        }

        //1. Написать метод, возвращающий минимальное из трех чисел.
        static void Task1()
        {
            Console.Clear();
            Console.WriteLine("1. Написать метод, возвращающий минимальное из трех чисел.");
            Console.Write("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите третье число: ");
            int c = Convert.ToInt32(Console.ReadLine());

            int result;

                    if (a < b | a < c)
                    {
                        result = a;
                    }
                    else if (b < a | b < c)
                    {
                        result = b;
                    }
                    else
                    {
                        result = c;
                    }

            Console.WriteLine($"Меньшее число: {result}");

            MenuReturn();
        }

        //2. Написать метод подсчета количества цифр числа.
        static void Task2()
        {
            Console.Clear();
            Console.WriteLine("2. Написать метод подсчета количества цифр числа.");

            Console.Write("Введите число: ");

            string text = Console.ReadLine();

            int res = text.Length;

            Console.WriteLine($"Количество цифр в числе = {res}");

            MenuReturn();
        }

        //3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
        static void Task3()
        {
            Console.Clear();
            Console.WriteLine("С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.");

            int numbers = 0;
            int result = 0;

            while ((numbers = Convert.ToInt32(Console.ReadLine())) != 0)
                if (numbers % 2 == 1 & numbers > 0)
                {
                    result = result + numbers;
                };

            Console.WriteLine($"Сумма всех нечетных положительных чисел равна: {result}");

            MenuReturn();
        }

        //4. Реализовать метод проверки логина и пароля.На вход подается логин и пароль.На выходе истина, 
        //если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
        //Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, 
        //программа пропускает его дальше или не пропускает.С помощью цикла do while ограничить ввод пароля тремя попытками.
        static void Task4()
        {
            Console.Clear();
            Console.WriteLine("Реализовать метод проверки логина и пароля. На вход подается логин и пароль." +
                " На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains)." +
                " Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, " +
                " программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.");

            string login;
            string pass;
            int count = 0;

                do
                {

                    Console.Write("Введите логин: ");

                    login = Console.ReadLine();

                    Console.Write("Введите пароль: ");
                    pass = Console.ReadLine();

                    count++;
            
                }
                while (count <= 4 & login != "root" & pass != "GeekBrains");

            Console.WriteLine("Успешно!");

            MenuReturn();
        }

        //5. а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, 
        //      нужно ли человеку похудеть, набрать вес или все в норме;
        //   б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
        static void Task5()
        {
            Console.Clear();
            Console.WriteLine("Написать программу, которая запрашивает массу и рост человека, " + 
                " вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме.");

            int h;
            int m;
            double i;
            double result;
            Console.Write("Введите ваш вес(кг):");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите ваш рост(см): ");
            h = Convert.ToInt32(Console.ReadLine());
            i = m / (((double)h / 100) * ((double)h / 100));
            result = Math.Round(i, 2);

            Console.WriteLine("Ваш ИМТ: " + result);

            if (result <= 18.5)
            {
                Console.WriteLine("Недостаточный вес.");
            }
            else if (result > 18.5 & result < 24.9)
            {
                Console.WriteLine("Нормальная масса тела.");
            }
            else if (result > 25.0 & result < 29.9)
            {
                Console.WriteLine("Наличие лишнего веса.");
            }
            else if (result >= 30.0)
            {
                Console.WriteLine("Данный индекс является признаком ожирения.");
            }

            MenuReturn();
        }

        // Не выполнено.
        //
        //6. *Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000. 
        //    Хорошим называется число, которое делится на сумму своих цифр.
        //    Реализовать подсчет времени выполнения программы, используя структуру DateTime.
        static void Task6()
        {
            Console.Clear();
            Console.WriteLine("Задание не выполнено");
            DateTime start = DateTime.Now;
          

            DateTime finish = DateTime.Now;
            TimeSpan timespan = finish - start;
            Console.WriteLine("Затрачено времени: " + timespan);

            MenuReturn();
        }

        //7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b);
        //   б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
        static void Task7()
        {
            Console.Clear();
            Console.WriteLine("Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b); " +
                 " *Разработать рекурсивный метод, который считает сумму чисел от a до b.");

            Loop(0);

            MenuReturn();
        }

        static void Loop(int a)
        {
            int b = 100;

            if (a < b)
            {
                Console.WriteLine(a);
                int result = (a + a);
                Console.WriteLine($"Сумма чисел: {a} + {a} = {result}");
               
                Loop(a + 1);
                
            }
        }
    }
}


            