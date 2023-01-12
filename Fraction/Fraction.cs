using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    internal class Fraction
    {
        private int _numerator;
        public int Numerator { get => _numerator; set => _numerator = value; }
        private int _denominator;
        public int Denominator { get => _denominator; set => _denominator = value; }

        public Fraction(int numerator, int denominator)
        {
            _numerator = numerator;
            _denominator = denominator;
            Normalize();
        }

        public void Input()
        {
            Console.Write("Enter numerator: ");
            _numerator = int.Parse(Console.ReadLine());
            Console.Write("Enter denominator: ");
            _denominator = int.Parse(Console.ReadLine());
            Normalize();
        }

        public Fraction Add(Fraction f)
        {
            int numerator = _numerator * f._denominator + _denominator * f._numerator;
            int denominator = _denominator * f._denominator;
            return new Fraction(numerator, denominator);
        }

        public Fraction Subtract(Fraction f)
        {
            int numerator = _numerator * f._denominator - _denominator * f._numerator;
            int denominator = _denominator * f._denominator;
            return new Fraction(numerator, denominator);
        }

        public Fraction Multiply(Fraction f)
        {
            int numerator = _numerator * f._numerator;
            int denominator = _denominator * f._denominator;
            return new Fraction(numerator, denominator);
        }

        public Fraction Divide(Fraction f)
        {
            int numerator = _numerator * f._denominator;
            int denominator = _denominator * f._numerator;
            return new Fraction(numerator, denominator);
        }

        public void Normalize()
        {
            int gcd = GCD(_numerator, _denominator);
            _numerator /= gcd;
            _denominator /= gcd;
        }

        private int GCD(int a, int b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }

        public void Display()
        {
            Console.WriteLine("({0}/{1})", _numerator, _denominator);
        }

        public void DisplayDecimal()
        {
            Console.WriteLine((double)_numerator / _denominator);
        }
    }
}
