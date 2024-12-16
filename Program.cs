using System;
using System.Diagnostics;

namespace TemperatureConverter
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Welcome To the Temperature converter!!!");


            Console.Write("Enter a value: ");
            string numberInput = Console.ReadLine();
            double value = Convert.ToDouble(numberInput);

            Console.Write("Enter a unit (Celsius, Kelvin, Fahrenheit): ");
            string unitInput = Console.ReadLine().ToLower();

            switch (unitInput)
            {
                case "celsius":
                    Console.WriteLine($"{value}° Celsius is equal to {CelsiusToFahrenheit(value)}° Fahrenheit.");
                    Console.WriteLine($"{value}° Celsius is equal to {CelsiusToKelvin(value)} Kelvin.");
                    break;

                case "fahrenheit":
                    Console.WriteLine($"{value}° Fahrenheit is equal to {FahrenheitToCelsius(value)}° Celsius.");
                    Console.WriteLine($"{value}° Fahrenheit is equal to {FahrenheitToKelvin(value)} Kelvin.");
                    break;

                case "kelvin":
                    Console.WriteLine($"{value} Kelvin is equal to {KelvinToCelsius(value)}° Celsius.");
                    Console.WriteLine($"{value} Kelvin is equal to {KelvinToFahrenheit(value)}° Fahrenheit.");
                    break;

                default:
                    Console.WriteLine("Invalid unit. Please enter Celsius, Fahrenheit, or Kelvin.");
                    break;
            }


            Console.ReadLine();
        }


        static double CelsiusToFahrenheit (double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        static double CelsiusToKelvin (double celsius)
        {
            return (celsius + 273.15);
        }

        static double FahrenheitToCelsius (double Fahrenheit)
        {
            return (Fahrenheit - 32) * 5/9;
        }

        static double FahrenheitToKelvin (double Fahrenheit)
        {
            return (Fahrenheit * 5 / 9) + 459.67;
        }

        static double KelvinToCelsius (double Kelvin)
        {
            return (Kelvin - 273.15);
        }

        static double KelvinToFahrenheit (double Kelvin)
        {
            return (Kelvin - 273.15) * 1.8 + 32;
        }
    }
}