// Role playing game battle challenge - In this challenge we must use a do-while or while loop to 
// Execute our game. The hero and monster will start at 10 HP. The hero will attack first and the 
// Attack value will be a number from 1 to 10. Print the amount of health the monster lost and 
// Remaining health of the monster. If the monster health is greater than zero it can attack the hero.
// Print the amount of health the hero lost and the amount of health the hero has left.
// Continue with this sequence until the hero or monster health is less than or equal to zero
using System.Net.Mail;

Random number = new Random();
int heroHealth = 10;
int monsterHealth = 10;
int attack;
// int current = number.Next(1, 11);

/*
do {
    
    current = number.Next(1, 11);
    if(current >= 8) continue;

    Console.WriteLine(current);

} while(current != 7);
*/

/*
while(current >= 3) {
    Console.WriteLine(current);
    current = number.Next(1, 11);
}

Console.WriteLine($"The Last number: {current}");
*/

do {
    attack = number.Next(1, 11);

    // Hero attacks
    Console.WriteLine("Hero attacks!");
    monsterHealth -= attack;

    if(monsterHealth <= 0) {
        continue;
    }
    Console.WriteLine($"The monster lost {attack} HP");
    Console.WriteLine($"The monster has {monsterHealth} HP remaining");
    

    // Monster attacks
    if(monsterHealth > 0) {
        attack = number.Next(1, 11);
        Console.WriteLine("Monster attacks!");
        heroHealth -= attack;

        if(heroHealth <= 0) {
            continue;
        }

        Console.WriteLine($"The hero lost {attack} HP");
        Console.WriteLine($"The hero has {heroHealth} HP remaining");
    }

}while(heroHealth > 0 && monsterHealth > 0);

Console.WriteLine(heroHealth > monsterHealth ? "The hero won!" : "You lose, the monster won.");
