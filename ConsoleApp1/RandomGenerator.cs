using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class RandomGenerator
    {

        private static RandomGenerator instance;
        private Random generator;
        private RandomGenerator()
        {
            this.generator = new Random();
        }
        public static RandomGenerator GetInstance()
        {
            if (instance == null)
            {
                instance = new RandomGenerator();
            }
            return instance;
        }
        public  int NextInt()
        {
            return this.generator.Next();
        }
        public  int NextInt(int upperBound)
        {
            return this.generator.Next(upperBound);
        }
        public  int NextInt(int lowerBound, int upperBound)
        {
            return this.generator.Next(lowerBound, upperBound);
        }
        public double NextDouble()
        {
            return this.generator.NextDouble();
        }        public  double[][] GetMatrix(int a, int b)
        {
            double[][] matrix = new double[a][];
            for(int i = 0; i < a; i++)
            {
                matrix[i] = new double[b];
                for(int j = 0; j < b; j++)
                {
                    matrix[i][j] = NextDouble();
                   
                }
            }
            return matrix;
        }
        public static double[][] GetMatrixStatic(int a, int b)
        {
            double[][] matrix = new double[a][];
            for (int i = 0; i < a; i++)
            {
                matrix[i] = new double[b];
                for (int j = 0; j < b; j++)
                {
                    matrix[i][j] = GetInstance().NextDouble();

                }
            }
            return matrix;
        }
    }
}
