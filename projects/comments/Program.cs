/*
    The following code creates five random order IDs
    to test the fraud detection process. Order IDs 
    consist of a letter from A to E, and a three 
    digit number. Ex. A123.
*/

/* Random random = new Random();
string[] orderIDs = new string[5];

for( int i = 0; i < orderIDs.Length; i++ ) {
    
    int prefixValue = random.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    // Create a random number, pad with zeroes
    string suffix = random.Next(1, 1000).ToString("000"); 
    
    orderIDs[i] = prefix + suffix;
}

foreach ( var orderID in orderIDs ) {
    Console.WriteLine(orderID);
} */

/*

Code challenge - apply style guidelines to improve readability

*/

/*
    This program reverses a string, counts the number
    of times a particular character appears, and prints
    the reversed string and character count.
*/

string sentence = "The quick brown fox jumps over the lazy dog.";

char[] symbols = sentence.ToCharArray();
Array.Reverse(symbols);

int symbolCount = 0;

foreach ( char symbol in symbols ) 
{ 
    if ( symbol == 'o' ) 
    { 
        symbolCount++; 
    } 
}

string message = new String(symbols);

Console.WriteLine(message);
Console.WriteLine($"'o' appears {symbolCount} times.");