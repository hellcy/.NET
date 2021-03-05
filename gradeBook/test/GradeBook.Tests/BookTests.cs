using System;
using Xunit;

namespace GradeBook.Tests
{
    // reference the main project to the test project in .csproj
    public class BookTests
    {
        [Fact]
        public void Test1()
        {
            // arrange
            var book = new Book("Test Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            // act
            book.ShowStatistics();

            // assert
            Assert.Equal(85.6, book.average, 1);
            Assert.Equal(90.5, book.high);
            Assert.Equal(77.3, book.low);
        }
    }
}
