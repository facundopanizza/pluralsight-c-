using System;
using System.Collections.Generic;

namespace GradeBook
{
  public class Book
  {
    List<double> grades { get; }
    public string Name { get; set; }

    public Book(string name)
    {
      grades = new List<double>();
      Name = name;
    }

    public void AddGrade(double grade)
    {
      grades.Add(grade);
    }

    public Stats GetStats()
    {
      var result = 0.0;
      var highestGrade = double.MinValue;
      var lowestGrade = double.MaxValue;

      foreach (var grade in grades)
      {
        highestGrade = Math.Max(highestGrade, grade);
        lowestGrade = Math.Min(lowestGrade, grade);
        result += grade;
      }

      result /= grades.Count;

      return new Stats()
      {
        Average = result,
        High = highestGrade,
        Low = lowestGrade
      };
    }

    public void ShowStats()
    {
      var stats = GetStats();

      System.Console.WriteLine($"The highest grade is {stats.High}.");
      System.Console.WriteLine($"The lowest grade is {stats.Low}.");
      System.Console.WriteLine($"The average grade is {stats.Average:N1}.");
    }
  }
}