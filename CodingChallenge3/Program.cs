/* 
Random flip = new Random();
int coin = flip.Next(0, 2);
Console.WriteLine(coin == 0 ? "heads" : "tails");
*/

Random pick = new Random();
int assigned = pick.Next(1, 4);
string permission = "Admin|Manager";
int level = pick.Next(1, 75);

// Logic to determine which message to write to console based upon if the user is an admin or not and what level
// of access they have
if (assigned == 1)
    permission = "Admin";

else if (assigned == 2)
    permission = "Manager";

else
    permission = "User";

if (permission == "Admin")
{
    if (level > 55)
        Console.WriteLine($"Welcome Super {permission} user.");

    else
        Console.WriteLine($"Welcome, {permission} user.");
}
else if (permission == "Manager")
{
    if (level >= 20)
        Console.WriteLine("Contact an admin for access.");

    else
        Console.WriteLine("You do not have sufficient privileges.");
}
else
    Console.WriteLine("You do not have sufficient privileges.");




