using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HomeWork7
{
    struct Diary
    {
        /// <summary>
        /// Дата записи
        /// </summary>
        public DateTime DateOfDiary;
        /// <summary>
        /// Задание
        /// </summary>
        public string Exercise;
        /// <summary>
        /// Необходимое количество персонала
        /// </summary>
        public int RequiredNumberOfPerson;
        /// <summary>
        /// Количество персонала в наличии
        /// </summary>
        public int NumberOfStaffAvailable;
        /// <summary>
        /// Срок выполнения
        /// </summary>
        public DateTime Deadline;
        /// <summary>
        /// Добавить запись
        /// </summary>
        public static void Create()
        {
            Console.Write("Количество записей: "); int number = int.Parse(Console.ReadLine());
            using (StreamWriter sw = new StreamWriter("diary.txt", true))
            {
                for (int i = 0; i < number; i++)
                {
                    Console.Write("Дата записи (формат - год.месяц.число): "); sw.WriteLine($"{Console.ReadLine()}");
                    Console.Write("Задание: "); sw.WriteLine($"{Console.ReadLine()}");
                    Console.Write("Необходимое количество персонала: "); sw.WriteLine($"{Console.ReadLine()}");
                    Console.Write("Количество персонала в наличии: "); sw.WriteLine($"{Console.ReadLine()}");
                    Console.Write("Срок выполнения (формат - год.месяц.число): "); sw.WriteLine($"{Console.ReadLine()}");
                    Console.WriteLine();
                }
            }
        }
        /// <summary>
        /// Удалить запись
        /// </summary>
        public static void Delete()
        {
            int j = 1;
            using (StreamReader sr = new StreamReader("diary.txt"))
            {
                while (sr.ReadLine() != null) j++;
            }

            Diary[] record = new Diary[j / 5];

            using (StreamReader sr = new StreamReader("diary.txt"))
            {
                for (int i = 0; i < j / 5; i++)
                {
                    record[i].DateOfDiary = Convert.ToDateTime(sr.ReadLine());
                    record[i].Exercise = sr.ReadLine();
                    record[i].RequiredNumberOfPerson = int.Parse(sr.ReadLine());
                    record[i].NumberOfStaffAvailable = int.Parse(sr.ReadLine());
                    record[i].Deadline = Convert.ToDateTime(sr.ReadLine());
                }
            }

            Console.WriteLine("№   |Дата записи       |Задание                            |Необходимое         |Количество         |Срок выполнения  ");
            Console.WriteLine("    |                  |                                   |количество персонала|персонала в наличии|");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            for (int i = 0; i < j / 5; i++)
            {
                Console.WriteLine($"{i + 1, 4}|{record[i].DateOfDiary,17}|{record[i].Exercise, 35}|{record[i].RequiredNumberOfPerson, 20}|{record[i].NumberOfStaffAvailable,19}|{record[i].Deadline}");
                //Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Номер строки                   1");
            Console.WriteLine("Задание                        2");
            Console.WriteLine("Количество персонала в наличии 3");
            Console.WriteLine("Срок выполнения                4");
            Console.Write("Выберите запись для удаления по номеру или полю: "); int measurement = int.Parse(Console.ReadLine());
            switch (measurement)
            {
                case 1:
                    Console.Write("Введите номер строки: "); int n = int.Parse(Console.ReadLine());
                    for (int i = 0; i < j/5; i++)
                    {
                        if (i + 1 == n)
                        {
                            record[i].Exercise = "";
                        }
                    }
                    using (StreamWriter sw = new StreamWriter("diary.txt"))
                    {
                        for (int i = 0; i < j/5; i++)
                        {
                            if (record[i].Exercise != "")
                            {
                                sw.WriteLine($"{record[i].DateOfDiary}");
                                sw.WriteLine($"{record[i].Exercise}");
                                sw.WriteLine($"{record[i].NumberOfStaffAvailable}");
                                sw.WriteLine($"{record[i].RequiredNumberOfPerson}");
                                sw.WriteLine($"{record[i].Deadline}");
                            }
                        }
                    }
                    break;
                case 2:
                    Console.Clear();
                    Console.Write("Введите задание: "); string s = Console.ReadLine();
                    
                    break;
                case 3:
                    Console.Clear();
                    break;
                case 4:
                    Console.Clear();
                    break;
                default:
                    break;
            }





        }
        /// <summary>
        /// Редактировать запись
        /// </summary>
        public static void Edit()
        {

        }
    }
}
