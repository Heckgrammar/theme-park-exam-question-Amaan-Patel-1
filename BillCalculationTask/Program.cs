using System;

class ThemeParkChargeCalculator
{
    static void Main(string[] args)
    {
        const decimal ticketPrice = 15.00m; // Price per person
        const decimal discountAmount = 5.00m; // Discount for groups of 6 or more

        // Get the number of people in the group
        Console.Write("Enter the number of people in the group: ");
        int numberOfPeople;
        
        // Validate input
        while (!int.TryParse(Console.ReadLine(), out numberOfPeople) || numberOfPeople < 1)
        {
            Console.Write("Please enter a valid number of people (1 or more): ");
        }

        // Calculate total charge
        decimal totalCharge = numberOfPeople * ticketPrice;

        // Apply discount if applicable
        if (numberOfPeople >= 6)
        {
            totalCharge -= discountAmount;
        }

        // Output the total charge
        Console.WriteLine($"The total charge for {numberOfPeople} people is: £ {totalCharge}");
    }
}
