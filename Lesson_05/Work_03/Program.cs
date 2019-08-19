using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 3. * Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.Регистр можно не учитывать:
// а)   с использованием методов C#;
// б) * разработав собственный алгоритм.
//      Например:
//      badc являются перестановкой abcd.

//  Трифонов Александр

namespace Work_03
{
    class MyTry
    {
        static string text1;
        static string text2;
        public MyTry()
        {
            //Console.Write("Введите значение первой строки: "); 
            //text1 = Console.ReadLine();
            //Console.Write("Введите значение второй строки: ");
            //text2 = Console.ReadLine();
            text1 = "qwerty";
            text2 = "ytrewq";
        }
        public static void UseList()
        {
            //Свой алгоритм через лист.
            int count = 0;
            int counttotal = 0;

            List<int> mass1 = new List<int>();
            List<int> mass2 = new List<int>();

            foreach (int a in text1)
            {
                mass1.Add(a);
            }

            foreach (int a in text2)
            {
                mass2.Add(a);
            }

            mass1.Sort();
            mass2.Sort();

            if (mass1.Count == mass2.Count)
            {
                for (int i = 0; i < mass1.Count; i++)
                {
                    counttotal++;

                    if (mass1[i] == mass2[i])
                    {
                        count++;
                        mass1.Remove(i);
                        mass2.Remove(i);
                    }
                }

                if (counttotal - count == 0)
                {
                    Console.WriteLine("Строки палиндром (палиндромны)");
                }

                else
                {
                    Console.WriteLine("Строки не палиндром (не палиндромны)");
                }
            }
            else
            {
                Console.WriteLine("Строки не палиндром (не палиндромны)");
            }

            Console.WriteLine($"Колво повторных элементов = {count}, всего элементов в массиве {counttotal}, (всего элементов - совпадающие эелементы) = {counttotal - count}");
            Console.ReadLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyTry mytry = new MyTry();
            MyTry.UseList();
        }
    }
}
