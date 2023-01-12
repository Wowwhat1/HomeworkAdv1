// See https://aka.ms/new-console-template for more information
using Homework_9_1.Dice;

Dice dice = new Dice();
Console.WriteLine("Enter number of side");
dice.Side = int.Parse(Console.ReadLine());
Console.WriteLine("Enter your expected number: ");
int expectedNum = int.Parse(Console.ReadLine());
Console.WriteLine($"Your expected number is {expectedNum}, the real result is: {dice.Roll()}");
Console.ReadLine();