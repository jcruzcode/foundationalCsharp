// Create new instance of Random object
Random random = new Random();
// Random integer from 0 to 11 to represent days til expiration
int daysUntilExpiration = random.Next(12);
// Initialize discount to 0%
int discountPercentage = 0;

// Logic to display subscription expiration message
if ( daysUntilExpiration <= 0 ) {
    Console.WriteLine("Your subscription has expired.");
} else if ( daysUntilExpiration == 1 ) {
    Console.WriteLine("Your subscription expires within a day!");
} else if ( daysUntilExpiration <= 5 ) {
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
} else if ( daysUntilExpiration <= 10) {
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

// Logic to display subscription discount message
if ( daysUntilExpiration == 1 ) {
    discountPercentage = 20;
    Console.WriteLine($"Renew now and save {discountPercentage}%!");
} else if ( daysUntilExpiration <= 5 && daysUntilExpiration > 0 ) {
    discountPercentage = 10;
    Console.WriteLine($"Renew now and save {discountPercentage}%!");
}

/*
1) Rule 1: Your code should only display one message.
The message that your code displays will depend on the other five rules. 
For rules 2-6, the higher numbered rules take precedence over the lower numbered rules.

2) Rule 2: If the user's subscription will expire in 10 days or less, display 
the message:

Your subscription will expire soon. Renew now!

3) Rule 3: If the user's subscription will expire in five days or less, display 
the messages:

Your subscription expires in {daysUntilExpiration} days.
Renew now and save 10%!


4) Rule 4: If the user's subscription will expire in one day, display the messages:

Your subscription expires within a day!
Renew now and save 20%!

5) Rule 5: If the user's subscription has expired, display the message:

Your subscription has expired.

6) Rule 6: If the user's subscription doesn't expire in 10 days or less, display nothing.
*/

/*

Your solution must use separate if and if-else statements to implement the business rules. The if-else statement can include multiple else if parts.

    1) Create an if-else statement that displays a message about when the subscription will expire.

    Tip :Use an else if to ensure each expiration rule is accounted for.

    2) Create a separate if statement that displays a discount offer.

    The business rules indicate when a discount should be offered.

*/

