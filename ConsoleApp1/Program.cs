﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dataset d = new Dataset("C:\\Users\\Nune\\Documents\\dopc.csv");
            Dataset c = (Dataset)d.Clone();
            Dataset f = (Dataset)d.DeepClone();
            c.ClearData();
        }
    }
}