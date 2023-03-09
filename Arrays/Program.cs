﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] students = new string[5, 3]
            {
                {"e","trt","hhfgh" },
                { "e","trt","fgh"},
                { "e","trt","fgh"},
                { "e","trt","fgh"},
                { "e","ttrt","fhfg"}
            };

            for (int i = 0; i < students.GetUpperBound(0); i++)
            {
                for (int j=0;j<students.GetUpperBound(1);j++)
                {
                    Console.WriteLine(students[i,j]);  
                }
            }
            Console.ReadLine();
        }
    }
}