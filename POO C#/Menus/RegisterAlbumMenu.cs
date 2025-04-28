using POO_C_.Models;

namespace POO_C_.Menus;

internal class RegisterAlbumMenu : Menu
{
    public override void Exe(Dictionary<string, Band> bandsList)
    {
        base.Exe(bandsList);
        DisplayOptionTitle("Register a band's album");
        Console.Write("Enter the band name: ");
        string bandName = Console.ReadLine()!;
        if (bandsList.ContainsKey(bandName))
        {
            Band band = bandsList[bandName];
            Console.Write("Enter the album name: ");
            string albumName = Console.ReadLine()!;
            Album album = new Album(albumName);
            band.AddAlbum(album);
            Console.WriteLine($"The album {albumName} has been successfully registered for the band {bandName}!");
            Thread.Sleep(2000);
            Console.Clear();
        }
        else
        {
            Console.WriteLine("Please enter a valid band.");
            Console.Write("Press a key to return to the menu\n");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
