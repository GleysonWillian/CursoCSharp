﻿using System;
class Aula22
{
    static void Main()
    {
        // for comum:
        //int[] num = new int[3] { 11, 22, 33 };

        //for (int i = 0; i < num.Length; i++)
        //{
        //   Console.WriteLine(num[i]);
        //}

        // foreach:
        int[] num = new int[5] { 11, 22, 33, 44, 55 };

        foreach (int n in num)
        {
            Console.WriteLine(n);
        }
    }
}