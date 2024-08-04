Random dice = new();

int secretValue = dice.Next(0,101);

int guess = 0;
string? input;
bool numInput = false;
Console.WriteLine("Welcome to the guessing game!!!!");
Console.WriteLine("Please guess a number between 0 and 101 \n");

do {
    input = Console.ReadLine();
    numInput = int.TryParse(input, out guess);
    string? result;
    if (guess < secretValue) result = "less than the number";
    else if (guess > secretValue) result = "bigger than the number";
    else result = "You win!!!!!!!!!";
 
    if (numInput) {
        if (result != "You win!!!!!!!!!") Console.WriteLine($"You guessed {input} which is {result}!\n");

        if (result == "You win!!!!!!!!!") {
            Console.WriteLine(result);
            break;
        }

    } else {
        Console.WriteLine("Please input a number");
    }

} while (numInput);