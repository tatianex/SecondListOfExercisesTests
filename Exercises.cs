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

        public bool Exercise4(double[] array1, double[] array2)
        {          
            const int arraysLenght = 10;
            var areEqual = false;
            var arraysAreEqual = false;

            for (int i = 0; i < arraysLenght; i++)
            {
                for (int j = 0; j < arraysLenght; j++)
                {
                    if (Math.Round(array1[i], 2) == Math.Round(array2[j], 2))
                    {
                        areEqual = true;
                        break;
                    }
                    else areEqual = false;
                    
                }
            }

            if (!areEqual) arraysAreEqual = false;
            else arraysAreEqual = true;

            return arraysAreEqual;
        }
    
        public int[] Exercise5(double[] numbers)
        {
            double sum = 0;
            double average = 0.0d;
            int belowAverage = 0;
            int aboveAverage = 0;
            int equalAverage = 0;

            foreach (double value in numbers) sum += value;
            average = sum / numbers.Length;
            
            foreach (double value in numbers)
            {
                if (value < average) belowAverage++;
                else if (value > average) aboveAverage++;
                else equalAverage++;
            }

            var result = new int[3]{belowAverage, aboveAverage, equalAverage};
            return result;
        }
    }
}
