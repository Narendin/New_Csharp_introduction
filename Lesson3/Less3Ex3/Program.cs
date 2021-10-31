using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Less3Ex3
{
    /*
        Долгуев Владимир.
        3. * Работа со строками.
        Дан текстовый файл, содержащий ФИО и e-mail адрес.
        Разделителем между ФИО и адресом электронной почты является символ "&":
        Кучма Андрей Витальевич & Kuchma@mail.ru
        Мизинцев Павел Николаевич & Pasha@mail.ru
        Сформировать новый файл, содержащий список адресов электронной почты.
        Предусмотреть метод, выделяющий из строки адрес почты.
        Методу в качестве параметра передается символьная строка s, e-mail возвращается в той же строке s: public void SearchMail (ref string s).
     */

    internal class Program
    {
        private static void Main()
        {
            try
            {
                FileStream fs = new FileStream("Data.txt", FileMode.Open);

                List<string> eMailList = new List<string>();

                using (StreamReader sr = new StreamReader(fs))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        SearchMail(ref line);
                        if (!line.Equals(""))
                        {
                            eMailList.Add(line);
                        }
                    }
                }

                if (eMailList.Any())
                {
                    fs = new FileStream("eMails.txt", FileMode.Truncate); // До дальнейших указаний файл перезаписываем
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        foreach (var eMail in eMailList)
                        {
                            sw.WriteLine(eMail);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Возникла следующая ошибка при выполнении программы:");
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Для выхода из программы нажмите любую клавишу");
                Console.ReadKey();
            }
        }

        public static void SearchMail(ref string s)
        {
            var parts = s.Split('&');

            if (parts.Length != 2)
            {   // тут должно быть логирование строк с неверным форматом всей строки
                s = string.Empty;
                return;
            }

            string pattern = @"\w*@\w*.\w*";

            if (Regex.IsMatch(parts[1], pattern, RegexOptions.IgnoreCase))
            {
                s = parts[1].Trim();
            }
            else
            {
                // тут должно быть логирование строк с неверным форматом адреса e-mail
                s = string.Empty;
            }
        }
    }
}