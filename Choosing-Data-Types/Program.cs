/*
Console.WriteLine("SIGNED INTEGRAL TYPES");
Console.WriteLine("========================");

Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

Console.WriteLine("");
Console.WriteLine("UNSIGNED INTEGRAL TYPES");
Console.WriteLine("==========================");

Console.WriteLine($"byte    : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort  : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint    : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong   : {ulong.MinValue} to {ulong.MaxValue}");
*/

// Console.WriteLine("FLOATING POINT TYPES");
// Console.WriteLine("======================");

// Console.WriteLine($"float   : {float.MinValue} to {float.MaxValue} (with ~6 - 9 digits of precision)");
// Console.WriteLine($"double  : {double.MinValue} to {double.MaxValue} (with ~15 - 17 digits of precision)");
// Console.WriteLine($"decimal : {decimal.MinValue} to {decimal.MaxValue} (with ~28 - 29 digits of precision)");

// Can do this way 
// int[] data;
// data = new int[3];

// Or this way
using System.Net;

int[] data = new int[3];

// Data-type casting and conversion
// This throws an error 
// int first = 2;
// string second = "4";
// int result = first + second;
// Console.WriteLine(result);

// Change result to string type
// This works
// int first = 2;
// string second = "4";
// int number = Int32.Parse(second);
// string result = first + second;
// Console.WriteLine(result);

// Changing data type - no loss of information
// Widening conversion - Converting from a data type that holds less than the data type being converted to
// In this case int can fit in a decimal data type there is no loss of information. This is widening conversion
// int myInt = 3;
// Console.WriteLine($"int: {myInt}");

// decimal myDecimal = myInt;
// Console.WriteLine($"decimal: {myDecimal}");

// Changing data type - loss of information(casting)
// Loss of information - this is an explicit conversion - you are telling the compiler that you know there
// is a loss of information and you're okay with it
// decimal myDecimal = 3.14m;
// Console.WriteLine($"Decimal: {myDecimal}");

// int myInt = (int)myDecimal;
// Console.WriteLine($"Integer: {myInt}");

// Performing a narrowing conversion
// decimal myDecimal = 1.23456789m;
// float myFloat = (float)myDecimal;

// Console.WriteLine($"Decimal: {myDecimal}");
// Console.WriteLine($"Float:   {myFloat}");

// Converting integer to string
// int first = 5;
// int second = 8;
// Changed to string then concatenated together
// string message1 = first.ToString() + second.ToString();
// In the following line of code both integer values will be added together then converted into a string
// Notice how different the answer is to the other way the string was manipulated
// string message2 = (first + second).ToString();
// Console.WriteLine($"This is first and second converted to string: {message1}");
// Console.WriteLine($"\nThis is first and second added together then converted to string: {message2}");

// Converting string to int using Parse helper method
// string first = "6";
// string second = "9";
// int sum = int.Parse(first) + int.Parse(second);
// Console.WriteLine(sum);

// Converting string to int using Convert class
// The Convert class is best used when converting fractional numbers into whole numbers because it rounds up
// the way you would expect it to
// string value1 = "5";
// string value2 = "9";
// int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
// Console.WriteLine(result);

// Comparing casting and converting a decimal to int
// Casting truncates the value
// int value = (int)1.5m;
// Console.WriteLine(value);

// Converting rounds up
// int value2 = Convert.ToInt32(1.5m);
// Console.WriteLine(value2);

// Using the TryParse method
// string name = "Bob";
// this throws an error
// Console.WriteLine(int.Parse(name));

// Use TryParse instead
// bool validEntry = false;
// int value;
// validEntry = int.TryParse(name, out value);
// if(validEntry) {
//     Console.WriteLine($"The parse worked. Here is the value: {value}");
// }
// else {
//     Console.WriteLine($"Uh-Oh! \"{name}\" could not be parsed.");
// }

// TryParse on a string to an int
// string value = "bad";
// int result = 0;
// if(int.TryParse(value, out result)) {
//     Console.WriteLine($"The measurement is: {result}");
// } else {
//     Console.WriteLine("Unable to report the measurement");
// }

// if(result > 0)
// Console.WriteLine($"Measurement (w/offset): {50 + result}");

// Coding Challenge - Combine string array values as strings and as integers
// string[] values = {"12.3", "45", "ABC", "11", "DEF"};
// float number = 0;
// string arrayValues = "";

// for(int i = 0; i < values.Length; i++) {
//     float temp;
//     if(float.TryParse(values[i], out temp)) {
//         number += temp;
//     } else {
//         arrayValues += values[i];
//     }
// }

// Console.WriteLine($"Message: {arrayValues}");
// Console.WriteLine($"Total: {number}");

// Coding Challenge - Output math operations as specific number types
int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;
int result1 = value1 / Convert.ToInt32(value2);
decimal result2 = value2 / (decimal)value3;
float result3 = value3 / value1;
Console.WriteLine($"Divide value1 by value2, display the result as int: {result1}");
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");


