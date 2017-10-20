using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_VeryHard
{
    class Program
    {
        // VERY HARD:  Write a program using a switch statement that takes one value from the user 
        // and asks about the type of conversion and then performs a conversion depending on the type of conversion.
        // If user enters: 
        // I -> convert from inches to centimeters.
        // G -> convert from gallons to liters.
        // M -> convert from mile to kilometer.
        // P -> convert from pound to kilogram.
        // If the user enters any other character then show a proper message.
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the conversion method.");
            Console.WriteLine("I: Inches to centimeters");
            Console.WriteLine("G: Gallons to liters");
            Console.WriteLine("M: Miles to kilometers");
            Console.WriteLine("P: Pounds to kilograms");

            // Grab the users input to get the conversion method
            var input = Console.ReadLine();

            decimal centimeters = 0;
            decimal liters = 0;
            decimal kilometers = 0;
            decimal kilograms = 0;

            // Depending on the input method, convert to the correct metric
            switch (input)
            {
                case "I":
                    Console.Write("Number of Inches: ");
                    centimeters = Converter.InchesToCentimeters(Console.ReadLine());
                    Console.WriteLine("Centimeters: {0}", centimeters);
                    break;

                case "G":
                    Console.Write("Number of Gallons: ");
                    liters = Converter.GallonsToLiters(Console.ReadLine());
                    Console.WriteLine("Liters: {0}", liters);
                    break;
                case "M":
                    Console.Write("Number of Miles: ");
                    kilometers = Converter.MilesToKilometers(Console.ReadLine());
                    Console.WriteLine("Kilometers: {0}", kilometers);
                    break;
                case "P":
                    Console.Write("Number of Pounds: ");
                    kilograms = Converter.PoundsToKilograms(Console.ReadLine());
                    Console.WriteLine("Kilograms: {0}", kilograms);
                    break;
                default:
                    Console.WriteLine("Please select a conversion method.");
                    break;
            }
        }
    }

    public static class Converter
    {
        public static decimal InchesToCentimeters(string inchesInput)
        {
            // Convert the string to a decimal
            decimal inches = Decimal.Parse(inchesInput);

            // Convert inches to centimeters
            decimal centimeters = inches * 2.54m;

            return centimeters;
        }

        public static decimal GallonsToLiters(string gallonsInput)
        {
            // Convert the string to a decimal
            decimal gallons = Decimal.Parse(gallonsInput);

            // Convert gallons to liters
            decimal liters = gallons * 3.78541m;

            return liters;
        }

        public static decimal MilesToKilometers(string milesInput)
        {
            // Convert the string to a decimal
            decimal miles = Decimal.Parse(milesInput);

            // Convert miles to kilometers
            decimal kilometers = miles * 1.60934m;

            return kilometers;
        }

        public static decimal PoundsToKilograms(string poundsInput)
        {
            // Convert the string to a decimal
            decimal pounds = Decimal.Parse(poundsInput);

            // Convert pounds to kilograms
            decimal kilograms = pounds * 0.453592m;

            return kilograms;
        }
    }
}
