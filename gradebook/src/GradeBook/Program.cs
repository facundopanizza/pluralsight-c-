using System;
using System.Collections.Generic;

namespace GradeBook
{
  class Program
  {
    static void Main(string[] args)
    {
      var book = new Book("Scott's Grade Book");
      book.AddGrade(50.5);
      book.AddGrade(30.2);
      book.AddGrade(70.7);
      book.ShowStats();
    }
  }
}
