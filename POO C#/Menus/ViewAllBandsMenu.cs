using POO_C_.Models;

namespace POO_C_.Menus;

internal class ViewAllBandsMenu : Menu
{
    public override void Exe(Dictionary<string, Band> bandsList)
    {
        base.Exe(bandsList);
        DisplayOptionTitle("Bands list");
        foreach (string band in bandsList.Keys)
        {
            Console.WriteLine($"Band: {band}");
        }
        Thread.Sleep(2000);
        Console.Clear();
    }
}
