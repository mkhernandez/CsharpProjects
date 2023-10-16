// Coding Challenge - Fraudulent order challenge using nested iteration and selection statements

using System.Data.Common;
/*
string[] fraudulentOrderIDs = {"B123", "C234", "A325", "C15", "B177", "G3003", "C235", "B179"};

foreach(string id in fraudulentOrderIDs) {
    if(id.StartsWith('B')) {
        Console.WriteLine(id);
    }
}
*/

/*
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs 
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*/

Random random = new Random();
string[] fraudulentOrderIDs = new string[5];

for(int i = 0; i < fraudulentOrderIDs.Length; i++) {
    int prefixValue = random.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random.Next(1, 1000).ToString("000");

    fraudulentOrderIDs[i] = prefix + suffix;
}

foreach(string id in fraudulentOrderIDs) {
    Console.WriteLine(id);
}

/*
Code Challenge - Code readability challenge
Add whitespace so that it makes the code below more readable
This piece of code will convert a string into a character array, reverse the order,
Then count the number of occurences of a given value in the array. It will then convert it back to a string 
And print out the result
*/

string str = "The quick brown fox jumps over the lazy dog.";

char[] charMessage = str.ToCharArray();
Array.Reverse(charMessage);
int x = 0;

foreach (char i in charMessage) { 
    
    if (i == 'o') { 
        x++; 
    } 
}

string new_message = new String(charMessage);
Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");
