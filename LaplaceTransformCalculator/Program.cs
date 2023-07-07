using System;
using MathNet.Numerics.Integration;
using MathNet.Symbolics;

namespace LaplaceTransformCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a function in terms of 't':");
            var input = Console.ReadLine();

            Console.WriteLine("Enter the start value for 't':");
            var fromInput = Console.ReadLine();
            double fromValue;
            if (!double.TryParse(fromInput, out fromValue))
            {
                Console.WriteLine("Invalid input for start value.");
                return;
            }

            Console.WriteLine("Enter the end value for 't':");
            var toInput = Console.ReadLine();
            double toValue;
            if (!double.TryParse(toInput, out toValue))
            {
                Console.WriteLine("Invalid input for end value.");
                return;
            }

            var e = SymbolicExpression.Parse(input);
            Console.WriteLine($"Function to transform: {e}"); // Display the function before transformation
            var func = e.Compile("t"); // Compile the symbolic expression into a function


            double Function(double t)
            {
                // Evaluate the user-defined function
                return (double)func(t);
            }

            double LaplaceTransform(double s)
            {
                // Define the integrand for the Laplace transform
                double integrand(double t) => Function(t) * Math.Exp(-s * t);

                // Perform numerical integration using Simpson's rule
                double result = SimpsonRule.IntegrateComposite(integrand, fromValue, toValue, 1000);
                return result;
            }

            // Evaluate the Laplace transform for various values of 's'
            Console.WriteLine("Laplace Transform:");

            for (double s = 0.1; s <= 10.0; s += 0.1)
            {
                double transform = LaplaceTransform(s);
                Console.WriteLine($"s = {s}, F(s) = {transform}");
            }
        }
    }
}
