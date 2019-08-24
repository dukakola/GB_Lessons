using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 4. Задача ЕГЭ.

// Трифонов Александр

// Не выполнено
namespace Work_04
{
    class Students
    {
        static string FileList;
        static string ReadPath;
        static string[] a;

        public Students()
        {
            FileList = "";
            ReadPath = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
            a = new string[3];
        }

        public static void ReadFile()
        {
            StreamReader sr = new StreamReader(Path.Combine(ReadPath, "students.txt"));
            string n = sr.ReadLine();
            for(int i = 0; i < n.Length; i++)
            {
                FileList = sr.ReadLine();
                a[i] = FileList;
                Console.WriteLine(a[i]);
            }
            sr.Close();
        }

        public static void StudentsArray()
        {
            for (int i = 0; i < a.Length; i++)
            {
                
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Students students = new Students();

            Students.ReadFile();
            
        }
    }
}
