Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

/*
    This challenge is to improve renewal rate for subscriptions
    The company wants to improve renewal rates by adding a prompt to the user when their
    subscription is nearing expiration
    1) There should only be one message displayed
    2) If the user's subscription expires in 10 days or less, display the message:
       Your subscription will expire soon. Renew now!
    3) If the user's subscription expires in five days or less, display the messages:
       Your subscription expires in _ days.
       Renew now and save 10%! 
    4) If the user's subscription will expire in one day, display the messages:
       Your subscription expires within a day!
       Renew now and save 20%! 
    5) If the user's subscription has expired, display the message:
       Your subscription has expired.
    6) If the user's subscription doesn't expire in 10 days or less, display nothing 
*/

if(daysUntilExpiration == 0) {
    Console.WriteLine("Your subscription has expired.");
} else if(daysUntilExpiration == 1) {
    discountPercentage = 20;
    Console.WriteLine($@"Your subscription expires within a day!
Renew now and save {discountPercentage}%!");
} else if(daysUntilExpiration <= 5) {
    discountPercentage = 10;
    Console.WriteLine($@"Your subscription expires in {daysUntilExpiration} days.
Renew now and save {discountPercentage}%!");

} else if(daysUntilExpiration <= 10) {
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}
