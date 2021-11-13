using System;
using System.IO;

namespace lesson5 
{
    class Program
    {   //new Message
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст");
            var text = Console.ReadLine();
            string filename = "text.txt";
            File.WriteAllText(filename, text);
            //добавим дату в файл
        }

    }
}
