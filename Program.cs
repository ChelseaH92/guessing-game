using System;

Main();

void Main()
{
Console.WriteLine("Guess the Magic Number");
Console.WriteLine("------------------------");
Console.WriteLine("Choose your difficulty level:");
Console.WriteLine();
Console.WriteLine("Press 1: Super Easy");
Console.WriteLine("Press 2: Medium Rare");
Console.WriteLine("Press 3: Good luck, scrub");
Console.WriteLine("Press 4: Unlimited Power");

string level = Console.ReadLine();

int gameGuesses = 4;

switch(level){
    case "1":
    gameGuesses = 8;
    break;
    case "2":
    gameGuesses = 6;
    break;
    case "3":
    gameGuesses = 4;
    break;
    case "4":
    Console.WriteLine("Cheater Cheater Pumpkin Eater");
    gameGuesses = int.MaxValue;
    break;
}

Random r = new Random();
int genRand = r.Next(0,100);

int MagicNumber = genRand;

UserGuess();

void UserGuess()
{
    for (int i = 0; i < gameGuesses; i++)
    { Console.Write("Enter the Magic Number: ");
    Console.WriteLine();
    Console.WriteLine($"Guesses remaining: {gameGuesses-i} ");
    string answer = Console.ReadLine();
    int stringnum = Convert.ToInt32(answer);

    if (stringnum > MagicNumber) 
    {
        Console.WriteLine("Too high, my dude.");

    }
    else if (stringnum < MagicNumber)
    {
        Console.WriteLine("Too low, my dude.");
    }

    else {
        Console.WriteLine("You did it -confetti here-");
        break;
    }}
}}



// alternative way to code this:

// using System

// namespace GuessingGame
// {
//     class Program
// {
// static void Main(string[] args)
// { 

// Console.WriteLine("Wanna play a game?");
// Console.WriteLine("Choose your difficulty level");
// Console.WriteLine("Press 1: Easy Peazy Lemon Squeezy");
// Console.WriteLine("Press 2: Sure, Jan.");
// Console.WriteLine("Press 3: Difficult, difficult, difficult");
// Console.WriteLine("Press 4: So you've chosen death");

// string level = Console.ReadLine();

// switch(level) {
//     case "1":
//     gameTime(8);
//     break;
//     case "2":
//     gameTime(6);
//     break;
//     case "3":
//     gameTime(4);
//     break;
//     case "4":
//     Console.WriteLine("Cheater Cheater Pumpkin Eater");
//     gameTime(int.MaxValue);
//     break;
// }}

// // easy = 8
// // medium = 6
// // hard = 4


// void gameTime (int attempts)
// {
//     int secretNumber = new Random().Next(0, 100);
//     int i = 0;

//     while (i < attempts)
//     {
//         Console.WriteLine("Guess the number");
//         Console.WriteLine($"You have {attempts - i} guess(es) remaining.");
//         string userInput = Console.ReadLine();
//         int parsedUserInput = int.Parse(userInput);

//         if(parsedUserInput == secretNumber)
//         {
//             Console.WriteLine("Great job. You did it. WOW.");
//             break;
//         }
//         else{
//             string help = parsedUserInput > secretNumber ? "The rent is too damn high" : "Too low. Disgusting.";
//             Console.WriteLine($"WRONG-O! TRY AGAIN!! {help}");
//             i++;
//         }
//     }
// }}}