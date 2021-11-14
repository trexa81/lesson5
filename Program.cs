using System;
using System.IO;

namespace lesson5 
{
    class Program
    {   //new Message
        static void Main(string[] args)
        {
            //добавим файл
            Console.WriteLine("Введите текст");
            var text = Console.ReadLine();
            string filename = "text.txt";
            File.WriteAllText(filename, text);
                        //добавим дату

            string time = DateTime.Now.ToString();
            string filetime = "startup.txt";
            File.WriteAllText(filetime, time);
        }

    }
}
