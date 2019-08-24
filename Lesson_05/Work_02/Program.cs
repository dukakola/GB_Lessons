using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

// 2. Разработать класс Message, содержащий следующие статические методы для обработки
//    текста:
//    а) Вывести только те слова сообщения, которые содержат не более n букв.
//    б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
//    в) Найти самое длинное слово сообщения.
//    г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
// Продемонстрируйте работу программы на текстовом файле с вашей программой.

//Трифонов Александр

    // Не выполнил пункт Г

namespace Work_02
{
    class Message
    {
        private static string text;

        public Message()
        {
            text = "Чао, Буратины! Можете даже писать мне письма до востребования. Меня зовут Себастьян Перейра, торговец чёрным деревом. Шутка!";

            //Console.Write("Введите текст:");
            //text = Console.ReadLine();
        }

        // а) Вывести только те слова сообщения, которые содержат не более n букв.
        public static void MessageLength()
        {
            Console.WriteLine($"Дана строка: \n{text}");
            Console.Write($"Введите длину искомых слов: ");
            string SearchWords = Console.ReadLine();
            StringBuilder sb = new StringBuilder(text);

            string writePath = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
            StreamWriter sw = new StreamWriter(Path.Combine(writePath, "data.txt"), true, Encoding.Default);
            sw.WriteLine($"======{DateTime.Now}======");
            sw.WriteLine($"Ищем слова, которые содержат не более {SearchWords} букв");
            sw.WriteLine($"==========================");

            for (int i = 0; i < sb.Length;)
            {
                if (char.IsPunctuation(sb[i])) sb.Remove(i, 1);
                else ++i;
            }
            string str = sb.ToString();
            string[] s = str.Split(' ');

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Length <= Convert.ToInt32(SearchWords)) Console.WriteLine($"Искомое слово: {s[i]}. Длина слова = { s[i].Length}");
                sw.WriteLine($"Искомое слово: {s[i]}. Длина слова = { s[i].Length}");
            }
            sw.Close();
            Console.ReadLine();
        }

        // б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
        public static void MessageDeleteWords()
        {
            Console.WriteLine($"Дана строка: \n{text}");
            Console.Write($"\nВведите букву для удаление содержащих ее слов: ");
            string SearchWords = Console.ReadLine();
            StringBuilder sb = new StringBuilder(text);

            string writePath = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
            StreamWriter sw = new StreamWriter(Path.Combine(writePath, "data.txt"), true, Encoding.Default);
            sw.WriteLine($"======{DateTime.Now}======");
            sw.WriteLine($"Удаляем слова заканчивающиеся на букву '{SearchWords}'");
            sw.WriteLine($"==========================");

            for (int i = 0; i < sb.Length;)
            {
                if (char.IsPunctuation(sb[i])) sb.Remove(i, 1);
                else ++i;
            }
            string str = sb.ToString();
            string[] s = str.Split(' ');

            string regextext = @"[" + SearchWords + "]{1}\\b";
            Regex regex = new Regex(regextext, RegexOptions.IgnoreCase);

            for (int i = 0; i < s.Length; i++)
            {
                if (!regex.IsMatch(s[i])) Console.WriteLine(s[i]);
                sw.WriteLine($"Оставшиеся слова: {s[i]}");
            }
            Console.ReadLine();
            sw.Close();
        }

        //в) Найти самое длинное слово сообщения.
        public static void MessageMaxLength()
        {
            Console.WriteLine($"Дана строка: \n{text}");
            StringBuilder sb = new StringBuilder(text);

            string writePath = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
            StreamWriter sw = new StreamWriter(Path.Combine(writePath, "data.txt"), true, Encoding.Default);
            sw.WriteLine($"======{DateTime.Now}======");

            for (int i = 0; i < sb.Length;)
            {
                if (char.IsPunctuation(sb[i])) sb.Remove(i, 1);
                else ++i;
            }
            string str = sb.ToString();
            string[] s = str.Split(' ');
            string result = "";
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i].Length > result.Length)
                {
                    result = s[i];
                }
            }
            Console.WriteLine($"Самое длинное слово: {result}");
            Console.ReadLine();
            sw.WriteLine($"Самое длинное слово: {result}");
            sw.Close();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Message msg = new Message();

            Message.MessageLength();

            Message.MessageDeleteWords();

            Message.MessageMaxLength();
        }
    }
}
