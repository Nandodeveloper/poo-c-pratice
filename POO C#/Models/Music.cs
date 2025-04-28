namespace POO_C_.Models;

internal class Music
{
    public string Title { get; }
    public Band Artist { get; }
    public int Duration { get; set; }
    public bool IncluedInPlan { get; set;  }
    public string Description => $"The music {Title} belongs to the band {Artist}";

    public Music(string title, Band artist)
    {
        Title = title;
        Artist = artist;
    }

    public void ViewTechnicalSheet()
    {
        Console.WriteLine($"Name: {Title}");
        Console.WriteLine($"Artist: {Artist.Name}");
        Console.WriteLine($"Duration: {Duration}");
        if (IncluedInPlan)
        {
            Console.WriteLine("This music is inclued in plan!");
        }
        else
        {
            Console.WriteLine("This music is not inclued in plan!");
        }
    }
}