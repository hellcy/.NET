using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Yuan's Grade Book");
            book.AddGrade(87.4);
            book.AddGrade(43.87);
            book.AddGrade(443.67);
            book.AddGrade(5542.3);
            book.ShowStatistics();
        }
    }
}
