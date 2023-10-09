﻿using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // строки в c#
            // ссылочный тип данных
            string str  = "привет";
            string str1 = str;
            string str2 = "привет";
            // строки являются неизменяемыми объектами
            //str[0] = ' '; // так нельзя!
            char ch = str[0];
            // строка работает как массив символов
            // но только для чтения
            string anotherString = str.Replace('п', 'p');
            Console.WriteLine(str);
            Console.WriteLine(anotherString);
            // извлечение подстроки
            anotherString = str.Substring(3);
            Console.WriteLine(anotherString);
            anotherString = str.Substring(3, 2);
            Console.WriteLine(anotherString);

            // сравнение строк -1 0 1
            int result = str.CompareTo(str1);
            if (str == str1) // сравнение на равенство
            { }
            // F != f
            // удаление подстроки
            anotherString = str.Remove(4);
            Console.WriteLine(anotherString);
            anotherString = str.Remove(2,2);
            Console.WriteLine(anotherString);

            // проверка на включение подстроки в строку
            bool bResult = str.Contains(str1);
            // проверка на то, что строка завершается подстрокой
            bResult = str.EndsWith(str1);
            bResult = str.StartsWith(str1);

            // Trim позволяет вырезать определенные символы
            // в начале и/или в конце строки
            str.Trim(); 
            str.TrimEnd();
            str.TrimStart('Y');

            // позволяет узнать индекс для подстроки или символа
            // если такой подстроки нет, выдает -1
            int index = str.IndexOf(str1);
            index = str.IndexOf('п');
            str.LastIndexOf(anotherString);

            // вставка подстроки в строку по указанному индексу
            anotherString = str.Insert(3, "рррр");
            Console.WriteLine(anotherString);

            // кол-во символов
            int count = str.Length; 

            // удлиннение строки до заданной длины путем добавления
            // указанных символов слева или справа
            str.PadLeft(30, ' ');
            str.PadRight(30, ' ');

            // изменение регистра символов
            str.ToLower();
            str.ToUpper();

            // деление строки на подстроки, возвращает массив подстрок
            string[] array = str.Split();

            char[] splitter = new char[] { '.', ',', '?', ' ' };
            string message = "Goodbuy, hell world.";
            array = message.Split(splitter);
            Console.WriteLine(JsonSerializer.Serialize(array));
            // StringSplitOptions.RemoveEmptyEntries удаляет 
            // пустые подстроки (без символов)
            array = message.Split(splitter, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(JsonSerializer.Serialize(array));
            // сложение строк
            anotherString = str + str1 + str;

            // интерполяция
            anotherString = $"{str}{str1}{str2}{str}";
            // строитель строки
            StringBuilder sb = new StringBuilder();
            sb.Append(anotherString).AppendLine("Привет");
            sb.Remove(3, 5).
                Append('t').
                Append('e');
            sb.Replace("при", "вет");
            anotherString = sb.ToString(); // получение результата
            Console.WriteLine(anotherString);

            // 8 задание может выглядеть так:
            string start = Console.ReadLine();
            sb.Clear();// очистка билдера
            for (int i = 0; i < start.Length; i++)
            { 
                if (start[i] != '*')
                    sb.Append(start[i]).Append(start[i]);
            }
            string result8 = sb.ToString();
            Console.WriteLine(result8);
        }
    }
    
}