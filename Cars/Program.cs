using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Cars
{
    class Program
    {
        static List<List<int>> Subsets(int[] arr, int length)
        {
            List<List<int>> subsetList = new List<List<int>>();

            foreach (var s in subsetList)
            {
                var sum = s.Sum(i => i);
            }

            int[] nums = arr;

            int b = nums.Length;
            int n = (int)Math.Pow(2, b);

            for (int num = 0; num < n; num++)
            {
                var subSet = new List<int>();

                for (int bit = 0; bit <= b; bit++)
                {
                    if ((num >> bit & 1) == 1)
                    {
                        subSet.Add(nums[bit]);
                    }
                }

                if (subSet.Count == length)
                    subsetList.Add(subSet);

            }

            int mk = 10;
            var sb = new StringBuilder();
            for (int s = 0; s < mk; s++)
                sb.Append("0");

            string initial = sb.ToString();

            List<string> digits = new List<string>();
            digits.Add(initial);

            for (int di = 0; di < mk; di++)
            {

                List<string> temp = new List<string>();
                temp = digits;
                foreach (var t in temp)
                {
                    string form = t;

                    for (int ti = 1; ti <= 9; ti++)
                    {
                        var formCopy = form.ToCharArray();
                        formCopy[di] = Convert.ToChar(ti);

                    }
                }

            }


            return subsetList;
        }
        static void Main(string[] args)
        {

            string T = Console.ReadLine();
            int t = Convert.ToInt32(T);
            int[] b = new int[t];

            int[] AK = new int[t];
            for (int i = 0; i < t; i++)
            {
                b[i] = Convert.ToInt32(Console.ReadLine());
                string[] tokens_n = Console.ReadLine().Split(' ');
                int ak = 0;
                int[][] S = new int[b[i]][];
                S[i] = new int[b[i]];
                for (int j = 0; j < tokens_n.Length; j++)
                {
                    int tp = Convert.ToInt32(tokens_n[j]);
                    S[i][j] = tp;
                    ak += tp;
                }
                AK[i] = ak;

            }

            if (AK[0] >= AK[1])
            {
                Console.WriteLine("Sandy");
            }
            else
            {
                Console.WriteLine("Manasa");
            }

            //RichieRich.TestMain();
            string str = "abc";
            var ask = (int)str[0];

            if (ask == 97)
            {
                Console.WriteLine();
            }

            int n = 8;
            int k = 2;
            string number = "11119111";

            Palindrome.PalindromeNumberConverter(n, k, number);

            //PalindromFromFile();


            /*

            int[] nums = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            string[] fruits = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            var subsetlist = Subsets(nums, 3);
            foreach (var subSet in subsetlist)
            {
                Console.WriteLine("{{{0}}}", string.Join(", ", subSet.Select(i => fruits[i])));
            }

            */



            //var input = "";
            //while (true)
            //{
            //    var ck = Console.ReadKey(true);
            //    Console.Write("*");
            //    if (ck.Key == ConsoleKey.Enter)
            //        break;
            //    input += ck.KeyChar;
            //}
            //List<string> sList = new List<string>();
            //Console.WriteLine(input);
            //int[] arr=new int[3];
            //int k=arr.Length;
            //int pd = 2, sd = 6;
            //int absDiff = Math.Abs(pd - sd);
            //string ks = "dafd";
            //int c=ks.Length;
            //char ch = Convert.ToChar(pd);

            //string number = "3933";
            //int nn = 4;

            //string reversed = ReverseString(number);
            //string max = "-1";

            //for (int i = 0; i < n; i++)
            //{ //n=number of digits
            //    for (int d = 0; d <= 9; d++)
            //    { //9 to 0
            //        string dig = "" + d;
            //        char[] mynumber = number.ToCharArray();
            //        mynumber[i] = dig[0];


            //        string changed = new string(mynumber);

            //        string changeReversed = ReverseString(changed);
            //        int numChangeRev = Convert.ToInt32(changeReversed);
            //        int numMaxRev = Convert.ToInt32(max);
            //        if (changed == changeReversed && numChangeRev > numMaxRev) max = changed;

            //    }
            //}

            //var cars = ProcessFile("fuel.csv");

            //            foreach (var car in cars)
            //            {
            //                Console.WriteLine(car.Name);
            //            }


            string[] arr = Console.ReadLine().Split(' ');
            var asIntegers = arr.Select(s => int.Parse(s)).ToArray();
            List<List<int>> subsets = Subsets(asIntegers, 4);

            BigInteger min = asIntegers[0], max = asIntegers[0];

            bool changedOnce = false;

            foreach (var s in subsets)
            {
                BigInteger sum = SumList(s);
                if (changedOnce == false)
                {
                    min = max = sum;
                    changedOnce = true;
                }
                else
                {
                    if (sum < min) min = sum;
                    if (sum > max) max = sum;

                }
            }

            Console.WriteLine(min + " " + max);

        }

        static BigInteger SumList(List<int> subsets)
        {
            BigInteger sum = 0;

            foreach (var s in subsets)
            {
                sum += s;
            }

            //int sum = subsets.Sum(i => i);


            return sum;
        }

        static List<List<int>> Subsetss(int[] arr, int length)
        {
            List<List<int>> subsetList = new List<List<int>>();

            int[] nums = arr;

            int b = nums.Length;
            int n = (int)Math.Pow(2, b);

            for (int num = 0; num < n; num++)
            {
                var subSet = new List<int>();

                for (int bit = 0; bit <= b; bit++)
                {
                    if ((num >> bit & 1) == 1)
                    {
                        subSet.Add(nums[bit]);
                    }
                }

                if (subSet.Count == length)
                    subsetList.Add(subSet);

            }

            return subsetList;
        }

        static void PalindromFromFile()
        {
            int n = 0;
            int k = 0;
            string number = "";

            string[] lines;
            var list = new List<string>();
            var fileStream = new FileStream(@"c:\bigdata\input10.txt", FileMode.Open, FileAccess.Read);
            int linenum = 0;
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {

                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    if (linenum++ == 0)
                    {
                        var str = line.Split(' ');
                        n = Convert.ToInt32(str[0]);
                        k = Convert.ToInt32(str[1]);
                    }
                    else
                    {
                        number += line;
                    }
                }
            }

            Palindrome.PalindromeNumberConverter(n, k, number);


        }

        static string ReverseString(string number)
        {
            char[] arr = number.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
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
