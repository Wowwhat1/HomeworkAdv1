// See https://aka.ms/new-console-template for more information
using Fraction;

Fraction.Fraction f1 = new Fraction.Fraction(3, 4);
Fraction.Fraction f2 = new Fraction.Fraction(1, 2);

Fraction.Fraction f3 = f1.Add(f2);
Fraction.Fraction f4 = f1.Subtract(f2);
Fraction.Fraction f5 = f1.Multiply(f2);
Fraction.Fraction f6 = f1.Divide(f2);

f3.Display(); 
f4.Display();
f5.Display();
f6.Display();

f3.DisplayDecimal(); 
f4.DisplayDecimal();
f5.DisplayDecimal();
f6.DisplayDecimal();
