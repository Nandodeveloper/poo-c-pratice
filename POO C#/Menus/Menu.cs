using POO_C_.Models;

namespace POO_C_.Menus;

internal class Menu
{
    protected static void DisplayOptionTitle(string title)
    {
        int titleLength = title.Length;
        string asterisks = string.Empty.PadLeft(titleLength, '*');
        Console.WriteLine(asterisks);
        Console.WriteLine(title);
        Console.WriteLine(asterisks + "\n");
    }
    public virtual void Exe(Dictionary<string, Band> bandsList)
    {
        Console.Clear();
    }
}
