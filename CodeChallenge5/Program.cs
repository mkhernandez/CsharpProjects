// Fizz Buzz Challenge - iterate from 1 to 100. If the number is divisible by 3 then print "Fizz"
// If the number is divisible by 5 then print out "Buzz". If the number is divisible by 3 and 5
// Then print out "FizzBuzz" otherwise print out the value

for(int i = 1; i <= 100; i++) {
    string output = "";

    if(i % 3 == 0) {
        output += "Fizz";
    }
    if(i % 5 == 0) {
        output += "Buzz";
    }
    Console.WriteLine(output != "" ? $"{i} - " + output : i);

}
