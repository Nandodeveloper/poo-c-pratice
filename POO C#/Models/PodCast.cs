namespace POO_C_.Models;

internal class PodCast
{
    private List<Episode> episodes = new();
    public string Name { get; }
    public string Host { get; }
    public int TotalEpisodes => episodes.Count;

    public PodCast(string name, string host)
    {
        Name = name;
        Host = host;
    }
    public void AddEpisode(Episode episode)
    {
        episodes.Add(episode);
    }
    public void DisplayDetails()
    {
        Console.WriteLine($"Detalhes do podcast {Name}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Host: {Host}\n");
        Console.WriteLine($"Lista de episodios:");
        foreach (Episode episode in episodes)
        {
            Console.WriteLine($"Episode {episode.Order}: {episode.Summary}");
        }
        Console.WriteLine($"Total de episódios: {TotalEpisodes}");
    }
}