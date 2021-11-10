using System;
using Less5Ex1;
using Xunit;

namespace Less5.xUnit
{
    public class Less5Ex1
    {
        [Fact]
        public void RN_CtorException()
        {
            Assert.Throws<Exception>(() => new RationalNumber(5, 0));
        }

        [Fact]
        public void RN_CtorNod()
        {
            RationalNumber r = new RationalNumber(20, 40);
            Assert.True(r.Numerator == 1 && r.Denominator == 2);
        }

        [Fact]
        public void RN_Ctor()
        {
            RationalNumber r = new RationalNumber(3, -10);
            Assert.True(r.Numerator == -3 && r.Denominator == 10);
        }

        [Fact]
        public void RN_Equal()
        {
            RationalNumber r1 = new RationalNumber(5, 7);
            RationalNumber r2 = new RationalNumber(5, 7);
            Assert.Equal(r1, r2);
        }

        [Fact]
        public void RN_NotEqualFromNumerator()
        {
            RationalNumber r1 = new RationalNumber(5, 7);
            RationalNumber r2 = new RationalNumber(9, 7);
            Assert.NotEqual(r1, r2);
        }

        [Fact]
        public void RN_NotEqualFromDenominator()
        {
            RationalNumber r1 = new RationalNumber(5, 7);
            RationalNumber r2 = new RationalNumber(5, 9);
            Assert.NotEqual(r1, r2);
        }

        [Fact]
        public void RN_MoreTrue()
        {
            RationalNumber r1 = new RationalNumber(5, 7);
            RationalNumber r2 = new RationalNumber(5, 9);
            Assert.True(r1 > r2);
        }

        [Fact]
        public void RN_MoreFalse()
        {
            RationalNumber r1 = new RationalNumber(5, 9);
            RationalNumber r2 = new RationalNumber(5, 7);
            Assert.False(r1 > r2);
        }

        [Fact]
        public void RN_LessTrue()
        {
            RationalNumber r1 = new RationalNumber(1, 7);
            RationalNumber r2 = new RationalNumber(5, 7);
            Assert.True(r1 < r2);
        }

        [Fact]
        public void RN_LessFalse()
        {
            RationalNumber r1 = new RationalNumber(5, 7);
            RationalNumber r2 = new RationalNumber(1, 7);
            Assert.False(r1 < r2);
        }

        [Fact]
        public void RN_MoreOrEqualTrue_More()
        {
            RationalNumber r1 = new RationalNumber(5, 7);
            RationalNumber r2 = new RationalNumber(1, 7);
            Assert.True(r1 >= r2);
        }

        [Fact]
        public void RN_MoreOrEqualTrue_Equal()
        {
            RationalNumber r1 = new RationalNumber(5, 7);
            RationalNumber r2 = new RationalNumber(5, 7);
            Assert.True(r1 >= r2);
        }

        [Fact]
        public void RN_MoreOrEqualFalse()
        {
            RationalNumber r1 = new RationalNumber(1, 7);
            RationalNumber r2 = new RationalNumber(5, 7);
            Assert.False(r1 >= r2);
        }

        [Fact]
        public void RN_LessOrEqualTrue_Less()
        {
            RationalNumber r1 = new RationalNumber(1, 7);
            RationalNumber r2 = new RationalNumber(5, 7);
            Assert.True(r1 <= r2);
        }

        [Fact]
        public void RN_LessOrEqualTrue_Equal()
        {
            RationalNumber r1 = new RationalNumber(5, 7);
            RationalNumber r2 = new RationalNumber(5, 7);
            Assert.True(r1 <= r2);
        }

        [Fact]
        public void RN_LessOrEqualFalse()
        {
            RationalNumber r1 = new RationalNumber(5, 7);
            RationalNumber r2 = new RationalNumber(1, 7);
            Assert.False(r1 <= r2);
        }

        [Fact]
        public void RN_ConvertToFloatTrue()
        {
            float a = (float)2 / 7;
            RationalNumber r = new RationalNumber(2, 7);
            Assert.True(a == r);
        }

        [Fact]
        public void RN_ConvertToFloatFalse()
        {
            float a = (float)2 / 7;
            RationalNumber r = new RationalNumber(2, 9);
            Assert.False(a == r);
        }

        [Fact]
        public void RN_ConvertToIntTrue()
        {
            int a = 295 / 14;
            RationalNumber r = new RationalNumber(295, 14);
            Assert.True(a == r);
        }

        [Fact]
        public void RN_ConvertToIntFalse()
        {
            int a = 295 / 14;
            RationalNumber r = new RationalNumber(123, 517);
            Assert.False(a == r);
        }

        [Fact]
        public void RN_ConvertIntToRN()
        {
            int a = 295;
            RationalNumber r = (RationalNumber)a;
            Assert.True(r.Numerator == 295 && r.Denominator == 1);
        }
    }
}