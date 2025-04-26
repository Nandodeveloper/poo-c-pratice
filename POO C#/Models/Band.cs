public class Band
{
    private List<Album> albums = new List<Album>();
    public string Name { get; set; }
    public string Genre { get; set; }

    public Band(string name, string genre)
    {
        Name = name;
        Genre = genre;
    }
    public void AddAlbum(Album album)
    {
        albums.Add(album);
    }

    public void ViewDiscography()
    {
        Console.WriteLine($"{Name} band discography:");
        foreach (var album in albums)
        {
            Console.WriteLine($"Álbum: {album.Name} ({album.Duration}s)\n");
        }
    }
}