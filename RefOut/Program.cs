﻿using System;

namespace RefOut
{
    class Program
    {
        static void Main(string[] args)
        {
            // string[] arr = { "Hello P202 Group" };
            // string arr = "Hello P202 Group" ;
            // Console.WriteLine(Text(reverse.Length));
            //Console.WriteLine(Text(arr));
            Console.WriteLine(Text("Hello P202 Group."));
        }
        static string Text(string reverse)
        {
            int k = 0;
            Console.WriteLine("Length=" + reverse.Length);
            string result = string.Empty;
            for (int j = 0; j <reverse.Length;j++)
            {

                if (reverse[j] == (' ') || (j == reverse.Length-1) || (reverse[j] == ('.'))||(reverse[j] == ('?')))
                {
                    for (int i = j-1; i >= k; i--)
                    {
                        result += reverse[i];
                        if (i == 0)
                        {
                            result += " ";
                        }
                        if (j == reverse.Length + 1)
                        {
                            result += ".";
                        }
                    }
                    k = j;
                }
            }
                return result;
        }
    }
}
