﻿using System;
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
            }
            Console.WriteLine();
            Console.WriteLine("1. Номер строки");
            Console.WriteLine("2. Задание");
            Console.WriteLine("3. Количество персонала в наличии");
            Console.WriteLine("4. Срок выполнения");
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
                    //Console.Clear();
                    Console.Write("Введите задание: "); string s = Console.ReadLine();
                    for (int i = 0; i < j / 5; i++)
                    {
                        if (s == record[i].Exercise)
                        {
                            record[i].Exercise = "";
                        }
                    }
                    using (StreamWriter sw = new StreamWriter("diary.txt"))
                    {
                        for (int i = 0; i < j / 5; i++)
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
                case 3:
                    //Console.Clear();
                    Console.Write("Введите количество персонала в наличии: "); int k = int.Parse(Console.ReadLine());
                    for (int i = 0; i < j / 5; i++)
                    {
                        if (k == record[i].RequiredNumberOfPerson)
                        {
                            record[i].Exercise = "";
                        }
                    }
                    using (StreamWriter sw = new StreamWriter("diary.txt"))
                    {
                        for (int i = 0; i < j / 5; i++)
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
                case 4:
                    //Console.Clear();
                    Console.Write("Введите срок выполнения ф формате yyyy.mm.dd: "); DateTime date = Convert.ToDateTime(Console.ReadLine());
                    for (int i = 0; i < j / 5; i++)
                    {
                        if (date == record[i].Deadline)
                        {
                            record[i].Exercise = "";
                        }
                    }
                    using (StreamWriter sw = new StreamWriter("diary.txt"))
                    {
                        for (int i = 0; i < j / 5; i++)
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
                default:
                    break;
            }
        }
        /// <summary>
        /// Редактировать запись
        /// </summary>
        public static void Edit()
        {
            Console.Clear();
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
            Console.WriteLine("    |1                 |2                                  |3                   |4                  |5");
            Console.WriteLine("№   |Дата записи       |Задание                            |Необходимое         |Количество         |Срок выполнения");
            Console.WriteLine("    |                  |                                   |количество персонала|персонала в наличии|");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            for (int i = 0; i < j / 5; i++)
            {
                Console.WriteLine($"{i + 1,4}|{record[i].DateOfDiary,17}|{record[i].Exercise,35}|{record[i].RequiredNumberOfPerson,20}|{record[i].NumberOfStaffAvailable,19}|{record[i].Deadline}");
            }
            Console.WriteLine();
            Console.WriteLine("Введите номер записи для редактирования: "); int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер поля для редактирования (кроме 1): ");  int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите новое значение поля: "); string s = Console.ReadLine(); 
            if (m == 2) record[n - 1].Exercise = s;
            if (m == 3) record[n - 1].RequiredNumberOfPerson = int.Parse(s);
            if (m == 4) record[n - 1].NumberOfStaffAvailable = int.Parse(s);
            if (m == 5) record[n - 1].Deadline = Convert.ToDateTime(s);
            using (StreamWriter sw = new StreamWriter("diary.txt"))
            {
                for (int i = 0; i < j / 5; i++)
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
            Console.WriteLine("Значение изменено");
        }
        /// <summary>
        /// Сортировка по полю
        /// </summary>
        public static void Sort()
        {
            Console.Clear();
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
            Console.WriteLine("    |1                 |2                                  |3                   |4                  |5");
            Console.WriteLine("№   |Дата записи       |Задание                            |Необходимое         |Количество         |Срок выполнения");
            Console.WriteLine("    |                  |                                   |количество персонала|персонала в наличии|");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            for (int i = 0; i < j / 5; i++)
            {
                Console.WriteLine($"{i + 1,4}|{record[i].DateOfDiary,17}|{record[i].Exercise,35}|{record[i].RequiredNumberOfPerson,20}|{record[i].NumberOfStaffAvailable,19}|{record[i].Deadline}");
            }
            Console.WriteLine();
            Console.WriteLine("Введите номер поля для сортировки записей по нему (кроме 1, 2, 3): "); int m = int.Parse(Console.ReadLine());
            if (m == 4) Array.Sort(record, new Comparison<Diary>((a,b) => a.RequiredNumberOfPerson.CompareTo(b.RequiredNumberOfPerson)));
            if (m == 5) Array.Sort(record, new Comparison<Diary>((a, b) => a.Deadline.CompareTo(b.Deadline)));
            using (StreamWriter sw = new StreamWriter("diary.txt"))
            {
                for (int i = 0; i < j / 5; i++)
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
        }
        /// <summary>
        /// Выгрузка всех записей из файла
        /// </summary>
        public static void Print()
        {
            Console.Clear();
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
            Console.WriteLine("    |1                 |2                                  |3                   |4                  |5");
            Console.WriteLine("№   |Дата записи       |Задание                            |Необходимое         |Количество         |Срок выполнения");
            Console.WriteLine("    |                  |                                   |количество персонала|персонала в наличии|");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            for (int i = 0; i < j / 5; i++)
            {
                Console.WriteLine($"{i + 1,4}|{record[i].DateOfDiary,17}|{record[i].Exercise,35}|{record[i].RequiredNumberOfPerson,20}|{record[i].NumberOfStaffAvailable,19}|{record[i].Deadline}");
            }
            Console.ReadKey();
        } 
        /// <summary>
        /// Вывод списка по диапазону дат
        /// </summary>
        public static void ListByDate()
        {
            Console.Clear();
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
            Console.WriteLine("Введите диапазон сроков выполнения");
            Console.WriteLine("Начальное значение  в формате yyyy.mm.dd: "); DateTime dateStart = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Конечное значение  в формате yyyy.mm.dd: "); DateTime dateEnd = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("№   |Дата записи       |Задание                            |Необходимое         |Количество         |Срок выполнения");
            Console.WriteLine("    |                  |                                   |количество персонала|персонала в наличии|");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            for (int i = 0; i < j / 5; i++)
            {
                if (dateStart <= record[i].Deadline && dateEnd >= record[i].Deadline)
                {
                    Console.WriteLine($"{i + 1,4}|{record[i].DateOfDiary,17}|{record[i].Exercise,35}|{record[i].RequiredNumberOfPerson,20}|{record[i].NumberOfStaffAvailable,19}|{record[i].Deadline}");
                }
            }
            Console.ReadKey();
        }
    }
}
