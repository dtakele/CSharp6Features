using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "";
            while (true)
            {
                var ck = Console.ReadKey(true);
                Console.Write("*");
                if (ck.Key == ConsoleKey.Enter)
                    break;
                input += ck.KeyChar;
                

            }
            Console.WriteLine(input);

            //var cars = ProcessFile("fuel.csv");

            //            foreach (var car in cars)
            //            {
            //                Console.WriteLine(car.Name);
            //            }
        }

        private static List<Car> ProcessFile(string path)
        {
            return
                File.ReadAllLines(path)
                .Skip(1)
                .Where(line => line.Length > 1)
                .Select(Car.ParseFromCsv)
                .ToList();

            //            var query = from line in File.ReadAllLines(path).Skip(1)
            //                where line.Length > 1
            //                select Car.ParseFromCsv(line);
            //
            //            return query.ToString();
        }
    }
}
