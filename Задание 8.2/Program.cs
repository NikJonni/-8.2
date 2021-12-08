using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задание_8._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "Для задание 8.2/Задание 8.txt";
            int sum = 0;
            if (!File.Exists(path))
                File.Create(path);
            int[] array = new int[10];
            Random random = new Random();
            StreamWriter sw = new StreamWriter(path, false);
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 100);
                sw.WriteLine("{0}", array[i]);
            }
            sw.Close();
            StreamReader sr = new StreamReader(path);
            int number;
            for (int i = 0; i < array.Length; i++)
            {
                number = Convert.ToInt32(sr.ReadLine());
                Console.WriteLine(number);
                sum = sum + number;
            }
            Console.WriteLine("Сумма равна = {0}",sum);
            Console.ReadKey();

        }
    }
}
