// Created by: Jaejun Lee
// Created on: Mar 2022
//
// This program accepts user input
using System;
class Program
{
    public static void Main(string[] args)
    {
        double fahrenheit;
        double celsius;

        Console.WriteLine("This program converts Fahrenheit to Celsius");
        Console.WriteLine("");
        Console.Write("Enter the fahrenheit temperature(°F): ");
        fahrenheit = double.Parse(Console.ReadLine());

        celsius = (double)(fahrenheit - 32) * 5 / 9;

        Console.WriteLine("");
        Console.Write("The celsius temperature is: " + celsius.ToString("0.00") + " °C");
        Console.ReadKey();
        Console.WriteLine("\nDone.");
    }
}
