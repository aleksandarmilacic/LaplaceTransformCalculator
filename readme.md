# LaplaceTransformCalculator

LaplaceTransformCalculator is a C# console application that calculates the Laplace transform of a function using numerical integration.

## Usage

1. Run the program by executing the compiled binary.

2. Enter a function in terms of 't' when prompted. For example: `2 * t + 3 * Math.Sin(t)`.

3. Enter the start value for 't'. This represents the starting point on the t-axis for the Laplace transform calculation.

4. Enter the end value for 't'. This represents the ending point on the t-axis for the Laplace transform calculation.

5. The program will calculate the Laplace transform for various values of 's' using numerical integration with Simpson's rule.

6. The Laplace transform values will be displayed in the console.

## Dependencies

The project has the following dependencies:

- MathNet.Numerics
- MathNet.Symbolics

These dependencies will be automatically resolved when you build and run the program.

## Mathematical Expressions

The program supports mathematical expressions using standard operators and functions. You can use basic arithmetic operators (`+`, `-`, `*`, `/`), exponentiation (`^`), and trigonometric functions (`Math.Sin`, `Math.Cos`, `Math.Tan`, etc.). Make sure to prefix the trigonometric functions with `Math.`.

For example, you can enter a function like `2 * t + 3 * Math.Sin(t)` to calculate the Laplace transform.

## Numerical Integration

The Laplace transform is calculated using numerical integration with Simpson's rule. The program performs composite Simpson integration over the specified range of 't' values. The integration accuracy can be adjusted by changing the number of intervals used for integration.

## License

This project is licensed under the [MIT License](LICENSE).

Feel free to modify and use it according to your needs.

