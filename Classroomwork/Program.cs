using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.Remoting.Messaging;
using System.Xml.Linq;

namespace Classroomwork
{
    internal class Program
    {
     
        static string FileRead_Replace(string _path)
        {
            var streamReader = new StreamReader(_path);//читаем весь файл
            string result = string.Empty;//считываем файл в строку
            result = streamReader.ReadToEnd();//считываем файл в строку
            var digits = new Dictionary<string, string> {//словарь с нашими выражениями
    { "0", "ноль" },
    { "1", "один" },
    { "2", "два" },
    { "3", "три" },
    { "4", "четыре" },
    { "5", "пять" },
    { "6", "шесть" },
    { "7", "семь" },
    { "8", "восемь" },
    { "9", "девять" },
    { "10", "десять" },
    { "11", "одиннадцать" },
    { "12", "двеннадцать" },
 };         
            Console.Write($"Считываем файл {result}\n");
            result = Regex.Replace(result, @"\d+", x => digits[x.Value]);//замена
            streamReader.Close();//закрыли файл
            Console.Write($"Проведена замена на: {result}\n");
            return result;
        }
        static void SaveToFile(string _text)
        {
           
                    File.WriteAllText($"test2-" + DateTime.Now.ToString("dd.MM.yyyy_hh.mm.ssss") + ".txt", _text);//сохранение файла
                    Console.Write($"Результат записи в файл {_text}");//вывести на экран результат сохранения файлa

            }

      
 
        static void Main(string[] args)
        {

            string input = "test.txt";
            if (args.Length > 0)
            {
                input = args[0];
            }
            else
            {
                Console.WriteLine("Аргументы не переданы. Попробуйте еще раз ввести аргументы через командную строку");
            }
           
            SaveToFile(FileRead_Replace(input));



        }
    }
    }

