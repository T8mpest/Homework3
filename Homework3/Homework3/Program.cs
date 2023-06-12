
var strValue = Console.ReadLine();  
var val = int.Parse(strValue);
var condition = val >= 1 && val / val == 1;
if (condition)
{
    Console.WriteLine($" {val} is a prime number ");
}
else
{
    Console.WriteLine($"{val} is NOT prime number");
}
Console.ReadLine();

