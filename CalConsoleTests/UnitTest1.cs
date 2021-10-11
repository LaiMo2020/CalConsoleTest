using System;
using Xunit;
using Calcualtor;

namespace CalConsoleTests
{
    public class CalTests
    {
        [Fact]
        public void AddTests()
        {
            var add = new CalConsole();
            double result = 3;
            ;
            var Addtests = CalConsole.Add(1, 2);

            Assert.Equal(result, Addtests);

        }

        [Fact]
        public void SubTests()
        {
        var sub = new CalConsole();
        double result = 0;
        var Subtests = CalConsole.Sub(2, 2);

        Assert.Equal(result, Subtests);

        }

        [Fact]
        public void MultTests()
        {
            var mult = new CalConsole();
            double result = 2;
            var Multtests = CalConsole.Mult(1, 2);
            Assert.Equal(result, Multtests);

        }

        [Fact]
        public void DivTests()
        {
            var div = new CalConsole();
            double result = 1;
            var Divtests = CalConsole.Div(2, 2);
            Assert.Equal(result, Divtests);

        }

        [Fact]
        public void DivideExceptionTests()
        {
            var divByZero = new CalConsole();
            double result = double.PositiveInfinity;
            var DivideExceptionTests = CalConsole.Div(2, 0);
            Assert.Equal(result, DivideExceptionTests);

        }

        [Fact]
        public void DivideExceptionNegativeTests()
        {
            var divByZero = new CalConsole();
            double result = double.NegativeInfinity;
            var DivideExceptionTests = CalConsole.Div(-2, 0);
            Assert.Equal(result, DivideExceptionTests);

        }

        //[Fact]
        //public void arrayTests()
        //{
        //    var arraytests = new CalConsole();
        //    result[] = 4;
        //    var arraytests = CalConsole.Add(arraytests{ 1, 1, 1});

        //}
    }
}
