using Xunit;

namespace entra21_tests_list2
{
    public class ExercisesTest
    {
        [Theory]
        [InlineData(
            new double[15]{19, 35, 46, 71, 99, 84, 15, 16, 61, 12, 23, 45, 15, 83, 79},
            new double[15]{7, 29, 87, 65, 13, 14, 38, 86, 63, 68, 12, 54, 18, 5, 27},
            new double[15]{12, 6, -41, 6, 86, 70, -23, -70, -2, -56, 11, -9, -3, 78, 52}
        )]
        [InlineData(
            new double[15]{-100, 208, 33, 45, 507, 91.5, 77, 362, 8.9, 13.1, 51, 810, 86, 6.9, 78},
            new double[15]{80, 150, -70, -14, 99, 22, 88, 709.7, 29, 30, 217.3, 97.4, 61.5, 15, 208.9},
            new double[15]{-180, 58, 103, 59, 408, 69.5, -11, -347.7, -20.1, -16.9, -166.3, 712.6, 24.5, -8.1, -130.9}
        )]
        public void should_return_the_subtraction_value_of_element_a_minus_b(double[] numbers1, double[] numbers2, double[] expected)
        {
            var exercises = new Exercises();

            double[] result = exercises.Exercise1(numbers1, numbers2);
            
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData( new double[10]{19, 35, 46, 71, 99, 84, 15, 16, 61, 12}, new double[10]{12, 61, 16, 15, 84, 99, 71, 46, 35, 19})]
        [InlineData( new double[10]{9.5, 7.8, 8.5, 7, 6.8, 8.3, 10, 8.7, 9, 8}, new double[10]{8, 9, 8.7, 10, 8.3, 6.8, 7, 8.5, 7.8, 9.5})]
        [InlineData( new double[10]{-47, 52.5, -70, 100, -88.9, 150, -65.7, -33.5, 200, 10}, new double[10]{10, 200, -33.5, -65.7, 150, -88.9, 100, -70, 52.5, -47})]
        public void should_return_numbers_as_they_were_typed_and_backwards(double[] numbers, double[] numbersReverse)
        {
            var exercises = new Exercises();

            (double[], double[]) result = exercises.Exercise2(numbers);
            
            Assert.Equal(numbers, result.Item1);
            Assert.Equal(numbersReverse, result.Item2);
        }

        [Theory]
        [InlineData (new double[10]{7.5, 9.8, 8.5, 6.7, 9.5, 8.3, 7.3, 6.7, 9.6, 8.4}, 9.5, true)]
        [InlineData (new double[10]{8, 9, 7, 5, 12, 150, 89, 75, 19, 13}, 13, true)]
        [InlineData (new double[10]{-77, 85, -98, -45, -30, 18, -21, -83, -12, 15}, -21, true)]
        public void should_return_numbers(double[] numbers, double request, bool answer)
        {
            var exercises = new Exercises();

            var result = exercises.Exercise3(numbers, request);

            Assert.Equal(answer, result);
        }

        [Theory]
        [InlineData (new double[10]{8, 21, 52, 87, 99, 116, -15, -24, 9.5, 14.7}, new double[10]{59, 75, 74, -33, -55.8, 66, -7, 9.1, 60, 11}, false)]
        [InlineData (new double[10]{8, 21, 52, 87, 99, 116, -15, -24, 9.5, 14.7}, new double[10]{8, 21, 52, 87, 99, 116, -15, -24, 9.5, 14.7}, true)]
        [InlineData (new double[10]{8, 21, 52, 87, 99, 116, -15, -24, 9.50, 14.70}, new double[10]{8, 21, 52, 87, 99, 116, -15, -24, 9.55, 13.70}, false)]
        public void should_return_true_if_arrays_are_equal_and_false_if_they_are_not(double[] array1, double[] array2, bool expected)
        {
            var exercises = new Exercises();

            var result = exercises.Exercise4(array1, array2);

            Assert.Equal(expected, result);
        }
    
        [Theory]
        [InlineData (new double[15]{17, 19.5, 3, -4, -77, -65, 47, 18, 21, 34, 69.5, 45.1, 56, -99, -88.7}, new int[3]{5, 10, 0})]
        [InlineData (new double[15]{55, 5.7, 49, 71, -34, 20.6, -88, 46.8, 10, 58, 13.4, -27.3, -31.7, -36, 90}, new int[3]{8, 7, 0})]
        public void should_return_the_arithmetic_average_and_inform_which_ones_are_on_above_and_below_average(double[] numbers, int[] expected)
        {
            var exercises = new Exercises();

            var result = exercises.Exercise5(numbers);

            Assert.Equal(expected, result);
        }
    
        [Theory]
        [InlineData(
            new double[12]{28, 30.8, 18, -15, -62, 22, 41, 14.5, 57, 79.6, 11, 37},
            new double[12]{5, 31, 12, -2, 38, -7.9, -27.4, 88.3, 71, 20, 52.5, 6},
            new double[12]{26.30, 36.80, 39.00, 40.00, 42.00, 42.00, 49.00, 49.10, 52.20, 52.50, 56.00, 63.50}
        )]
        [InlineData(
            new double[12]{55, -62, 33, 13, 9, -44.5, -19.7, 11.1, 29, 40, 82.7, 36},
            new double[12]{87, 91, -45, 16.9, -21, 25, -68.4, 34, 14.9, -18, -4.6, 52},
            new double[12]{10.00, 14.30, 18.00, 19.00, 28.40, 29.00, 29.90, 32.30, 36.10, 42.50, 43.00, 43.90}
        )]
        public void should_return_one_array_with_the_sum_of_the_ones_passed(double[] array1, double[] array2, double[] expected)
        {
            var exercises = new Exercises();

            var result = exercises.Exercise6(array1, array2);

            Assert.Equal(expected, result);
        }
    }
}