using POO_C_.Models;

namespace POO_C_.Menus;

internal class DisplayDetailsMenu : Menu
{
    public override void Exe(Dictionary<string, Band> bandsList)
    {
        base.Exe(bandsList);
        DisplayOptionTitle("Display the average of a band");
        Console.Write("Enter the band you want to see the review for: ");
        string bandName = Console.ReadLine()!;
        if (bandsList.ContainsKey(bandName))
        {
            Band band = bandsList[bandName];
            Console.WriteLine(band.Resume);
            Console.WriteLine($"\nThe average rating of the band {bandName} is: {band.Average}");
            Console.WriteLine($"\nDiscography:");
            foreach(Album album in band.Albums)
            {
                Console.WriteLine($"Album: {album.Name} ({album.Duration}s), rating: {album.Average}");
            }
            Console.Write("\nPress a key to return to the menu\n");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nThe band {bandName} is not registered.\n");
            Console.Write("Press a key to return to the menu\n");
            Console.ReadKey();
            Console.Clear();
        }
    }
}