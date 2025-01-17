// See https://aka.ms/new-console-template for more information
Console.WriteLine("You come to a fork in the road");
Console.WriteLine("Left or Right, Left is town Right is mountain");
string input = Console.ReadLine();
if  (input.Contains("ight"))
{
    Console.WriteLine("You walk right towards the massive mountain");
}
else if (input.Contains("eft"))
{
    Console.WriteLine("You walk left into the wonderful town");
}