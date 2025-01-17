// See https://aka.ms/new-console-template for more information
Console.WriteLine("WHO ARE YOU?");
string input = Console.ReadLine();
string name = input;
Console.WriteLine($"WELCOME {name}?");
Console.WriteLine("HOW DEEP ARE THINE POCKETS?");
string pockets = Console.ReadLine();
int gold = int.Parse(pockets);
Console.WriteLine($"HEY {name}, Care to buy a bronze sword for 15 gold???");
if (gold >= 15)
{
    Console.WriteLine("As you pull out your gold pouch the vendor grabs it and runs leaving you with nothing but the sword");
    gold = 0;
    Console.WriteLine($"You have {gold} gold"); 
}
else
{
    Console.WriteLine("If you don't have gold GET OUT!");
    Console.WriteLine($"You have {gold} gold, and a sword");
}
