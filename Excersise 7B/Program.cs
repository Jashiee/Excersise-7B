int numercialRange;

Console.WriteLine("Hello user, this program will take the numerical grade and give you a letter grade.");
Console.WriteLine("Please enter your grade ");
numercialRange = Convert.ToInt32(Console.ReadLine());

if (numercialRange >= 0 && numercialRange <= 39)
{
    Console.WriteLine("Your grade is E");
}
else if (numercialRange >= 40 && numercialRange <= 49)
{
    Console.WriteLine(" Your grade is D");
}
else if (numercialRange >= 50 && numercialRange <= 56)
{
    Console.WriteLine(" Your grade is C");
}
else if (numercialRange >= 57 && numercialRange <= 63)
{
    Console.WriteLine(" Your grade is C+");
}
else if (numercialRange >= 64 && numercialRange <= 70)
{
    Console.WriteLine(" Your grade is B");
}
else if (numercialRange >= 71 && numercialRange <= 77)
{
    Console.WriteLine(" Your grade is B+");
}
else if (numercialRange >= 78 && numercialRange <= 84)
{
    Console.WriteLine(" Your grade is A");
}
else if (numercialRange >= 85 && numercialRange <= 100)
{
    Console.WriteLine(" Your grade is A+");
}