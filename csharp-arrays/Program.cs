/*
string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000";

Console.WriteLine($"First element: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second element: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third element: {fraudulentOrderIDs[2]}");
*/

/*
string[] fraudulentOrderIDs = {"A123", "B456", "C789"};

Console.WriteLine($"First element: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second element: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third element: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";
Console.WriteLine($"Reassign First Element: {fraudulentOrderIDs[0]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");
*/

// Using foreach

// string[] names = {"Rowena", "Robin", "Bao"};
// foreach(string name in names) {
//     Console.WriteLine(name);
// }

int[] inventory = {200, 450, 700, 175, 250};
int sum = 0;
int bin = 0;
foreach(int item in inventory) {
    sum += item;
    bin++;
    Console.WriteLine($"Bin {bin} = {item} items (Running total: {sum})");
}
Console.WriteLine($"We have {sum} items in inventory.");

