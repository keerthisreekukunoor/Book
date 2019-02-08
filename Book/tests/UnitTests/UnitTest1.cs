using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void DivisionOfTwoPositiveNumbers()
        {
            var expected = 4;
            var x = 8;
            var y = 2;
            var actual = divide(x, y);
            Assert.Equal(expected, actual);


        }

        [Fact]
        public void DivisionOfTwoNegativeNumbers()
        {
            var expected = 2;
            var a = -10;
            var b = -5;
            var actual = divide(a, b);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(8)]
        [InlineData(4)]
        [InlineData(6)]
        public void IsEven_WorksWithManyInputs(int value)
        {
            Assert.True(IsEven(value));
        }


        [Theory]
        [InlineData(4, 8, 2)]
        [InlineData(3, -12, -4)]
        
        public void Division_WorksWithManyInputs(int exp, int n1, int n2)
        {
            Assert.Equal(exp, divide(n1, n2));
        }


        int divide(int a, int b)
        {
            return a/b;
        }
        bool IsEven(int value)
        {
            return value % 2 == 0;
        }

    }
}
