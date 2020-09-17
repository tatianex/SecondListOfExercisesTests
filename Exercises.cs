using System;
using System.Collections.Generic;

namespace entra21_tests_list2
{
    class Exercises
    {
        public double[] Exercise1(double[] listOfNumbers1, double[] listOfNumbers2)
        {
            const int arraysLenght = 15;

            var listOfNumbers3 = new double[arraysLenght];

            for (int i = 0; i < arraysLenght; i++)
            {
                listOfNumbers3[i] = Math.Round(listOfNumbers1[i] - listOfNumbers2[i], 1);
            }

            return listOfNumbers3;
        }
    }
}
