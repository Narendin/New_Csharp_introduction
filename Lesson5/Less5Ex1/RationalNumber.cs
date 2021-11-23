using System;

namespace Less5Ex1
{
    public class RationalNumber
    {
        public int Numerator { get; } //Числитель
        public int Denominator { get; } //Знаменатель

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="numerator">Числитель</param>
        /// <param name="denominator">Знаменатель</param>
        public RationalNumber(int numerator, int denominator)
        {
            if (denominator == 0) throw new Exception("Деление числа на ноль не допускается");

            if (denominator < 0)    // знаменатель должен быть положительным, если отрицательный, то умножаем числитель и знаменатель на -1
            {
                numerator *= -1;
                denominator *= -1;
            }

            int nod = Nod(numerator, denominator);

            Numerator = numerator / nod;
            Denominator = denominator / nod;
        }

        public static bool operator ==(RationalNumber r1, RationalNumber r2)
        {
            return !(r1 is null) && !(r2 is null) && r1.Numerator == r2.Numerator && r1.Denominator == r2.Denominator;
        }

        public static bool operator !=(RationalNumber r1, RationalNumber r2)
        {
            return !(r1 == r2);
        }

        public static bool operator >(RationalNumber r1, RationalNumber r2)
        {
            return r1.Numerator * r2.Denominator > r1.Denominator * r2.Numerator;
        }

        public static bool operator <(RationalNumber r1, RationalNumber r2)
        {
            return r1.Numerator * r2.Denominator < r1.Denominator * r2.Numerator;
        }

        public static bool operator >=(RationalNumber r1, RationalNumber r2)
        {
            return !(r1 < r2);
        }

        public static bool operator <=(RationalNumber r1, RationalNumber r2)
        {
            return !(r1 > r2);
        }

        public static RationalNumber operator +(RationalNumber r1, RationalNumber r2)
        {
            return new RationalNumber(r1.Numerator * r2.Denominator + r2.Numerator * r1.Denominator, r1.Denominator * r2.Denominator);
        }

        public static RationalNumber operator -(RationalNumber r1, RationalNumber r2)
        {
            return new RationalNumber(r1.Numerator * r2.Denominator - r2.Numerator * r1.Denominator, r1.Denominator * r2.Denominator);
        }

        public static RationalNumber operator -(RationalNumber r)
        {
            return new RationalNumber(-r.Numerator, r.Denominator);
        }

        public static RationalNumber operator ++(RationalNumber r)
        {
            return new RationalNumber(r.Numerator + r.Denominator, r.Denominator);
        }

        public static RationalNumber operator --(RationalNumber r)
        {
            return new RationalNumber(r.Numerator - r.Denominator, r.Denominator);
        }

        public static RationalNumber operator *(RationalNumber r1, RationalNumber r2)
        {
            return new RationalNumber(r1.Numerator * r2.Numerator, r1.Denominator * r2.Denominator);
        }

        public static RationalNumber operator /(RationalNumber r1, RationalNumber r2)
        {
            return new RationalNumber(r1.Numerator * r2.Denominator, r1.Denominator * r2.Numerator);
        }

        public static RationalNumber operator %(RationalNumber r1, RationalNumber r2)
        {
            return new RationalNumber((r1.Numerator * r2.Denominator) % (r1.Denominator * r2.Numerator), r1.Denominator * r2.Denominator);
        }

        public static implicit operator float(RationalNumber r)
        {
            return (float)r.Numerator / r.Denominator;
        }

        public static implicit operator int(RationalNumber r)
        {
            return r.Numerator / r.Denominator;
        }

        public static explicit operator RationalNumber(int numerator)
        {
            return new RationalNumber(numerator, 1);
        }

        public override bool Equals(object? obj)
        {
            return obj is RationalNumber rationalNumber && rationalNumber.Numerator == Numerator && rationalNumber.Denominator == Denominator;
        }

        protected bool Equals(RationalNumber other)
        {
            return Numerator == other.Numerator && Denominator == other.Denominator;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Numerator, Denominator);
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }

        /// <summary>
        /// Нахождение наибольшего общего делителя
        /// </summary>
        /// <param name="numerator"> Числитель</param>
        /// <param name="denominator">Знаменатель</param>
        /// <returns>Наибольший общий делитель</returns>
        private int Nod(int numerator, int denominator)
        {
            int temp = 0;

            numerator = Math.Abs(numerator);
            denominator = Math.Abs(denominator);

            if (denominator > numerator)
            {
                temp = numerator;
                numerator = denominator;
                denominator = temp;
            }
            do
            {
                temp = numerator % denominator;
                numerator = denominator;
                denominator = temp;
            } while (denominator != 0);

            return numerator;
        }
    }
}