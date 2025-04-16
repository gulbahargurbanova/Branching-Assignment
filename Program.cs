using System;

class Program
{
    static void Main(string[] args)
    {
        // Display welcome message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Get package weight from user and validate
        Console.WriteLine("Please enter the package weight:");
        double weight;
        if (!double.TryParse(Console.ReadLine(), out weight))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }

        // Check if package is too heavy
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return;
        }

        // Get package dimensions from user
        Console.WriteLine("Please enter the package width:");
        double width;
        if (!double.TryParse(Console.ReadLine(), out width))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }

        Console.WriteLine("Please enter the package height:");
        double height;
        if (!double.TryParse(Console.ReadLine(), out height))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }

        Console.WriteLine("Please enter the package length:");
        double length;
        if (!double.TryParse(Console.ReadLine(), out length))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }

        // Calculate total dimensions and check if package is too big
        double totalDimensions = width + height + length;
        if (totalDimensions > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return;
        }

        // Calculate shipping quote
        // Formula: (width * height * length * weight) / 100
        double quote = (width * height * length * weight) / 100;

        // Display formatted quote to user
        Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
        Console.WriteLine("Thank you!");
    }
}