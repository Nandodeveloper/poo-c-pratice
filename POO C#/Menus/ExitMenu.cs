using POO_C_.Models;

namespace POO_C_.Menus;

internal class ExitMenu : Menu
{
    public override void Exe(Dictionary<string, Band> bandsList)
    {
        Console.WriteLine("Tchau tchau ;) ");
    }
}