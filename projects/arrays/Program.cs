/*
// declare a new array of strings that can hold three elements
string[] fraudulentOrderIDs = new string[3];


// Assign order ID values to 'fraudulentOrderIDs' array
fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000";


// Declare and initalize array
string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

// Display fraudulent order IDs
Console.WriteLine($"First:  {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third:  {fraudulentOrderIDs[2]}");

// Reassign the first element of array
fraudulentOrderIDs[0] = "F000";

// Display reassigned element
Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

// Display number of fraudulente orders using Length property
Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");


/*

// foreach statement

// string[] names = { "Rowena", "Robin", "Bao" };
// foreach ( string name in names ) {
//     Console.WriteLine(name);
// }

// Use the foreach statement to create a sum of all the items on hand in each bin of your warehouse.
int[] inventory = { 200, 450, 700, 175, 250 };

// To represent sum of inventory
int sum = 0;
// To store the number of the bin whose inventory is currently being processed.
int bin = 0; // counter variable

// loop through each item in inventory
foreach ( int items in inventory ) {
    // each loop adds the current item count to the sum
    sum += items;
    // incremente bin number by 1
    bin++; 
    // To report the bin number, the number of finished products in the bin, 
    // and the running total of finished products
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}

// Display sum of inventory
Console.WriteLine($"We have {sum} items in inventory."); */

/******************************************************************************

Code challenge - Report the Order IDs that need further investigation

*******************************************************************************/

// Declare and initialize an array on order IDs
string[] orderIDs = { "B123", "C234", "A345", "C15", 
                      "B177", "G3003", "C235", "B179" };

// Use to foreach loop to identify and display which IDs start with 'B'
foreach (string orderID in orderIDs) {
    // string method StartsWith check if the string starts which the specified
    // substring
    if ( orderID.StartsWith("B") ) {
        Console.WriteLine(orderID); // Display order ID
    }
}