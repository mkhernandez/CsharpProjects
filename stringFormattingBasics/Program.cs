string first = "Hello";
string second = "World";
// string result = string.Format("{0}, {1}!", first, second);
// Console.WriteLine(result);

// string result = string.Format("{1}, {0}!", first, second);
// Console.WriteLine(result);

string result = string.Format("{1}, {1}, {1}", first, second);
Console.WriteLine(result);
