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
