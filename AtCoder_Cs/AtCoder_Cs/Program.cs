﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder_Cs
{
    public class Program
    {
        public static void Main()
        {
            var N = int.Parse(Console.ReadLine());
            string ret = "No";

            if (IsHitPattern(N))
            {
                ret = "Yes";
            }
            Console.WriteLine($"{ret}");
        }

        private static bool IsHitPattern(int N)
        {
            var num = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var lst = new HashSet<int>();

            foreach (int i in num)
            {
                foreach (int j in num)
                {
                    lst.Add(i * j);
                }

            }

            return lst.Contains(N);
        }
    }
}
