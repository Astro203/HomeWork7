using System;
using System.Globalization;
using System.IO;

namespace HomeWork7
{
    class Program
    {
        static void Main(string[] args)
        {
            int measurement = 0;
            bool f = true;
            do
            {
                Console.Clear();
                Console.WriteLine("1. Добавить запись");
                Console.WriteLine("2. Удалить запись");
                Console.WriteLine("3. Редактировать запись");
                Console.WriteLine("4. ");
                Console.WriteLine();
                Console.Write("Выберите номер действия: "); measurement = int.Parse(Console.ReadLine());
                switch (measurement)
                {
                    case 1:
                        Console.Clear();
                        Diary.Create();
                        break;
                    case 2:
                        Console.Clear();
                        Diary.Delete();
                        break;
                    case 3:
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        break;
                    default:
                        f = false;
                        break;
                }
            } while (f);
        }
    }
}
