using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CSharp6Features
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee[] developers = new Employee[]
            {
                new Employee {Name = "Dejene", Id = 1}, new Employee {Name = "Scott", Id = 2}
            };

            List<Employee> sales = new List<Employee>()
            {
                new Employee { Id=3, Name = "Chris"}
            };

            Console.WriteLine(developers.Count());

            foreach (var person in developers.Where(
                e => e.Name.StartsWith("S")
                ))
            {
                Console.WriteLine(person.Name);

            }

            //            string path = @"C:\windows";
            //            Console.WriteLine("*****");
            //            ShowLargeFilesWithLinq(path);
            //
            //            GetValues();
        }

        private static bool StartsWithS(Employee employee)
        {
            return employee.Name.StartsWith("S");
        }

        private static void ShowLargeFilesWithLinq(string path)
        {
            var query = from file in new DirectoryInfo(path).GetFiles()
                        orderby file.Length descending
                        select file;

            foreach (var file in query.Take(5))
            {
                Console.WriteLine($"{file.Name,-20}:{file.Length,10:N0}");
            }


        }

        private static void GetValues()
        {
            MyClass mc = new MyClass();

            Console.WriteLine(mc.Id);
            mc.Id = Guid.NewGuid();

            Console.WriteLine(mc.Id);
        }
    }
}
