using System;

namespace ComputeAverageApp
{
    class ComputeAverageProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter five grades separated by new lines:");

            double[] grades = new double[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Grade {i + 1}: ");
                grades[i] = Convert.ToDouble(Console.ReadLine());
            }

            double sum = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                double grade = grades[i];
                sum += grade;
            }

            double average = sum / 5;
            double roundedAverage = Math.Round(average, 2); 


            Console.WriteLine($"\nThe average of the grades is: {(roundedAverage)}. And  the rounded off grade is  {Math.Round(roundedAverage)}");
        }
    }
}
