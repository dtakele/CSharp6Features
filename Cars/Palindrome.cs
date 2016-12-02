using System;
using System.Text;

namespace Cars
{
    class Palindrome
    {


        public static void PalindromeNumberConverter(int n, int k, string number)
        {
            int changesNeeded = 0;

            int halfLength = n % 2 == 0 ? n / 2 : n / 2 + 1;

            var sb = new StringBuilder(number);

            if (n == 1)
            {
                Console.WriteLine(k>0?"9":number);
            }
            else
            {

                // Check how many changes we need
                for (int i = 0; i < halfLength; i++)
                {
                    if (sb[i] != sb[n - i - 1])
                    {
                        changesNeeded++;
                    }
                }

                if (k <= 0 && changesNeeded == 0)
                {
                    Console.WriteLine(number);
                }
                // Begin the change
                else if (k < changesNeeded)
                {
                    Console.WriteLine("-1");
                }
                else
                {
                    //int minReplacementNeeded = changesNeeded;

                    int actualMinReplacementsMade = 0;

                    // changes for minReplacement
                    for (int i = 0; i < halfLength && actualMinReplacementsMade<=k; i++)
                    {

                        if (sb[i] != sb[n - i - 1])
                        {
                            // Check if one of the numbers is '9'
                            if (sb[i] == '9' || sb[n - i - 1] == '9')
                            {
                                sb[i] = sb[n - i - 1] = '9';
                                actualMinReplacementsMade++;
                                //changesNeeded--;
                            }
                            else
                            {
                                // Check if we can turn the two numbers into '9'
                                if (actualMinReplacementsMade + 2 <= k)
                                {
                                    sb[i] = sb[n - i - 1] = '9';
                                    actualMinReplacementsMade += 2;
                                }
                                else
                                {
                                    sb[i] = sb[n - i - 1]
                                        = sb[i] > sb[n - i - 1]
                                            ? sb[i]
                                            : sb[n - i - 1];
                                    actualMinReplacementsMade++;
                                }
                                //changesNeeded--;
                            }
                        }

                    }

                    //int extraReplacements = k - minReplacementNeeded; //extraReplacemtns
                    k = k - actualMinReplacementsMade; //extraReplacemtnsNeeded


                    //changes for extraReplacemtns
                    for (int i = 0; i < halfLength && k > 0; i++)
                    {
                        // The numbers are different
                        if (sb[i] != sb[n - i - 1])
                        {
                            // Check if one of the numbers is '9'
                            if (sb[i] == '9' || sb[n - i - 1] == '9')
                            {
                                sb[i] = sb[n - i - 1] = '9';
                                k--;
                                //changesNeeded--;
                            }
                            else
                            {
                                // Check if we can turn the two numbers into '9'
                                if ((k - 2 >= 0))// && (k - 2 >= changesNeeded - 1))
                                {
                                    sb[i] = sb[n - i - 1] = '9';
                                    k -= 2;
                                }
                                else
                                {
                                    sb[i] = sb[n - i - 1]
                                        = sb[i] > sb[n - i - 1]
                                            ? sb[i]
                                            : sb[n - i - 1];
                                    k--;
                                }
                                //changesNeeded--;
                            }
                        }
                        else //The numbers are the same
                        {
                            if (i != n - i - 1)
                            {
                                //if both == 9  ... do nothing


                                //if both != 9 ... check conditions and if ok, change them to 9
                                // Change to 9
                                if ((sb[i] != '9') && (k - 2 >= 0))// && (k - 2 >= changesNeeded - 1))
                                {
                                    sb[i] = sb[n - i - 1] = '9';
                                    k -= 2;
                                    //changesNeeded--;
                                }
                            }
                            else if (sb[i] != '9')
                            {
                                sb[i] = '9';
                                k--;
                            }
                        }

                    }

                    string str = sb.ToString();

                    Console.WriteLine(str);
                }
            }

        }


    }
}
