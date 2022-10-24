using System;
ShowCharacter();

CalculateRetailMain();

Celsius();

IsPrimeMain();

static void ShowCharacter()
{
   Console.WriteLine("ShowCharacter Method");
   Console.Write("Enter a string: ");
   string x = Console.ReadLine();

   Console.Write("Enter an integer to determine character position: ");
   int position = Convert.ToInt32(Console.ReadLine()); 

   char index = x[position - 1];
   Console.WriteLine($"The character in position {position} of the string is {index}.\n");

}

//This follows more closely to the lab assignment example
//I just didn't know if we should request input from the user or not
//And just doing both ways would be quicker and easier than waiting on emails
static void ShowCharacter2(string newYork, int place)
{
    char index2 = newYork[place - 1];
    Console.WriteLine($"{index2}");
    
}

static void CalculateRetail(double wholesaleCost, double markup)
{
    double retailPrice = wholesaleCost * markup + wholesaleCost;
    string retailPriceString = retailPrice.ToString("0.00");
    Console.WriteLine($"The total retail price is ${retailPriceString}.\n");
}

static void CalculateRetailMain()
{
    Console.WriteLine("CalculateRetail Method");

    Console.Write("Please enter the wholesale cost for your item: $");
    double x = Convert.ToDouble(Console.ReadLine());

    Console.Write("Please enter the markup percentage (as a decimal) for your item: ");
    double y = Convert.ToDouble(Console.ReadLine());

    CalculateRetail(x, y);
}

static void Celsius()
{
    Console.WriteLine("Celsius Method");
    for (decimal fahrenheit = 80; fahrenheit <= 100; fahrenheit++)
    {
        decimal celsius = (5m / 9m) * (fahrenheit - 32);
        Console.WriteLine($"Temperature in fahrenheit: {fahrenheit}; temperature in celsius: {Math.Round(celsius, 2)}");
    }
}

static bool IsPrime(int integer)
{
    for (int i = 2; i < integer; i++)
    {
        if (integer % i == 0)
        {
            return false;
        }
    }
    return true;
}

//For the IsPrime and IsPrimeMain methods, I used this link to find a more consise
//and easier way to find prime numbers and enter arguments:
//https://www.w3resource.com/csharp-exercises/function/csharp-function-exercise-9.php 
//I reused this process of entering arguments for the CalculateRetail method

static void IsPrimeMain()
{
    Console.WriteLine("\nIsPrime Method");
    Console.Write("Input a number: ");
    int n = Convert.ToInt32(Console.ReadLine());
    if (IsPrime(n))
    {
        Console.WriteLine("True");
    }
    else
    {
        Console.WriteLine("False");
    }
}