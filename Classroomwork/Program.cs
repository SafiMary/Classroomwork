using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Classroomwork
{
    internal class Program
    {
     
        static string FileReader()
        {
            var streamReader = new StreamReader("test.txt");//читаем весь файл
            string result = string.Empty;
            result = streamReader.ReadToEnd();
            streamReader.Close();
            return result;
        }
        static void SaveToFile(string _path, string _text)
        {
            string myDoc =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            Console.WriteLine(myDoc);
            try
            {
                StreamWriter sw = new StreamWriter(_path, true);
                sw.WriteLine(_text);
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

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
                    Console.WriteLine("аргументы не переданны");
                }

            FileReader();
            string[] numwords = {"один", "два", "три", "четыре", "пять", "шесть",
  "семь", "восемь", "девять", "десять" };//массив с значениями

             var result = Regex.Replace(input, "[0-9]+", m =>
             string.Join(", ", m.Value.Select(c => numwords[c - '0'])));

             /*Console.Write(result);
            input = input.Replace("some text", "new value");
             File.WriteAllText("test2.txt", input);
              +DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".jpg";*/
          

            }
        }
    }

