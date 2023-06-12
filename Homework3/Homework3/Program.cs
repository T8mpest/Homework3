
using System.Runtime.InteropServices;
while (true)
{
    Console.Write("Write your number ");
    var val = int.Parse(Console.ReadLine());
    var condition = (IsPrime(val));

    if (condition)
    {
        Console.WriteLine($" {val} is a prime number ");
    }
    else
    {
        Console.WriteLine($"{val} is NOT prime number");

    }
    
}



static bool IsPrime(int val)
{
    if (val < 2)
        return false;

    for (int i = 2; i <= val / 2; i++)
    {
        if (val % i == 0)
            return false;
    }

    return true;
}



