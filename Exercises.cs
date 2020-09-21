using System;
using System.Linq;

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

        public (double[], double[]) Exercise2(double[] numbers)
        {
            double[] numbersBackwards = (Double[])numbers.Clone();
            Array.Reverse(numbersBackwards);

            var result = (numbers, numbersBackwards);
            return result;
        }

        public bool Exercise3(double[] numbers, double request)
        {            
            return numbers.Contains(request);
        }
    }
}
