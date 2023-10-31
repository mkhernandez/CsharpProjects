/*
string[] pallets = {"B14", "A11", "B12", "A13"};

// Sort method
Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach(var pallet in pallets) {
    Console.WriteLine($"-- {pallet}");
}

// Reverse method
Console.WriteLine();
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach(var pallet in pallets) {
    Console.WriteLine($"-- {pallet}");
}

// Clear method
Console.WriteLine();
Console.WriteLine($"Before clearing: {pallets[0]}");
Array.Clear(pallets, 0, 2);

// Add if statement to check if null
if(pallets[0] != null)
// Since the next Console.WriteLine is within this if statement checking for not null, no error is thrown
// Normally a statement like the following one would throw an exception and would need to be handled
Console.WriteLine($"After clearing: {pallets[0].ToLower()}");

Console.WriteLine($"Clearing 2...count: {pallets.Length}");

foreach(var pallet in pallets) {
    Console.WriteLine($"-- {pallet}");
}

// Add back two elements
pallets[0] = "A12";
pallets[1] = "B45";
Console.WriteLine($"Two elements added back in: {pallets[0]} {pallets[1]}");

// Resize method to add elements to the end of the array
Console.WriteLine();
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6...count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach(var pallet in pallets) {
    Console.WriteLine($"-- {pallet}");
}

// Resize method to remove elements from the end of the array
Console.WriteLine();
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3...count: {pallets.Length}");

foreach(var pallet in pallets) {
    Console.WriteLine($"-- {pallet}");
}

// String data type's array methods - ToCharArray()
string value = "abc123";
char[] valueArray = value.ToCharArray();

// Reverse it then combine to make a new string - Use the Join method to join the char array separated by commas
Array.Reverse(valueArray);
// string result = new string(valueArray);
string result = string.Join(',', valueArray);
Console.WriteLine(result);

// Split method to split the comma separated value string into an array of strings
string[] items = result.Split(',');
foreach(string item in items) {
    Console.WriteLine(item);
}
*/

// Coding Challenge - Reverse words in a sentence. Reverse the letters of each word in place and display the text
using System.ComponentModel.DataAnnotations;

string pangram = "The quick brown fox jumps over the lazy dog";
string[] items = pangram.Split(' ');
/*
pangram = "";
foreach(string item in items) {

    char[] word = item.ToCharArray();
    Array.Reverse(word);
    string temp = string.Join(',', word);
    string[] value = temp.Split(',');
    string concatenatedString = "";

    for(int i = 0; i < value.Length; i++) {
        concatenatedString += value[i];
    }

    pangram = pangram + " " + concatenatedString;
}

Console.WriteLine(pangram.Trim());
*/

// Can also be done this way. Pangram has already been split into a string array
string[] newMessage = new string[items.Length];

for(int i = 0; i < items.Length; i++) {
    char[] letters = items[i].ToCharArray();
    Array.Reverse(letters);
    newMessage[i] = new string(letters);
}

string result = string.Join(' ', newMessage);
Console.WriteLine(result);


