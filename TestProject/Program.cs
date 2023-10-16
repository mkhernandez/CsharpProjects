using System.Collections;
/* 
    Random die1 = new Random();
    int roll1 = die1.Next();
    int roll2 = die1.Next(101);
    int roll3 = die1.Next(50, 101);
    Console.WriteLine($"First roll: {roll1}");
    Console.WriteLine($"Second roll: {roll2}");
    Console.WriteLine($"Third roll: {roll3}");
*/
/* 
    int firstValue = 500;
    int secondValue = 600;
    int largerValue = Math.Max(firstValue, secondValue);
    Console.WriteLine(largerValue);
*/
Random dice = new Random();
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if(roll1 == roll2 || roll2 == roll3 || roll1 == roll3) {
    if((roll1 == roll2) && (roll2 == roll3)) {
    Console.WriteLine("You rolled triples! +6 bonus!");
    total += 6;
    Console.WriteLine($"Total is now: {total}");
    } else {
        Console.WriteLine("You rolled doubles! +2 bonus on total!");
        total += 2;
        Console.WriteLine($"Total is now: {total}");
    }
    
}

if(total >= 16) {
    Console.WriteLine("You win a new car!");
}
else if(total >= 10) {
    Console.WriteLine("You win a new laptop!");
} else if(total == 7) {
    Console.WriteLine("You win a trip for two!");
} else {
    Console.WriteLine("You win a kitten! Meow!");
}

/*
    string message = "The quick brown fox jumps over the lazy dog.";
    bool result = message.Contains("dog");
    Console.WriteLine($"Result is: {result}");

    if(message.Contains("fox")) Console.WriteLine("What did the fox say?");
*/






