using POO_C_.Interfaces;

namespace POO_C_.Models;

internal class Band : IRatable
{
    private List<Album> albums = new();
    private List<Evaluation> rates = new();
    public Band(string name)
    {
        Name = name;
    }
    public string Name { get; set; }
    public string? Resume { get; set; }
    public double Average
    {
        get
        {
            if (rates.Count == 0)
            {
                return 0;
            } 
            else
            {
                return rates.Average(evaluation => evaluation.Rate);
            }
        }
    }
    public List<Album> Albums => albums;

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

    public void Rate(Evaluation rate)
    {
        rates.Add(rate);
    }
}