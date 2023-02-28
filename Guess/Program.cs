using System;

double n = new Random().Next(1,11);

Console.WriteLine("Guess a number between 1 and 10: ");

Console.WriteLine(n);
double guess = Convert.ToDouble(Console.ReadLine());
double guesses = 3;

while (guess != n && guesses > 0)
{
    guesses = guesses - 1;

    if (guess > n && guesses > 0)
    {
        Console.WriteLine("Too high");
        Console.WriteLine("Guess again: ");
        guess = Convert.ToDouble(Console.ReadLine());
    }


    else if (guess < n && guesses > 0)
    {
        Console.WriteLine("Too low");
        Console.WriteLine("Guess again: ");
        guess = Convert.ToDouble(Console.ReadLine());
    }
}

if (guess == n && guesses > 0)
{
    Console.WriteLine("You guessed correct!");
}

if (guesses == 0)
{
    Console.WriteLine("You lose!");
}



