// There will be three different coding challenges in this project
// The purpose is to have a few scenarios using while or do-while 
// Looping structures. Choosing one over the other can seem arbitrary
// And this project attempts to give the user insight into using one over the other
// Must use a while or do-while loop on each coding project. We can choose which 
// One to use but keep in mind that each project will have its own challenges 
// And that will help determine which structure we use

// Coding Project #1 - Validate user input is an integer
// Before the iteration block prompt the user for an integer between 5 and 10
// Check user input for a valid integer value
// Prompt the user if input is invalid(not an integer or not between 5 and 10)
// Must exit when input is valid
using System.ComponentModel.DataAnnotations;
/*
int value;
bool validNumber = false;
string? result;
Console.WriteLine("Input an integer between 5 and 10: ");

do
{
    // Read in the string and try to parse it to an integer
    result = Console.ReadLine();
    validNumber = int.TryParse(result, out value);

    // Check if input is valid number
    if(validNumber) {

    }

    // If its an integer check to see if its between 5 and 10
    if (validNumber) {
        if(value > 5 && value < 10) {
            continue;
        } else {
            Console.WriteLine("Sorry, input a number between 5 and 10: ");
        }
    } else {
        Console.WriteLine("Sorry, input a valid number. Try again: ");
    }

} while (value <= 5 || value >= 10);

Console.WriteLine($"You input value ({value}) has been accepted");
*/

// Coding Project #2 - validate string input
// Prompt the user for one of three roles: Administrator, Manager, User
// Must use do-while or while loop
// Inside the loop must:
// Use Console.ReadLine() to read in user input
// Validate the string. Ensure it matches one of the roles
// Must use Trim() and ToLower()
// Prompt user for valid entry if not one of the roles
// After loop use print output to user that their input was accepted

/*
string role = "";
string? input;
bool validRole = false;
bool hasWhiteSpaceOrNull = false;
Console.WriteLine("Enter your role(Administrator, Manager, User): ");

// Loop while no valid role
while(!validRole) {
    input = Console.ReadLine();
    hasWhiteSpaceOrNull = string.IsNullOrWhiteSpace(input);
    if(!hasWhiteSpaceOrNull) {
        role = input.Trim().ToLower();

        if(role == "administrator" || role == "manager" || role == "user") {
            validRole = true;
            continue;
        } else {
            Console.WriteLine("Please input Administrator, Manager, or User: ");
        }
    } else {
        Console.WriteLine("You didn't enter anything. Enter Administrator, Manager, or User: ");
    }
}

Console.WriteLine($"Your role: {role} has been accepted.");
*/

// Coding Project #3 - Process contents of string array
// Need to traverse the string. When there is a period we want to extract that substring up to the period(exclusive)
// 

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int periodLocation;
string newString = "";

foreach(string mystring in myStrings) {

    int index = 0;
    int traverse = 0;
    periodLocation = mystring.IndexOf(".");
    traverse = periodLocation;

    // If there is no period then we just return the string
    if(periodLocation < 0) {
        mystring.TrimStart();
        Console.WriteLine(mystring);
    }

    // Otherwise we will traverse the string to break it up into smaller substrings and print to console
    while(periodLocation > 0) {
        // set up the new substring stripped of leading whitespace and trailing period
        newString = mystring.Substring(index, traverse + 1);
        newString = newString.Remove(traverse, 1);
        newString = newString.TrimStart();
        
        // Write the string to console then set up new position of the next substring to retrieve
        Console.WriteLine(newString);
        index = periodLocation + 1;
        periodLocation = mystring.IndexOf(".", index);
        traverse = periodLocation - index;
        newString = "";

        // If there is no period then we will retrieve the rest of the string from the current position
        if(periodLocation < 0) {
            newString = mystring.Substring(index);
            newString = newString.TrimStart();
            Console.WriteLine(newString);
        }
    }

}