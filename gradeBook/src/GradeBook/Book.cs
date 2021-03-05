using System.Collections.Generic;
using System;

namespace GradeBook
{
    public class Book {
        private List<double> grades;
        private string name;
        public double high;
        public double low;
        public double average;
        private double total;

        public Book (string name) {
            grades = new List<double>();
            this.name = name;
            high = double.MinValue;
            low = double.MaxValue;
            total = 0.0;
            average = 0.0;
        }

        public void AddGrade(double grade) {
            grades.Add(grade);
            high = Math.Max(high, grade);
            low = Math.Min(low, grade);
            total += grade;
            average = total / grades.Count;
        }

        public void ShowStatistics() {
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;

            foreach(var number in grades) {
                lowGrade = Math.Min(number, lowGrade);
                highGrade = Math.Max(number, highGrade);
                result += number;
            }

            result /= grades.Count;
            System.Console.WriteLine($"The lowest grade is {lowGrade}");
            System.Console.WriteLine($"The highest grade is {highGrade}");
            System.Console.WriteLine($"The average grade is {result:N1}");
        }
    }
}