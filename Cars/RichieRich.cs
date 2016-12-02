using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cars
{
    public class RichieRich
    {

        public static void TestMain()
        {
            //string[] tokens_n = Console.ReadLine().Split(' ');
            int n = 15;//Convert.ToInt32(tokens_n[0]);
            int k = 8;//Convert.ToInt32(tokens_n[1]);
            string number = "128392759430124";//Console.ReadLine();



            string max = "-1";
            if (ReverseString(number) == number)
            {
                max = number;
            }

            if (k == 0)
            {
                string unchanged = number;

                string unchangeReversed = ReverseString(unchanged);
                int numChangeRev = Convert.ToInt32(unchangeReversed);
                int numMaxRev = Convert.ToInt32(max);
                if (unchanged == unchangeReversed && numChangeRev >= numMaxRev) max = unchanged;
            }
            else if (k == 1)
            {//for k<=2
                for (int i = 0; i < n; i++)
                { //n=number of digits
                  //hold
                    for (int d = 0; d <= 9; d++)
                    { //9 to 0

                        string dig = "" + d;
                        char[] mynumber = number.ToCharArray();
                        mynumber[i] = dig[0];

                        string changed = new string(mynumber);

                        string changeReversed = ReverseString(changed);
                        int numChangeRev = Convert.ToInt32(changeReversed);
                        int numMaxRev = Convert.ToInt32(max);
                        if (changed == changeReversed && numChangeRev >= numMaxRev) max = changed;

                        ////start from i+1 ??
                        //for (int j = 0; j < n && k == 2; j++)
                        //{
                        //    if (j != i)
                        //    {
                        //        for (int dd = 0; dd <= 9; dd++)
                        //        { //9 to 0
                        //            dig = "" + dd;
                        //            //mynumber = number.ToCharArray();
                        //            mynumber[j] = dig[0];

                        //            changed = new string(mynumber);

                        //            changeReversed = ReverseString(changed);
                        //            numChangeRev = Convert.ToInt32(changeReversed);
                        //            numMaxRev = Convert.ToInt32(max);
                        //            if (changed == changeReversed && numChangeRev > numMaxRev) max = changed;

                        //        }
                        //    }
                        //}
                    }

                }
            }
            else if (k >= 2)
            {
                List<int> indices = new List<int>();
                for (int index = 0; index < n; index++)
                {
                    indices.Add(index);
                }

                var indexArr = indices.ToArray();
                var subsets = Subsets(indexArr, k);

                for (int ki = 2; ki <= k; ki++)
                {


                    var sb = new StringBuilder();
                    for (int s = 0; s < ki; s++)
                        sb.Append("0");

                    string initial = sb.ToString();

                    List<string> digits = new List<string>();
                    digits.Add(initial);

                    for (int di = 0; di < ki; di++)
                    {

                        List<string> temp = new List<string>();
                        temp = digits.ToList();
                        foreach (var t in temp)
                        {
                            string form = t;

                            for (int ti = 1; ti <= 9; ti++)
                            {
                                var formCopy = form.ToCharArray();
                                string tt = "" + ti;
                                formCopy[di] = tt[0];

                                string newform = new string(formCopy);

                                digits.Add(newform);
                            }
                        }

                    }

                    var kiSubsets = subsets.Where(s => s.Count == ki).ToList();

                    foreach (var sub in kiSubsets)
                    {
                        var numCopy = number.ToCharArray();
                        int dind = 0;
                        foreach (var ind in sub)
                        {
                            foreach (var digform in digits)
                            {
                                numCopy[ind] = digform[dind];
                            }
                            dind++;
                        }

                        ///

                        var numCopyString = new string(numCopy);

                        var changeReversed = ReverseString(numCopyString);
                        int numChangeRev = Convert.ToInt32(changeReversed);
                        int numMaxRev = Convert.ToInt32(max);
                        if (numCopyString == changeReversed && numChangeRev > numMaxRev) max = numCopyString;

                    }
                }
            }



            Console.WriteLine(max);

        }

        static List<List<int>> Subsets(int[] arr, int length)
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

                if (subSet.Count <= length)
                    subsetList.Add(subSet);

            }

            return subsetList;
        }

        static string ReverseString(string number)
        {
            char[] arr = number.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

    }
}
