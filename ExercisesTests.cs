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
        [InlineData(
            new double[10]{19, 35, 46, 71, 99, 84, 15, 16, 61, 12}, new double[10]{12, 61, 16, 15, 84, 99, 71, 46, 35, 19},
            new double[10]{9.5, 7.8, 8.5, 7, 6.8, 8.3, 10, 8.7, 9, 8}, new double[10]{8, 9, 8.7, 10, 8.3, 6.8, 7, 8.5, 7.8, 9.5},
            new double[10]{-47, 52.5, -70, 100, -88.9, 150, -65.7, -33.5, 200, 10}, new double[10]{10, 200, -33.5, -65.7, 150, -88.9, 100, -70, 52.5, -47}
        )]
        public void should_return_numbers_as_they_were_typed_and_backwards(double[] numbers, double[] expectedReverse)
        {
            var exercises = new Exercises();

            (double[], double[]) result = exercises.Exercise2(numbers);
            
            Assert.Equal(numbers, result.Item1);
            Assert.Equal(expectedReverse, result.Item2);
        }
    }
}