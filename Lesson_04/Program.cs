using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Трифонов Александр

// 1. Дан целочисленный массив из 20 элементов.Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно.Написать программу, 
//    позволяющую найти и вывести количество пар элементов массива, в которых хотя бы одно число делится на 3. 
//    В данной задаче под парой подразумевается два подряд идущих элемента массива.Например, для массива из пяти элементов: 6; 2; 9; –3; 6 – ответ: 4.


// 2.  а) Дописать класс для работы с одномерным массивом. Реализовать конструктор, создающий массив заданной размерности и заполняющий массив числами от начального 
//        значения с заданным шагом.Создать свойство Sum, которые возвращают сумму элементов массива, метод Inverse, 
//        меняющий знаки у всех элементов массива, метод Multi, умножающий каждый элемент массива на определенное число, свойство MaxCount, 
//        возвращающее количество максимальных элементов. В Main продемонстрировать работу класса.
//     б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.

// Объединил 1 и 2 задачи в одну. Не успел выполнить п.2 б) и п.3.

namespace Work_01
{
    class ArrayCalc
    {
        int[] array;

        public ArrayCalc(int n, int min, int max)
        {
            array = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(min, max);
            }
        }

        public override string ToString()
        {
            string s = "";
            foreach (int v in array)
                s = s + v + "\n";
            return s;
        }

        public int CountPair
        {
            get
            {
                int countpair = 0;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] % 3 == 0 | array[i + 1] % 3 == 0)
                    {
                        countpair++;
                    }
                }
                return countpair;
            }
        }

        public int Sum
        {
            get
            {
                int sum = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                }
                return sum;
            }
        }

        public int Multi()
        {
            int x = 10;
            int multi = 0;
            for (int i = 0; i < array.Length; i++)
            {
                multi = array[i] * x;
                Console.WriteLine(multi);
            }
            return multi;
        }

        public int MaxCount
        {
            get
            {
                int x = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] > x)
                    {
                        x = array[i];
                    } 
                }  
                return x;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayCalc ac = new ArrayCalc(20,10,50);

            Console.WriteLine("Массив чисел");

            Console.WriteLine(ac.ToString());

            Console.WriteLine($"Количество пар: {ac.CountPair}\n");

            Console.WriteLine($"Сумма элементов массива: {ac.Sum}");

            Console.WriteLine("\nУмножение всех элементов массива на 10\n");

            ac.Multi();

            Console.WriteLine($"\nМаксимальное значение в массиве {ac.MaxCount}");

            Console.ReadLine();
        }
    }
}
