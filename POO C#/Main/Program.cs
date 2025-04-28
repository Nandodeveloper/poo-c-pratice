using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using POO_C_.Menus;
using POO_C_.Models;

Dictionary<string, Band> bandsList = new();

Dictionary<int, Menu> options = new();
options.Add(1, new RegisterBandMenu());
options.Add(2, new RegisterAlbumMenu());
options.Add(3, new ViewAllBandsMenu());
options.Add(4, new RateBandMenu());
options.Add(5, new RateAlbumMenu());
options.Add(6, new DisplayDetailsMenu());
options.Add(0, new ExitMenu());

void DisplayMenuOptions()
{
    Console.WriteLine("Welcome to ScreenSound!");
Console.WriteLine("\n1- Register band");
Console.WriteLine("2- Register a band's album");
Console.WriteLine("3- View all bands");
Console.WriteLine("4- Rate a band");
Console.WriteLine("5- Rate an album");
Console.WriteLine("6- View a band's details");
Console.WriteLine("0- Exit\n");

Console.Write("Enter your option: ");
string keyString = Console.ReadLine();
int key = int.Parse(keyString);
Console.WriteLine();
if (options.ContainsKey(key))
{
    Menu menu = options[key];
    menu.Exe(bandsList);
    if (key > 0) DisplayMenuOptions();
}
else
{
    Console.WriteLine("Invalid option. Please try again.");
}
}
DisplayMenuOptions();