// code sample that implements methods of the System.Random and System.Console classes
// This code simulates a dice roll using the Random.Next() method to generate a number, 
// and the Console.WriteLine() method to display the value
// Clear information displayed in the console
// Console.Clear();
//Random dice = new Random();

// To examine the overloaded versions of the Random.Next() method

// The first version of the Next() method doesn't set an upper and lower boundary, 
// so the method will return values ranging from 0 to 2,147,483,647,
// which is the maximum value an int can store.
//int roll1 = dice.Next();

// The second version of the Next() method specifies the maximum value as an upper boundary, 
// so in this case, you can expect a random value between 0 and 100.
//int roll2 =  dice.Next(101);

//The third version of the Next() method specifies both the minimum and maximum values, 
// so in this case, you can expect a random value between 50 and 100.
//int roll3 = dice.Next(50, 101);

// int roll =  dice.Next(1,7); // a number from 1 to 6 is displayed in the console output 

//Console.WriteLine($"First roll: {roll1}");
//Console.WriteLine($"Second roll: {roll2}");
//Console.WriteLine($"Third roll: {roll3}");

//  Code challenge: Implement a method of the Math class that returns the larger of two numbers

/* int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue, secondValue); // returns larger of two numbers

Console.WriteLine(largerValue); */

// Write code that generates three random numbers and displays them in output

// Create new object of the Random class
Random dice = new Random();

// Initialize dice rolls
int roll1 = dice.Next(1, 7); // returns int 1-6 inclusive
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3; // sum the values of each die roll

// Display total
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) 
{
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2;
}

if ((roll1 == roll2) && (roll2 == roll3)) 
{
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    total += 6;
}

if ( total >=  15 ) 
{
    Console.WriteLine("You win!");
}

if ( total < 15 ) 
{
    Console.WriteLine("Sorry you lose!");
}