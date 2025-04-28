using POO_C_.Models;

namespace POO_C_.Menus;

internal class RateAlbumMenu : Menu
{
    public override void Exe(Dictionary<string, Band> bandsList)
    {
        base.Exe(bandsList);
        DisplayOptionTitle("Rate an album");
        Console.Write("Enter the band you want to rate the respective album: ");
        string bandName = Console.ReadLine()!;
        if (bandsList.ContainsKey(bandName))
        {
            Band band = bandsList[bandName];
            Console.Write("Enter de albums name: ");
            string albumName = Console.ReadLine()!;
            if (band.Albums.Any(a => a.Name.Equals(albumName)))
            {
                Album album = band.Albums.First(a => a.Name.Equals(albumName));
                Console.Write("\nEnter the albums rating: ");
                Evaluation rate = Evaluation.Parse(Console.ReadLine()!);
                if (rate.Rate >= 0 && rate.Rate <= 10)
                {
                    album.Rate(rate);
                    Thread.Sleep(2000);
                    Console.WriteLine($"\nNote {rate.Rate} has been successfully registered for the {albumName} album!");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("\nInvalid grade. Grade must be between 0 and 10.\n");
                    Console.Write("Press a key to try again\n");
                    Console.ReadKey();
                    Console.Clear();
                    return;
                }
            }
            else
            {
                Console.WriteLine($"\nThe album {albumName} is not registered.\n");
                Console.Write("Press a key to return to the menu\n");
                Console.ReadKey();
                Console.Clear();
            }
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
