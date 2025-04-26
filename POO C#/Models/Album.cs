public class Album
{
    public List<Music> musics = new List<Music>();
    public string Name { get; }
    public int Duration => musics.Sum(music => music.Duration);

    public Album(string name)
    {
        Name = name;
    }

    public void AddMusic(Music music)
    {
        musics.Add(music);
    }

    public void DisplayMusics()
    {
        Console.WriteLine($"Lista de músicas do álbum {Name}:\n");
        foreach (Music music in musics)
        {
            Console.WriteLine($"Music: {music.Title}");
        }
        Console.WriteLine($"Duração do álbum {Name}: {Duration}s");
    }
}