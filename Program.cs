
using System;
using System.Linq;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace lesson5 
{
    class Program
    {   
        static void Main(string[] args)
        {
            //добавим файл startup.txt

            Console.WriteLine("Введите текст");
            var text = Console.ReadLine();
            string filename = "startup.txt";
            File.WriteAllText(filename, text);

            //добавим дату

            string time = ("\t" + DateTime.Now.ToString("HH:mm:ss"));
            string filetime = "time.txt";
            File.WriteAllText(filetime, time);
            File.AppendAllLines("startup.txt", File.ReadLines("time.txt"));
            Console.WriteLine("\n\t\t***\n");

            //добавим бинарный файл

            Console.WriteLine("Введите произвольный набор чисел (0...255)");
            var house = Console.ReadLine().Split( ' ').Select(byte.Parse).ToArray();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(new FileStream("house.bin", FileMode.OpenOrCreate), house);
        }

    }
}
